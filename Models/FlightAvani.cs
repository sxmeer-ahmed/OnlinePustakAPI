using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class FlightAvani
    {
        public FlightAvani()
        {
            FlightbookingAvanis = new HashSet<FlightbookingAvani>();
        }

        public int FlightNo { get; set; }
        public DateTime? Departure { get; set; }
        public string? LeaveFrom { get; set; }
        public string? AirlinesName { get; set; }
        public int? Price { get; set; }
        public int? SeatsA { get; set; }

        public virtual ICollection<FlightbookingAvani> FlightbookingAvanis { get; set; }
    }
}
