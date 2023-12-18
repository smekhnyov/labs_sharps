using Theater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection.Emit;

namespace Theater.DAL
{
	public class TheaterContext : DbContext
	{
		public TheaterContext() : base("TheaterContext")
		{
		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
		public DbSet<Event> Events { get; set; }
		public DbSet<Seat> Seats { get; set; }
		public DbSet<Session> Sessions { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Hall> Halls { get; set; }

		protected override void OnModelCreating(DbModelBuilder optionsBuilder)
		{
			optionsBuilder.Entity<Session>()
				.HasMany(s => s.Tickets)
				.WithRequired(t => t.Session)
				.WillCascadeOnDelete(true);

			optionsBuilder.Entity<Seat>()
				.HasMany(e => e.Tickets)
				.WithRequired(s => s.Seat)
				.WillCascadeOnDelete(true);

			optionsBuilder.Entity<Event>()
				.HasMany(e => e.Sessions)
				.WithRequired(s => s.Event)
				.WillCascadeOnDelete(true);

			optionsBuilder.Entity<Hall>()
				.HasMany(e => e.Sessions)
				.WithRequired(s => s.Hall)
				.WillCascadeOnDelete(true);

			optionsBuilder.Entity<Employee>()
				.HasRequired(e => e.EmployeeDetails)
				.WithRequiredPrincipal(e => e.Employee)
				.WillCascadeOnDelete(true);

			optionsBuilder.Entity<Event>()
				.HasMany(e => e.Halls)
				.WithMany(h => h.Events)
				.Map(m =>
				{
					m.ToTable("EventHall");
					m.MapLeftKey("EventId");
					m.MapRightKey("HallId");
				});

			// Configure your database connection here
			optionsBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}