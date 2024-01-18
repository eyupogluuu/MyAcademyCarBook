using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int testimonialID { get; set; }
        public string imageUrl { get; set; }
        public string title { get; set; }
        public string nameSurname { get; set; }
        public string descreption { get; set; }
    }
}
