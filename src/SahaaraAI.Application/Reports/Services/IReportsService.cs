using SahaaraAI.Application.Reports.DTOs;

namespace SahaaraAI.Application.Reports.Services;

public interface IReportsService
{
    Task<IEnumerable<CaseCategoryReportDto>> GetCasesByCategoryAsync(ReportFilterRequestDTO request);
    Task<IEnumerable<CaseStatusReportDto>> GetCasesByStatusAsync(ReportFilterRequestDTO request);
    Task<IEnumerable<NgoResponseReportDto>> GetNgoResponseReportAsync(ReportFilterRequestDTO request);
    Task<IEnumerable<MonthlyCaseReportDto>> GetMonthlyCaseReportAsync(ReportFilterRequestDTO request);
}
