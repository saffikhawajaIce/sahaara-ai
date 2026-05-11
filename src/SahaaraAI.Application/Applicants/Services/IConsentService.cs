using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SahaaraAI.Application.Applicants.DTOs;

namespace SahaaraAI.Application.Applicants.Services;

public interface IConsentService
{
    Task RecordConsentAsync(Guid applicantId, UpdateConsentRequestDTO request);
    Task<IEnumerable<ConsentRecordDto>> GetConsentHistoryAsync(Guid applicantId);
    Task<bool> HasValidConsentAsync(Guid applicantId);
}

