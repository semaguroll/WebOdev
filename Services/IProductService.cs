using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Domain.Models;

namespace Web.Odev.Services
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> ListAsync();
    }
}
