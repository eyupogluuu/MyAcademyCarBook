using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class CarStatus
    {
        public int carStatusID { get; set; }
        public string carStatus { get; set; }
        public List<Car> cars { get; set; }
    }
}
