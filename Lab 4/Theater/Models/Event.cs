using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace Theater.Models
{
	public enum Type
	{
		opera, ballet
	}
	public class Event
	{
		public int EventId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }

		[Required]
		public Type? Type { get; set; } // 'opera' or 'ballet'

		[Required]
		public TimeSpan Duration { get; set; }

		[ForeignKey("EventId")]
		public List<Session> Sessions { get; set; }
	}
}