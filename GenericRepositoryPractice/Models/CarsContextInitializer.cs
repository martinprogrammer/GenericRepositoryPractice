using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GenericRepositoryPractice.Models
{
    public class CarsContextInitializer : DropCreateDatabaseIfModelChanges<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            context.Cars.Add(new Car
            {
                Make = "BMW",
                Model = "X5"
            });
            context.Cars.Add(new Car
            {
                Make = "Toyota",
                Model = "Rav4"
            });
            context.Cars.Add(new Car
            {
                Make = "Honda",
                Model = "CR-V"
            });
            context.Cars.Add(new Car
            {
                Make = "Mitsubishi",
                Model = "Shogun"
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}