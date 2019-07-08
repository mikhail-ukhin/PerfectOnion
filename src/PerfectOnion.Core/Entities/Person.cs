using PerfectOnion.Core.Enums;

namespace PerfectOnion.Core.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
    }
}