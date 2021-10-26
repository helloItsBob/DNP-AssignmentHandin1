using System.ComponentModel.DataAnnotations;

namespace Web_Service.Models
{
    public class Job
    {
        [MaxLength(60)]
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}