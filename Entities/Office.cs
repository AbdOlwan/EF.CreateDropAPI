﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.CreateDropAPI.Entities
{
    public class Office
    {
        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public string? OfficeLocation { get; set; }

       // public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; } 
    }
}
