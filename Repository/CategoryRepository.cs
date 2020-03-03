using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Data;
using Web.Odev.Domain.Models;

namespace Web.Odev.Repository
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Supermarket.API.Domain.Models;
//using Supermarket.API.Domain.Repositories;
//using Supermarket.API.Persistence.Contexts;

//namespace Supermarket.API.Persistence.Repositories
//{
//    public class CategoryRepository : BaseRepository, ICategoryRepository
//    {
//        public CategoryRepository(AppDbContext context) : base(context)
//        {
//        }

//        public async Task<IEnumerable<Category>> ListAsync()
//        {
//            return await _context.Categories.ToListAsync();
//        }
//    }
//}