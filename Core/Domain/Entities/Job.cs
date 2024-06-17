using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Job:PostEntity
    {
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public bool IsMoreThan20 { get; set; }
        public bool IsCashInHand { get; set; }
    }
}
