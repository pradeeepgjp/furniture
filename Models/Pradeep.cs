using System.ComponentModel.DataAnnotations;

namespace furniture.Models
{
    public class Pradeep
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CreatePassword { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
