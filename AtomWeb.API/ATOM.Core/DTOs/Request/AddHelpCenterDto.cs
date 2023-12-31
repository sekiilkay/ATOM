﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.DTOs.Request
{
    public class AddHelpCenterDto
    {
        public string Name { get; set; }

        [Column(TypeName = "decimal(8,6)")]
        public decimal Longitude { get; set; }   

        [Column(TypeName = "decimal(8,6)")]
        public decimal Latitude { get; set; } 

        public int? CenterTypeId { get; set; }
    }
}
