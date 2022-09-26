using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;

namespace Framework.LeadsManager.Domain.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository Repository;

        public CategoryService(ICategoryRepository repository) : base(repository) => Repository = repository;
    }
}
