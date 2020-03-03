using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Domain.Models;


namespace Web.Odev.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
