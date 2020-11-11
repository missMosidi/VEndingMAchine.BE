using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Api.Services.AuthModels
{
    public class AthenticationModel
    {
        [StringLength(100), Required]
        public string Username { get; set; }

        [StringLength(50), Required]
        public string Password { get; set; }

        [Required]
        public bool  RememberMe { get; set; }
    }
}
