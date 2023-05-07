using Fabric.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.BAL.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategories();
    }
}
