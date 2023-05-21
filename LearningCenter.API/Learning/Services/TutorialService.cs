using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Domain.Services.Communication;

namespace LearningCenter.API.Learning.Services;

public class TutorialService : ITutorialService
{
    private readonly ITutorialRepository _tutorialRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICategoryRepository _categoryRepository;

    public TutorialService(ITutorialRepository tutorialRepository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
    {
        _tutorialRepository = tutorialRepository;
        _unitOfWork = unitOfWork;
        _categoryRepository = categoryRepository;
    }

    public Task<IEnumerable<Tutorial>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tutorial>> ListByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<TutorialResponse> SaveAsync(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public Task<TutorialResponse> UpdateAsync(int tutorialId, Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public Task<TutorialResponse> DeleteAsync(int tutorialId)
    {
        throw new NotImplementedException();
    }
}