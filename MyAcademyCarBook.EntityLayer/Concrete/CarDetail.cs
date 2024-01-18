using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class CarDetail
    {
        public int carDetailID { get; set; }
        public string descreption { get; set; }
        public int carID { get; set; }
        public Car car { get; set; }
        public int AppUserID { get; set; }
        public AppUser appuser { get; set; }
        public DateTime createdDate { get; set; }

    }
}
