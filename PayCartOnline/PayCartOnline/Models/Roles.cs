﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PayCartOnline.Models
{
    public class Roles
    {   
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = null;
      

    }
}