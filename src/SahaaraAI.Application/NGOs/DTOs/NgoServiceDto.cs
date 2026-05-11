namespace SahaaraAI.Application.NGOs.DTOs;

public class NgoServiceDto
{
    public Guid Id { get; set; }
    public Guid NgoId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? Description { get; set; }
    public string? EligibilityNotes { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
