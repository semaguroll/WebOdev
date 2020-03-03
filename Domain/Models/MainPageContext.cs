using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Odev.Domain.Models
{
    public class MainPageContext : DbContext
    {
        public MainPageContext(DbContextOptions<MainPageContext> options)
           : base(options)
        {
            
        }

        public DbSet<MainPage> MainPage { get; set; }
    }
}
