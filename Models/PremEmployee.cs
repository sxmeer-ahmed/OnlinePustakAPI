﻿using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class PremEmployee
    {
        public PremEmployee()
        {
            InverseManager = new HashSet<PremEmployee>();
            PremAttendanceEmps = new HashSet<PremAttendance>();
            PremAttendanceManagers = new HashSet<PremAttendance>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public DateTime? Doj { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? ManagerId { get; set; }

        public virtual PremEmployee? Manager { get; set; }
        public virtual ICollection<PremEmployee> InverseManager { get; set; }
        public virtual ICollection<PremAttendance> PremAttendanceEmps { get; set; }
        public virtual ICollection<PremAttendance> PremAttendanceManagers { get; set; }
    }
}
