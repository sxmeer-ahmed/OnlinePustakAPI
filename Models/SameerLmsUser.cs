using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class SameerLmsUser
    {
        public SameerLmsUser()
        {
            SameerLmsBookings = new HashSet<SameerLmsBooking>();
        }

        public string UserId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserContact { get; set; } = null!;
        public string UserEmail { get; set; } = null!;

        public virtual ICollection<SameerLmsBooking> SameerLmsBookings { get; set; }
    }
}
