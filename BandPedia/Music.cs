namespace BandPedia;

public class Music
{
    public string Name{get;  set;}
    public Band Artist { get;  }
    public string Album {get;  set;}
    public string Genre { get;  set; }
    public int Runtime { get;  set; }
    public bool Available { get;  set; }
    
    public Genre Genre1 { get;  set; }
    
    public string Description => $"{Name} - {Artist} - {Album}";

    public Music(Band band)
    {
        Artist = band;
    }

  
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Album: {Album}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Runtime: {Runtime}");
        Console.WriteLine($"Available: {Available}");
    }
}