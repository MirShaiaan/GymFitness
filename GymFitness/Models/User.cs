using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace GymFitness.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }


        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

    }
}
