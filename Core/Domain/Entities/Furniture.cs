﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Furniture:BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
