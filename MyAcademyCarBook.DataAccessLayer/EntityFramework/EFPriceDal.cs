using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntityFramework
{
    public class EFPriceDal : GenericRepository<Price>, IPriceDal
    {
        public List<Price> GetPricesWithCars()
        {
           var c = new CarBookContext();
            var values = c.prices.Include(x => x.car).ThenInclude(y=>y.brand).ToList();
            return values;
        }
    }
}
