using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Domain
{
    public class Employee
    {
        [Key] public string? Name { get; set; }
        public string? Designation { get; set; }
        [ForeignKey("Designation")]

        public double Salary { get; set; }

    }
}
