using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Car
    {
        public int carID { get; set; }
        public string model { get; set; }
        public int carcategoryID { get; set; }
        public CarCategory carCategory { get; set; }
        public int brandID { get; set; }
        public Brand brand { get; set; }
        public string imageUrl { get; set; }
        public string gearType { get; set; }
        public int KM { get; set; }
        public byte personCount { get; set; }
        public int  year { get; set; }
        public bool cstatus { get; set; }
        public int carStatusID { get; set; }
        public CarStatus carStatus { get; set; }
        public List<Price> prices { get; set; }
        public List<Comment> comments { get; set; }
     
    }
}
