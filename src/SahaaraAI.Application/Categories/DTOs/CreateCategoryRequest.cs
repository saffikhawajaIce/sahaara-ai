namespace SahaaraAI.Application.Categories.DTOs;

public class CreateCategoryRequestDTO
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int SortOrder { get; set; }
}
