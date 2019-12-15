namespace PerfectOnion.Core.PerfectOnion.Entities
{
    public class Employee : Person
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
}