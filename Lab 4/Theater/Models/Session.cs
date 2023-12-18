using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Theater.Models
{
	public class Session
	{
		public int SessionId { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime Start { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime End { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int EventId { get; set; }

		[Required, Range(1, int.MaxValue)]
		public int HallId { get; set; }

		[ForeignKey("EventId")]
		public Event Event { get; set; }

		[ForeignKey("HallId")]
		public Hall Hall { get; set; }

		public List<Ticket> Tickets { get; set; }
	}
}