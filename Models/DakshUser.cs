using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class DakshUser
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Userpassword { get; set; } = null!;
    }
}
