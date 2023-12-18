using Theater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Type = Theater.Models.Type;

namespace Theater.DAL
{
	public class TheaterInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TheaterContext>
	{
		protected override void Seed(TheaterContext context)
		{
			var events = new List<Event>
			{
				new Event { Name = "Opera Night", Type = Type.opera, Duration = TimeSpan.FromHours(2) },
				new Event { Name = "Ballet Gala", Type = Type.ballet, Duration = TimeSpan.FromHours(1.5) },
            };

			events.ForEach(s => context.Events.Add(s));
			context.SaveChanges();

			var halls = new List<Hall>
			{
				new Hall { Capacity = 500, SizeScreen = 100, SizeHall = 500 },
				new Hall { Capacity = 700, SizeScreen = 150, SizeHall = 750 },
            };

			halls.ForEach(s => context.Halls.Add(s));
			context.SaveChanges();

			var seats = new List<Seat>
			{
				new Seat { Number = 75, Row = 3 },
				new Seat { Number = 75, Row = 3 },
            };

			seats.ForEach(s => context.Seats.Add(s));
			context.SaveChanges();

			var sessions = new List<Session>
			{
				new Session { Start = new DateTime(2023, 12, 15, 19, 00, 00), End = new DateTime(2023, 12, 15, 22, 30, 00), EventId = 2, HallId = 2 },
				new Session { Start = new DateTime(2023, 12, 22, 19, 00, 00), End = new DateTime(2023, 12, 22, 21, 45, 00), EventId = 1, HallId = 2 },
            };

			sessions.ForEach(s => context.Sessions.Add(s));
			context.SaveChanges();

			var tickets = new List<Ticket>
			{
				new Ticket { SessionId = 1, Cost = 1954, SeatId = 1 },
				new Ticket { SessionId = 2, Cost = 2000, SeatId = 2 },
            };

			tickets.ForEach(s => context.Tickets.Add(s));
			context.SaveChanges();

			var employees = new List<Employee>
			{
				new Employee { FirstName = "John", LastName = "Doe",
					EmployeeDetails = new EmployeeDetails { Address = "Voronezh", PhoneNumber = "+7 (222) 222-22-22", Birthday = new DateTime(2003, 9, 10)} },
				new Employee { FirstName = "Jane", LastName = "Smith",
					EmployeeDetails = new EmployeeDetails { Address = "Moscow", PhoneNumber = "+7 (111) 111-11-11", Birthday = new DateTime(2002, 12, 22) } },
			};

			employees.ForEach(s => context.Employees.Add(s));
			context.SaveChanges();
		}
	}
}