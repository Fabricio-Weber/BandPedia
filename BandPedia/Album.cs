namespace BandPedia;

public class Album
{
    private List<Music> musics = new List<Music>();
    public string Name { get; set; }
    public int Runtime => musics.Sum(m => m.Runtime);
    public void AddMusic(Music music)
    {
        musics.Add(music);
    }
    public void ShowMusics()
    {
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }

        Console.WriteLine($"Total album runtime: {Runtime / 60}");
    }
}