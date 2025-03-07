using System.ComponentModel.DataAnnotations;

namespace TarakanSIMRS.Models.Home
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
