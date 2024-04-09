using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain
{
    public class Department
    {
       [Key] public string? Designation { get; set; }
        public string? DeptId { get; set; }

    }
}
