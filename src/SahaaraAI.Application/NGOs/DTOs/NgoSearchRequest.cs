using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.NGOs.DTOs;

public class NgoSearchRequestDTO
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string? SearchTerm { get; set; }
    public string? City { get; set; }
    public string? Area { get; set; }
    public Guid? CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public NgoStatus? Status { get; set; }
    public bool? IsActive { get; set; }
}
