﻿using System;
using System.Collections.Generic;

namespace OnlinePustak.Models
{
    public partial class Bookhritik
    {
        public int Bookid { get; set; }
        public int? Authorid { get; set; }
        public string? Title { get; set; }
        public DateTime? Year { get; set; }
        public int? Price { get; set; }
        public string? Genre { get; set; }
        public string? Img { get; set; }
        public string? Synopsis { get; set; }

        public virtual Authorhritik? Author { get; set; }
    }
}
