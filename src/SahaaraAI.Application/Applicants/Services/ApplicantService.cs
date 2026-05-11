using SahaaraAI.Application.Applicants.DTOs;

namespace SahaaraAI.Application.Applicants.Services;

public class ApplicantService : IApplicantService
{
    public Task<CreateApplicantResponseDTO> CreateApplicantAsync(CreateApplicantRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<GetApplicantResponseDTO> GetApplicantByIdAsync(Guid applicantId)
    {
        throw new NotImplementedException();
    }

    public Task<SearchApplicantsResponseDTO> SearchApplicantsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateApplicantResponseDTO> UpdateApplicantAsync(Guid applicantId, UpdateApplicantRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
