using PerfectOnion.Core.Common.Entities;

namespace PerfectOnion.Core.PerfectOnion.Entities
{
    public class OrderPosition : BaseEntity
    {
        public float Amount { get; set; }
        public string Measure { get; set; }
        
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}