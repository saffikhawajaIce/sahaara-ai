using SahaaraAI.Application.Reports.DTOs;

namespace SahaaraAI.Application.Reports.Services;

public class ReportsService : IReportsService
{
    public Task<IEnumerable<CaseCategoryReportDto>> GetCasesByCategoryAsync(ReportFilterRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CaseStatusReportDto>> GetCasesByStatusAsync(ReportFilterRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<NgoResponseReportDto>> GetNgoResponseReportAsync(ReportFilterRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<MonthlyCaseReportDto>> GetMonthlyCaseReportAsync(ReportFilterRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
