using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Price
    {
        public int priceID { get; set; }
        public int carID { get; set; }
        public Car car { get; set; }
        public string priceType { get; set; }
        public decimal priceValue { get; set; }
    }
}
