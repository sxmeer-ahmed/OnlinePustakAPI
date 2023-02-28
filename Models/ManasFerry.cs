﻿using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class ManasFerry
    {
        public ManasFerry()
        {
            ManasTickets = new HashSet<ManasTicket>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RoomsLeft { get; set; }
        public double Charge { get; set; }
        public string? Image { get; set; }
        public DateTime Departure { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }

        public virtual ManasPort Destination { get; set; } = null!;
        public virtual ManasPort Origin { get; set; } = null!;
        public virtual ICollection<ManasTicket> ManasTickets { get; set; }
    }
}
