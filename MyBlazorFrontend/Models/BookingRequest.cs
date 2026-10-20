using System.ComponentModel.DataAnnotations;

namespace MyBlazorFrontend.Models;

public class BookingRequest
{
    [Required, StringLength(100, MinimumLength = 2)]
    public string FullName { get; set; } = "";
    [Required, EmailAddress]
    public string Email { get; set; } = "";
    [Required]
    public DateTime? TravelDate { get; set; } = DateTime.Today.AddDays(7);
    [Range(1, 50)]
    public int Travelers { get; set; } = 1;
    [StringLength(500)]
    public string? Requests { get; set; }
}
