using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "You must supply a password of between 6 and 16 characters")]
        public string Password { get; set; }

    }
}