using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace Theater.Models
{
	public class Ticket
	{
		public int TicketId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int SessionId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int Cost { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int SeatId { get; set; }

		[ForeignKey("SessionId")]
		public Session Session { get; set; }

		[ForeignKey("SeatId")]
		public Seat Seat { get; set; }
	}
}