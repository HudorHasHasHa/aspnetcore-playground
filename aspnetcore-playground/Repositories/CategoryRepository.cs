using aspnetcore_playground.Models;

namespace aspnetcore_playground.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BakeryDbContext _db;
        public CategoryRepository(BakeryDbContext db)
        {
            _db = db; 
        }

        public IEnumerable<Category> AllCategories =>
            _db.Categories.OrderBy(p => p.CategoryName);
    }
}
