namespace SahaaraAI.Application.Categories.DTOs;

public class SubcategoryDto
{
    public Guid Id { get; set; }
    public Guid AssistanceCategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
