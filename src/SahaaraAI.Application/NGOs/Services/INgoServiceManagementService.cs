using SahaaraAI.Application.NGOs.DTOs;

namespace SahaaraAI.Application.NGOs.Services;

public interface INgoServiceManagementService
{
    Task<AddNgoServiceResponseDTO> AddServiceAsync(Guid ngoId, AddNgoServiceRequestDTO request);
    Task<UpdateNgoServiceResponseDTO> UpdateServiceAsync(Guid ngoServiceId, UpdateNgoServiceRequestDTO request);
    Task<RemoveNgoServiceResponseDTO> RemoveServiceAsync(Guid ngoServiceId);
    Task<GetNgoServicesResponseDTO> GetServicesByNgoAsync(Guid ngoId);
}
