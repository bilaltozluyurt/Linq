﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqpractices.Entities
{
    internal class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int ClassId { get; set; }

    }
}
