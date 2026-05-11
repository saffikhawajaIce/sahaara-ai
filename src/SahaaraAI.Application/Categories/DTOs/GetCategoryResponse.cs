namespace SahaaraAI.Application.Categories.DTOs;

public class GetCategoryResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public CategoryDto? Category { get; set; }
}
