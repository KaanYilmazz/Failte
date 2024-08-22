using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class PostEntity:BaseEntity
    {
        public DateTime PostCreated { get; set; }
        public required User User { get; set; }
        public string Location { get; set; }
        public required string Title { get; set; }
        public string Content { get; set; }


    }
}
