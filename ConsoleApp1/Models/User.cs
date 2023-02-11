using ConsoleApp1.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Models
{
    public class User
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [ValidEmail]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
