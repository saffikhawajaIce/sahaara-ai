namespace SahaaraAI.Application.Categories.DTOs;

public class DeactivateCategoryResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
}
