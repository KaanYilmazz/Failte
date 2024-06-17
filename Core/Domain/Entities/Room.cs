using Domain.Entities.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Room : PostEntity
    {
        public bool IsPermenant { get; set; }
        public int TotalRoom { get; set; }
        public int TotalPeople { get; set; }
        public DateTime AvailableFrom { get; set; }
        public RoomType RoomType { get; set; }
        public BedType BedType { get; set; }
        public decimal Price { get; set; }
        public bool Heater { get; set; }
        public int AvailableFor { get; set; }
        public ICollection<Furniture> Furnitures { get; set; }
    }
}
