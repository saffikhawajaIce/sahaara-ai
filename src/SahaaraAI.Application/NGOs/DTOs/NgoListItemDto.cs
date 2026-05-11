using SahaaraAI.Domain.Enums;

namespace SahaaraAI.Application.NGOs.DTOs;

public class NgoListItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Area { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public NgoStatus Status { get; set; }
    public bool IsActive { get; set; }
}
