using Data.Models;

namespace Data
{
    public class Seeder
    {
        public static void SeedData(ApplicationDbContext context)
        {
            context.Rooms.AddRange(rooms);
            context.SaveChanges();
            context.Bookings.AddRange(bookings);
            context.SaveChanges();
        }

        private static List<Room> rooms = new()
        {
            new() 
            {
                Code = "C001",
                MaximumCapacity = 5,
            },
            new()
            {
                Code = "C002",
                MaximumCapacity = 2,
            },
            new()
            {
                Code = "C003",
                MaximumCapacity = 1,
            },
            new()
            {
                Code = "C004",
                MaximumCapacity = 3,
            },
            new()
            {
                Code = "C005",
                MaximumCapacity = 5,
            },new()
            {
                Code = "C006",
                MaximumCapacity = 8,
            },new()
            {
                Code = "C007",
                MaximumCapacity = 10,
            },
            new()
            {
                Code = "C008",
                MaximumCapacity = 2,
            },
            new()
            {
                Code = "C009",
                MaximumCapacity = 3,
            },
            new()
            {
                Code = "C010",
                MaximumCapacity = 1,
            }
        };

        private static List<Booking> bookings = new()
        {
            new()
            {
                Code = "",
                NumberOfPeople = 1,
                IsConfirmed = false,
                Room = rooms[0],
                StartDate = new DateTime(2024, 1, 15),
                EndDate = new DateTime(2024, 1, 18),
                IsDeleted = false,
            },
            new()
            {
                Code = "",
                NumberOfPeople = 5,
                IsConfirmed = false,
                Room = rooms[1],
                StartDate = new DateTime(2024, 1, 15),
                EndDate = new DateTime(2024, 1, 18),
                IsDeleted = false,
            },
            new()
            {
                Code = "",
                NumberOfPeople = 3,
                IsConfirmed = false,
                Room = rooms[0],
                StartDate = new DateTime(2024, 2, 15),
                EndDate = new DateTime(2024, 2, 18),
                IsDeleted = false,
            },
            new()
            {
                Code = "",
                NumberOfPeople = 8,
                IsConfirmed = false,
                Room = rooms[1],
                StartDate = new DateTime(2024, 1, 20),
                EndDate = new DateTime(2024, 1, 28),
                IsDeleted = false,
            },
        };
    }
}
