namespace Pinguin.Maui.Models;

public class EditPingerModel
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public int? IntervalMinutes { get; set; }
}
