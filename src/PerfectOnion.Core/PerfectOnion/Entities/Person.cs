using PerfectOnion.Core.Common.Entities;
using PerfectOnion.Core.Common.Enums;

namespace PerfectOnion.Core.PerfectOnion.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }
}