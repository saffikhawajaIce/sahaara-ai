using System;
using System.Threading.Tasks;
using SahaaraAI.Application.Applicants.DTOs;

namespace SahaaraAI.Application.Applicants.Services;

public interface IApplicantService
{
    Task<CreateApplicantResponseDTO> CreateApplicantAsync(CreateApplicantRequestDTO request);
    Task<GetApplicantResponseDTO> GetApplicantByIdAsync(Guid applicantId);
    Task<SearchApplicantsResponseDTO> SearchApplicantsAsync();
    Task<UpdateApplicantResponseDTO> UpdateApplicantAsync(Guid applicantId, UpdateApplicantRequestDTO request);
}

