﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATOM.Core.Entities
{
    public abstract class BaseCenter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Longitude { get; set; }        //boylam
        public float Latitude { get; set; }         //enlem
        
        public int? CenterTypeId { get; set; }
        public CenterType CenterType { get; set; }
    }
}