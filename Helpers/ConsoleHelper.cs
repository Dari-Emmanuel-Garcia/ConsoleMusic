using System;
using NAudio.Sequencing;

namespace ConsoleMusic.Helpers;

public static class ConsoleHelper
{
    public static void ShowMessageAndWait(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
