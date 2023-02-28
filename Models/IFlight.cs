﻿using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class IFlight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; } = null!;
        public DateTime FlightDate { get; set; }
        public TimeSpan FlightTime { get; set; }
        public string Origin { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public int AvailableSeats { get; set; }
        public int FlightPrice { get; set; }
    }
}
