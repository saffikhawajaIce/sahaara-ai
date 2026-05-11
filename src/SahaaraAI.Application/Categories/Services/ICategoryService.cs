using SahaaraAI.Application.Categories.DTOs;

namespace SahaaraAI.Application.Categories.Services;

public interface ICategoryService
{
    Task<GetActiveCategoriesResponseDTO> GetActiveCategoriesAsync();
    Task<GetCategoryResponseDTO> GetCategoryByIdAsync(Guid id);
    Task<CreateCategoryResponseDTO> CreateCategoryAsync(CreateCategoryRequestDTO request);
    Task<UpdateCategoryResponseDTO> UpdateCategoryAsync(Guid id, UpdateCategoryRequestDTO request);
    Task<DeactivateCategoryResponseDTO> DeactivateCategoryAsync(Guid id);
    Task<CreateSubcategoryResponseDTO> CreateSubcategoryAsync(Guid categoryId, CreateSubcategoryRequestDTO request);
}
