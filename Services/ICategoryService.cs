using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Odev.Domain.Models;

namespace Web.Odev.Services
{
    public interface ICategoryService
    {

        Task<IEnumerable<Category>> ListAsync();
    }
}

//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Supermarket.API.Domain.Models;

//namespace Supermarket.API.Domain.Services
//{
//    public interface ICategoryService
//    {
//        Task<IEnumerable<Category>> ListAsync();
//    }
//}