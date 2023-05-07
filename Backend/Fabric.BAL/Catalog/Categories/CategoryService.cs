using Fabric.Data.EF;
using Fabric.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.BAL.Catalog.Categories
{
    public class CategoryService: ICategoryService
    {
        readonly FabricDBContext _context;
        public CategoryService(FabricDBContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            var query = from c in _context.Categories select c;
            return await query.ToListAsync();
        }
    }
}
