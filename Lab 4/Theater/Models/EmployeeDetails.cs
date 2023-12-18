using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Theater.Models
{
	public class EmployeeDetails
	{
		[Key]
		public int EmployeeDetailsId { get; set; }

		[Required, MinLength(2), MaxLength(20)]
		public string Address { get; set; }

		[Required, MinLength(2), MaxLength(20)]
		public string PhoneNumber { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime Birthday { get; set; }

		public virtual Employee Employee { get; set; }
	}
}