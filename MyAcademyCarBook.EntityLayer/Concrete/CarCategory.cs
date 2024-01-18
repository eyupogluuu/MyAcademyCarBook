using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class CarCategory
    {
        public int carcategoryID { get; set; }
        public string carcategoryName { get; set; }
        public string descreption { get; set; }
        public bool cateStatus { get; set; }
        public List<Car> cars { get; set; }
    }
}
