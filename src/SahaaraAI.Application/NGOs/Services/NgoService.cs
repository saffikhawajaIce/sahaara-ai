using SahaaraAI.Application.NGOs.DTOs;

namespace SahaaraAI.Application.NGOs.Services;

public class NgoService : INgoService
{
    public Task<CreateNgoResponseDTO> CreateNgoAsync(CreateNgoRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetNgoResponseDTO> GetNgoByIdAsync(Guid ngoId)
    {
        throw new NotImplementedException();
    }

    public Task<SearchNgosResponseDTO> SearchNgosAsync(NgoSearchRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateNgoResponseDTO> UpdateNgoAsync(Guid ngoId, UpdateNgoRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<DeactivateNgoResponseDTO> DeactivateNgoAsync(Guid ngoId)
    {
        throw new NotImplementedException();
    }

    public Task<ReactivateNgoResponseDTO> ReactivateNgoAsync(Guid ngoId)
    {
        throw new NotImplementedException();
    }
}
