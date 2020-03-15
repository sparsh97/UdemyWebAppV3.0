using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWeb.Models
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly DataContext _appDbContext;

        public CategoryRepository(DataContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories
        {
            get
            {
                return _appDbContext.Categories.ToList();
            }
        }

        //public Category GetCategoryById(int CategoryId)
        //{
        //    return _appDbContext.Categories.FirstOrDefault(p => p.CategoryId == CategoryId);
        //}
    }
}
