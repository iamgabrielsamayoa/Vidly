﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class customer
    {
        //[] == Non nullable,varchar etc USUALLY SQL TABLE CREATION PROPERTIES
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String  Name { get; set; }
        public bool IsSuscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthdate { get; set; }

    }
}