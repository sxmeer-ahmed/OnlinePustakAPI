﻿using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class EmpPrem
    {
        public int Eid { get; set; }
        public string? Ename { get; set; }
        public int? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string? City { get; set; }
    }
}
