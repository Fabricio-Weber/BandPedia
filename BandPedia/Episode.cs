namespace BandPedia;

public class Episode
{
    public Podcast Podcast { get; set; }
    public int Runtime { get; set; }
    public string Summary { get; set; }
    public string Title { get;}
    public string Guest { get; set; }

    public Episode(string title, Podcast podcast)
    {
        Podcast = podcast;
        Title = title;
    }

    public void addGuest(string guest)
    {
        Guest = guest;
    }
    
}