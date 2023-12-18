using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace Theater.Models
{
	public class Hall
	{
		public int HallId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int Capacity { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int SizeScreen { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int SizeHall { get; set; }

		public List<Session> Sessions { get; set; }

		public List<Event> Events { get; set; }
	}
}