﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_beauty.Models
{
    public class Warehouse
    {
        public string Locality { get; set; }
        public long Quantity { get; set; }
        public string Type { get; set; }
    }
}
