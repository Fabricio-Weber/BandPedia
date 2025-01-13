using BandPedia;
Main();
return;

void Main()
{
    // Music music1 = new Music("East Hastings", "Godspeed You! Black Emperor", "F#A#", "Post Rock", 1020, true); 
    // Console.WriteLine($"{music1.Description}");
    Band deftones = new Band("Deftones");
    deftones.Name = "Deftones";
    
    Album whitePony = new Album();
    whitePony.Name = "White Pony";
    
    Music music1 = new Music(deftones);
    music1.Name = "Digital Bath";

    music1.Runtime = 240;
    
    Music music2 = new Music(deftones);
    music2.Name = "Pink Maggit";

    music2.Runtime = 360;

    whitePony.AddMusic(music1);
    whitePony.AddMusic(music2);
    

    deftones.AddAlbum(whitePony);
    deftones.ShowDiscography();


}