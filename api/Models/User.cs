using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Registration
    {
        public int Id { get; set; }
        [Required]
        [Length(3, 20)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [Length(5, 30)]
        public string Password { get; set; } = string.Empty;
    }

    public class Login
    {
        [Required]
        [Length(3, 20)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [Length(5, 30)]
        public string Password { get; set; } = string.Empty;
    }
}