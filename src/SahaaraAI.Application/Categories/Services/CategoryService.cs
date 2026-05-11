using SahaaraAI.Application.Categories.DTOs;

namespace SahaaraAI.Application.Categories.Services;

public class CategoryService : ICategoryService
{
    public Task<GetActiveCategoriesResponseDTO> GetActiveCategoriesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<GetCategoryResponseDTO> GetCategoryByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<CreateCategoryResponseDTO> CreateCategoryAsync(CreateCategoryRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateCategoryResponseDTO> UpdateCategoryAsync(Guid id, UpdateCategoryRequestDTO request)
    {
        throw new NotImplementedException();
    }

    public Task<DeactivateCategoryResponseDTO> DeactivateCategoryAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<CreateSubcategoryResponseDTO> CreateSubcategoryAsync(Guid categoryId, CreateSubcategoryRequestDTO request)
    {
        throw new NotImplementedException();
    }
}
