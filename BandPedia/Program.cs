using BandPedia;
Main();
return;

void Main()
{
    // Music music1 = new Music("East Hastings", "Godspeed You! Black Emperor", "F#A#", "Post Rock", 1020, true); 
    // Console.WriteLine($"{music1.Description}");
    Band deftones = new Band("Deftones");
    Album whitePony = new Album("White Pony");

    Music music1 = new Music(deftones,"Digital Bath" );
    music1.Runtime = 240;
    music1.Available = true;
    
    Music music2 = new Music(deftones,"Pink Maggit" )
    {
        Runtime = 240,
        Available = true
    };


    

    deftones.AddAlbum(whitePony);
    deftones.ShowDiscography();
    music1.ShowInfo();
    music2.ShowInfo();
    
    Podcast podTest = new Podcast("Pod Test", "Host Test");
    Episode episodeTest = new Episode("Pod Test", podTest);
    podTest.AddEpisode(episodeTest);
    podTest.showInfo();
    
    


}