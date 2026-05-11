using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.Cases.DTOs;

public class UpdateCaseStatusRequestDTO
{
    public CaseStatus Status { get; set; }
    public string? Notes { get; set; }
}
