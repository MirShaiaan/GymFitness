using System.ComponentModel.DataAnnotations;

namespace GymFitness.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public int Age { get; set; }
        public string? Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}