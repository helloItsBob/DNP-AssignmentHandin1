using System.ComponentModel.DataAnnotations;

namespace Hand_in1.Models
{
    public class Job
    {
        [MaxLength(60)]
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}