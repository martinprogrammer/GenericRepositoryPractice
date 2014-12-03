using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepositoryPractice.Models
{
    public class CarsRepository : GenericAbstract<Car, CarsContext>, IGenericRepository<Car>
    {
    }
}