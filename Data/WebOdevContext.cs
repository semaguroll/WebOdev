using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Odev.Domain.Models;

namespace Web.Odev.Data
{

    public class WebOdevContext : DbContext
    {
        public WebOdevContext (DbContextOptions<WebOdevContext> options)
            : base(options)
        {
        }

        public DbSet<Web.Odev.Domain.Models.Category> Category { get; set; }
        public DbSet<Web.Odev.Domain.Models.MainPage> MainPage { get; set; }
        public DbSet<Web.Odev.Domain.Models.Product> Product { get; set; }

    }

}
