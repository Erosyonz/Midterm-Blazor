using System.Collections.Generic;

namespace MyBlazorFrontend.Models;

public class Destination
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Country { get; set; } = "Philippines";
    public string Region { get; set; } = "Cordova, Cebu";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public decimal StartingPrice { get; set; }
    public double Rating { get; set; }
    public string Duration { get; set; } = "";
    public string Category { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
    public string TravelTips { get; set; } = "";
}
