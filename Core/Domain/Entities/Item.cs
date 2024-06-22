﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item:PostEntity
    {
        public required string ItemName { get; set; }
        public decimal Price { get; set; }
    }
}
