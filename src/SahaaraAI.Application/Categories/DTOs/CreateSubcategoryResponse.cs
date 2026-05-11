namespace SahaaraAI.Application.Categories.DTOs;

public class CreateSubcategoryResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public SubcategoryDto? Subcategory { get; set; }
}
