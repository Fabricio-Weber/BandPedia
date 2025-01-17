namespace BandPedia;

public class Podcast
{
    public string Name { get; }
    public string Host { get;  }
    private List<Episode> totalEpisodes = new List<Episode>();

    public Podcast (string podcastName, string hostName)
    {
        Name = podcastName;
        Host = hostName;
    }

    public void AddEpisode(Episode episode)
    {
        totalEpisodes.Add(episode);
    }

    public void showInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Host: " + Host);
        Console.WriteLine("Total Episodes: " + totalEpisodes.Count);

    }
}