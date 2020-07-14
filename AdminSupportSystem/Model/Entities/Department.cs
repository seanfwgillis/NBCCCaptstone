﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Department
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string  Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime InvocationDate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
