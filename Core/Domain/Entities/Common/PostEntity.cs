using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class PostEntity
    {
        public Guid Id { get; set; }
        public DateTime PostCreated { get; set; }
        public User User { get; set; }

    }
}
