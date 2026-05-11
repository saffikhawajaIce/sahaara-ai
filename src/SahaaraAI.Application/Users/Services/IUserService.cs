using SahaaraAI.Application.Users.DTOs;
namespace SahaaraAI.Application.Users.Services;

public interface IUserService
{
    Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request);
    Task<UserResponseDto> GetUserByIdAsync(Guid id);
    Task<IEnumerable<UserListItemDto>> GetUsersAsync(GetUsersRequestDTO request);
    Task<UpdateUserResponseDto> UpdateUserAsync(Guid id, UpdateUserRequestDTO request);
    Task<DeactivateUserResponseDTO> DeactivateUserAsync(Guid id);
}

