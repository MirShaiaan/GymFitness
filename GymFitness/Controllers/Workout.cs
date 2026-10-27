using GymFitness.Models;
using System.ComponentModel.DataAnnotations;
public class Workout
{
    public int Id { get; set; }

    [Required]
    public string ExerciseName { get; set; }

    public string Category { get; set; }

    public int DurationMinutes { get; set; }

    public int CaloriesBurned { get; set; }

    public DateTime Date { get; set; }

    // Foreign Key
    public string UserId { get; set; }

    // Navigation Property
    public User User { get; set; }
}

