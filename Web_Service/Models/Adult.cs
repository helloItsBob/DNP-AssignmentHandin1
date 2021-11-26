using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Service.Models
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }
    }
}