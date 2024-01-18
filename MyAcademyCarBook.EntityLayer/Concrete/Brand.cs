using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Brand
    {
        public int brandID { get; set; }
        public string brandName { get; set; }
        public bool brandStatus { get; set; }
        public List<Car> cars { get; set; }

    }
}
