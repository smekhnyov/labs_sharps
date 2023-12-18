using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace Theater.Models
{
	public class Employee
	{
		[Key, ForeignKey("EmployeeDetails")]
		public int EmployeeId { get; set; }

		[Required, MinLength(2), MaxLength(20)]
		public string FirstName { get; set; }

		[Required, MinLength(2), MaxLength(20)]
		public string LastName { get; set; }

		public virtual EmployeeDetails EmployeeDetails { get; set; }
	}
}