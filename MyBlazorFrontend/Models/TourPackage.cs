namespace MyBlazorFrontend.Models;

public class TourPackage
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int DestinationId { get; set; }
    public string DestinationName { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public int DurationDays { get; set; }
    public decimal PricePerPerson { get; set; }
    public List<string> IncludedServices { get; set; } = new();
    public List<string> ExcludedServices { get; set; } = new();
    public List<string> ItineraryHighlights { get; set; } = new();
    public string Category { get; set; } = "";
}
