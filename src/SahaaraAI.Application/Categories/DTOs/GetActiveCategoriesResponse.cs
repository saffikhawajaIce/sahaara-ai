namespace SahaaraAI.Application.Categories.DTOs;

public class GetActiveCategoriesResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<CategoryDto> Categories { get; set; } = [];
}
