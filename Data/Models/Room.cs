﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int MaximumCapacity { get; set; }
        public ICollection<Booking> Bookings { get; } = new List<Booking>();
    }
}
