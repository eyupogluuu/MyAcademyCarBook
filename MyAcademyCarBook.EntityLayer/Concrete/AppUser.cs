using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.EntityLayer.Concrete
{
	public class AppUser:IdentityUser<int>
	{
		public string? name {  get; set; }
		public string? surname {  get; set; }
		public string? city {  get; set; }
		public string? imageUrl {  get; set; }
		public List<CarDetail> carDetails { get; set; }
	}
}
