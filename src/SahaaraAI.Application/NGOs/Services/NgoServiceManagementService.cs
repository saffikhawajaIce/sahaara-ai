using SahaaraAI.Application.NGOs.DTOs;

namespace SahaaraAI.Application.NGOs.Services;

public class NgoServiceManagementService : INgoServiceManagementService
{
    public Task<AddNgoServiceResponseDTO> AddServiceAsync(Guid ngoId, AddNgoServiceRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateNgoServiceResponseDTO> UpdateServiceAsync(Guid ngoServiceId, UpdateNgoServiceRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<RemoveNgoServiceResponseDTO> RemoveServiceAsync(Guid ngoServiceId)
    {
        throw new NotImplementedException();
    }

    public Task<GetNgoServicesResponseDTO> GetServicesByNgoAsync(Guid ngoId)
    {
        throw new NotImplementedException();
    }
}
