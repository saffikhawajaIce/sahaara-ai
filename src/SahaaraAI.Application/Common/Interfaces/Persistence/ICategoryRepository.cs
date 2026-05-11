using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Application.Common.Interfaces.Persistence;

public interface ICategoryRepository
{
    Task<IEnumerable<AssistanceCategory>> GetActiveCategoriesAsync();
    Task<AssistanceCategory?> GetCategoryByIdAsync(Guid id);
    Task<AssistanceSubcategory?> GetSubcategoryByIdAsync(Guid id);
    Task AddCategoryAsync(AssistanceCategory category);
    Task AddSubcategoryAsync(AssistanceSubcategory subcategory);
}
