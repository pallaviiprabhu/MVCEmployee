using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEmployee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public uint EmployeeId { get; set; }

        public uint ContactNo { get; set; }

        
        public int Age { get; set; }
        public string? Department { get; set; }

        [Display(Name = "Join Date")]
        
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
    }
}
