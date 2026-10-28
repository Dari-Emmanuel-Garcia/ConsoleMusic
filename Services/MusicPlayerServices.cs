using NAudio.Wave;
using ConsoleMusic.Helpers;


namespace ConsoleMusic.Services;

public class MusicPlayerServices
{
    public string[] getMusicList()
    {
        string musicFolderPath = Path.Combine(AppContext.BaseDirectory, "music");
        Directory.CreateDirectory(musicFolderPath);
        string[] musicList = Directory.GetFiles(musicFolderPath, "*.mp3");

        if (musicList.Length == 0)
        {
            throw new ArgumentException("No music found to play");
        }

        Random.Shared.Shuffle(musicList);

        return musicList;
    }

    public void musicPlayer(string[] musicList)
    {
        foreach (string music in musicList)
        {
            using var audioFile = new AudioFileReader(music);
            using var player = new WasapiPlayerBuilder().Build();

            player.Init(audioFile);
            player.Volume = 1f;
            player.Play();

            while (player.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(100);
            }

            Thread.Sleep(1000);
        }
    }
}
