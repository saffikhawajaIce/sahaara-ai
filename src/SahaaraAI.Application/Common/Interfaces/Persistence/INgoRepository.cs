using SahaaraAI.Application.NGOs.DTOs;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface INgoRepository
{
    Task AddAsync(Ngo ngo);
    Task<Ngo?> GetByIdAsync(Guid id);
    Task<Ngo?> GetDetailedByIdAsync(Guid id);
    Task<IEnumerable<Ngo>> SearchAsync(NgoSearchRequestDTO request);
    Task<IEnumerable<Ngo>> GetActiveNgosWithServicesAsync();
    void Update(Ngo ngo);
}
