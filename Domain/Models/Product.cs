using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Odev.Domain.Models
{
    public class Product

    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }                       
        public string Description { get; set; }
        public string Info { get; set; }
        public EUnitOfMeasurement Size { get; set; }

        public int CategoryId { get; set; }
        
        //public Category Category { get; set; }
    }
}