﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int NumberOfPeople { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;
    }
}
