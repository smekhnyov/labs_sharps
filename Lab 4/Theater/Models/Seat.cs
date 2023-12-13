using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace Theater.Models
{
	public class Seat
	{
		public int SeatId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int Number { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int Row { get; set; }

		public List<Ticket> Tickets { get; set; }
	}
}