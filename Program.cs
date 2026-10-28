using ConsoleMusic.Services;
using ConsoleMusic.Helpers;

Console.WriteLine("Starting player...");
try
{
    while (true)
    {
        MusicPlayerServices musicPlayerServices = new MusicPlayerServices();
        string[] musicList = musicPlayerServices.getMusicList();

        musicPlayerServices.musicPlayer(musicList);
    }
}
catch (UnauthorizedAccessException)
{
    ConsoleHelper.ShowMessageAndWait("You do not have access to the music folder");

}
catch (DirectoryNotFoundException)
{
    ConsoleHelper.ShowMessageAndWait("The music folder does not exist");

}
catch (IOException ex)
{
    ConsoleHelper.ShowMessageAndWait($"An I/O error occurred: {ex.Message}");

}
catch (ArgumentException ex)
{
    ConsoleHelper.ShowMessageAndWait(ex.Message);

}