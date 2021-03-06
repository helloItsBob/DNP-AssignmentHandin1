using System.ComponentModel.DataAnnotations;

namespace Web_Service.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }

        public string Domain { get; set; }
        public int BirthYear { get; set; }
        public string Role { get; set; }
        public int SecurityLevel { get; set; }
    }
}