using SahaaraAI.Application.Users.DTOs;

namespace SahaaraAI.Application.Users.Services;

public class UserService : IUserService
{
    public Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<UserResponseDto> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserListItemDto>> GetUsersAsync(GetUsersRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateUserResponseDto> UpdateUserAsync(Guid id, UpdateUserRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<DeactivateUserResponseDTO> DeactivateUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
