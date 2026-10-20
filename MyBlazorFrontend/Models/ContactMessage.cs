using System.ComponentModel.DataAnnotations;

namespace MyBlazorFrontend.Models;

public class ContactMessage
{
    [Required, StringLength(100, MinimumLength = 2, ErrorMessage = "Enter your full name.")]
    public string Name { get; set; } = "";
    [Required, EmailAddress]
    public string Email { get; set; } = "";
    public string? Phone { get; set; }
    public string Destination { get; set; } = "";
    public DateTime? PreferredDate { get; set; }
    [Range(1, 50, ErrorMessage = "Please select 1 to 50 travelers.")]
    public int Travelers { get; set; } = 1;
    public string Budget { get; set; } = "Not sure yet";
    public string InquiryType { get; set; } = "General Inquiry";
    [Required, StringLength(1200, MinimumLength = 10, ErrorMessage = "Please enter at least 10 characters.")]
    public string Message { get; set; } = "";
}
