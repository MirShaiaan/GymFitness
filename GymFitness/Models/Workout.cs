using System.ComponentModel.DataAnnotations;

namespace GymFitness.Models
{
    public class Workout
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }


        [Required]
        public string? Category { get; set; }
        [Required]
        public int DurationMinutes { get; set; }
        [Required]
        public int CaloriesBurned { get; set; }
        [Required]
        public DateTime Date { get; set; }

        // Foreign Key
        [Required]
        public string UserId { get; set; }

        // Navigation Property
        [Required]
        public User User { get; set; }
    }
}