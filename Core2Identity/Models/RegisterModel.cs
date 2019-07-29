using System.ComponentModel.DataAnnotations;

namespace Core2Identity.Models
{
    public class RegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
