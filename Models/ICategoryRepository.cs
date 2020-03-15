using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWeb.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category>Categories { get; }
        //Category GetCategoryById(int CategoryId);
    }
}
