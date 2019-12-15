using PerfectOnion.Core.Common.Entities;

namespace PerfectOnion.Core.PerfectOnion.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}