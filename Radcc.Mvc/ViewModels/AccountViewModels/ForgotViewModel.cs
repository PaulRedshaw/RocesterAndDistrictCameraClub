using System.ComponentModel.DataAnnotations;

namespace Radcc.Mvc.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}