using SahaaraAI.Application.NGOs.DTOs;

namespace SahaaraAI.Application.NGOs.Services;

public interface INgoService
{
    Task<CreateNgoResponseDTO> CreateNgoAsync(CreateNgoRequestDTO request);
    Task<GetNgoResponseDTO> GetNgoByIdAsync(Guid ngoId);
    Task<SearchNgosResponseDTO> SearchNgosAsync(NgoSearchRequestDTO request);
    Task<UpdateNgoResponseDTO> UpdateNgoAsync(Guid ngoId, UpdateNgoRequestDTO request);
    Task<DeactivateNgoResponseDTO> DeactivateNgoAsync(Guid ngoId);
    Task<ReactivateNgoResponseDTO> ReactivateNgoAsync(Guid ngoId);
}
