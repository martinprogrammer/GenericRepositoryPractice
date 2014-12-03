using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepositoryPractice.Models
{
    public class CarsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}