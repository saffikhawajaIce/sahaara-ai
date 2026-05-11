namespace SahaaraAI.Application.NGOs.DTOs;

public class SearchNgosResponseDTO
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public List<NgoListItemDto> Ngos { get; set; } = [];
}
