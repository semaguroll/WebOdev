using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Domain.Models;
using Web.Odev.Repository;

namespace Web.Odev.Services
{
    public class ProductService
    {
        private readonly ICategoryRepository _categoryRepository;

        public ProductService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
