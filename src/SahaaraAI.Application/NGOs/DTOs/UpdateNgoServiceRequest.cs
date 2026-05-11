namespace SahaaraAI.Application.NGOs.DTOs;

public class UpdateNgoServiceRequestDTO
{
    public Guid CategoryId { get; set; }
    public Guid? SubcategoryId { get; set; }
    public string? Description { get; set; }
    public string? EligibilityNotes { get; set; }
    public bool IsActive { get; set; }
}
