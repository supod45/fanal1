using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace fanal1.models
{
    public class Positions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public string positionId  { get; set; }
        public string positionName { get; set; }
        public float baseSalary { get; set; }
        public float salaryIncreaseRate { get; set; }


    }
}
