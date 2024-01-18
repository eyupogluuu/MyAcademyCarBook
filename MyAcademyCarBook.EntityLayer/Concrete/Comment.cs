using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
	public class Comment
	{
        public int commentID { get; set; }
        public string nameSurname { get; set; }
        public string descreption { get; set; }
        public DateTime commentDate { get; set; }
        public int carID { get; set; }
        public Car car { get; set; }
    }
}
