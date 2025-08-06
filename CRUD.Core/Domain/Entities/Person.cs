﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        [Key]
        public Guid PersonID { get; set; }
        public string? PersonName { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }     
        public string? Address { get; set; }
        public bool ReceiveNewsLetters { get; set; }

        public Guid? CountryID { get; set; }

        [ForeignKey("CountryID")]
        public Country? Country { get; set; }

    }
}
