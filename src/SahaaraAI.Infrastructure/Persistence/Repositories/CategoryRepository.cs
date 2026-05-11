using Microsoft.EntityFrameworkCore;
using SahaaraAI.Application.Common.Interfaces.Persistence;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly SahaaraDbContext _dbContext;

    public CategoryRepository(SahaaraDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AssistanceCategory>> GetActiveCategoriesAsync() =>
        await _dbContext.AssistanceCategories.Include(x => x.Subcategories).Where(x => x.IsActive).ToListAsync();

    public Task<AssistanceCategory?> GetCategoryByIdAsync(Guid id) =>
        _dbContext.AssistanceCategories.Include(x => x.Subcategories).FirstOrDefaultAsync(x => x.Id == id);

    public Task<AssistanceSubcategory?> GetSubcategoryByIdAsync(Guid id) =>
        _dbContext.AssistanceSubcategories.FirstOrDefaultAsync(x => x.Id == id);

    public Task AddCategoryAsync(AssistanceCategory category) => _dbContext.AssistanceCategories.AddAsync(category).AsTask();

    public Task AddSubcategoryAsync(AssistanceSubcategory subcategory) => _dbContext.AssistanceSubcategories.AddAsync(subcategory).AsTask();
}
