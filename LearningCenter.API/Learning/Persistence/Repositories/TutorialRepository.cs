using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Shared.Persistence.Contexts;

namespace LearningCenter.API.Shared.Persistence.Repositories;

public class TutorialRepository : BaseRepository, ITutorialRepository
{
    public TutorialRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Tutorial>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public Task<Tutorial> FindByIdAsync(int tutorialId)
    {
        throw new NotImplementedException();
    }

    public Task<Tutorial> FindByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public void Update(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public void Remove(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }
}