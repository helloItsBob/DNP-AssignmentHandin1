using System.ComponentModel.DataAnnotations;

namespace Hand_in1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        [Range(18, int.MaxValue, ErrorMessage = "Please enter Age with a value bigger than or equal to {1}")]
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }
    }
}