using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Service.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(60)]
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}