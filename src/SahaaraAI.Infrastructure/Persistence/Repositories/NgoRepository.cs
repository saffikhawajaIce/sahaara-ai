using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Application.NGOs.DTOs;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class NgoRepository : INgoRepository
{
    private readonly SahaaraDbContext _dbContext;

    public NgoRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task AddAsync(Ngo ngo) => _dbContext.Ngos.AddAsync(ngo).AsTask();

    public Task<Ngo?> GetByIdAsync(Guid id) => _dbContext.Ngos.FirstOrDefaultAsync(x => x.Id == id);

    public Task<Ngo?> GetDetailedByIdAsync(Guid id) =>
        _dbContext.Ngos.Include(x => x.Services).FirstOrDefaultAsync(x => x.Id == id);

    public async Task<IEnumerable<Ngo>> SearchAsync(NgoSearchRequestDTO request)
    {
        var query = _dbContext.Ngos.AsQueryable();

        if (!string.IsNullOrWhiteSpace(request.SearchTerm))
        {
            query = query.Where(x => x.Name.Contains(request.SearchTerm));
        }

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<Ngo>> GetActiveNgosWithServicesAsync() =>
        await _dbContext.Ngos.Include(x => x.Services).Where(x => x.IsActive).ToListAsync();

    public void Update(Ngo ngo) => _dbContext.Ngos.Update(ngo);
}
