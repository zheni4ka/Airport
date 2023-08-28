using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Airport
{
    public class AirportDbContext : DbContext
    {
        public AirportDbContext() : base() 
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirportDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true";
            
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sex>().HasData(new[]
            {
                new Sex() { Id = 1, Name = "Male" },
                new Sex() { Id = 2, Name = "Female" }
            });
            modelBuilder.Entity<Account>().HasData(new[]
            {
                new Account() { Id = 1, Login = "firstTime", Password = "myfirsttime"},
                new Account() { Id = 2, Login = "favAirline", Password = "rasha-parasha" }
            });
            modelBuilder.Entity<Plane>().HasData(new[]
            {
                new Plane() { Id = 1, CountryId = 1, PlaneTypeId = 1, Name = "CJ2", MaxPassengersCount = 8},
                new Plane() { Id = 2, CountryId = 2, PlaneTypeId = 2, Name = "A380", MaxPassengersCount = 545},
            });
            modelBuilder.Entity<Client>().HasData(new[]
            {
                new Client() { Id = 1, Name = "Artem", Surname = "Guda", SexId = 1, Email ="guda@gmail.com", AccountId = 1 },
                new Client() { Id = 2, Name = "Viktor", Surname = "Viktor", SexId = 1, Email = "viktor@gmail.com", AccountId = 2 }
            });
            modelBuilder.Entity<Flights>().HasData(new[]
            {
                new Flights() { Id = 1, Number = 1, PlaneId = 1, DepartueDate = new DateOnly(2018,02,20), ArrivalDate = new DateOnly(2018,02,21), DeparturePlaceId = 1, ArrivalPlaceId = 3 },
                new Flights() { Id = 2, Number = 2, PlaneId = 2, DepartueDate = new DateOnly(2020, 10, 12), ArrivalDate = new DateOnly(2020,10,13), DeparturePlaceId = 2, ArrivalPlaceId = 4 }
            });
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Poland"}
            });
            modelBuilder.Entity<PlaneType>().HasData(new[]
            {
                new PlaneType() { Id = 1, Name = "Jet"},
                new PlaneType() { Id = 2, Name = "Airbus"}
            });
            modelBuilder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "San Diego"},
                new City() { Id = 2, Name = "Los Angeles"},
                new City() { Id = 3, Name = "London"},
                new City() { Id = 4, Name = "Berlin"}
            });

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flights> Flights { get; set; }    
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<PlaneType> PlaneTypes { get; set; }
    }
}
