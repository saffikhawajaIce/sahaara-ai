namespace SahaaraAI.Application.Reports.DTOs;

public class ReportFilterRequestDTO
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? NgoId { get; set; }
    public string? Status { get; set; }
}
