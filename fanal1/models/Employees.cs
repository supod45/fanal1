using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace fanal1.models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string empId { get; set; }
        public string empName { get; set; }
        public string Email  { get; set; }
        public string phoneNumber { get; set; }
        public DateTime hireDate { get; set; }
        public string positionID  { get; set; }

    }
}
