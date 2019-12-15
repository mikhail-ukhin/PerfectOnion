using System;
using System.Collections.Generic;
using PerfectOnion.Core.Common.Entities;

namespace PerfectOnion.Core.PerfectOnion.Entities
{
    public class Order : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public string Number { get; set; }       
        public int? EmployeeId { get; set; }
        public int CustomerId { get; set; }
        
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderPosition> Positions { get; set; }
    }
}