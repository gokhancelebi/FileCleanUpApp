using FileCleanupApp.src;
using System;
using System.Collections.Generic;

var arguments = ParseArguments(args);


if (!arguments.ContainsKey("folder") || !arguments.ContainsKey("days"))
{
    Console.WriteLine("Usage:");
    Console.WriteLine("dotnet run -- --folder <FolderPath> --days <DayLimit>");
    Console.WriteLine(@"Example: dotnet run -- --folder ""C:\Temp\Logs"" --days 7");
    return;
}


string folderPath = arguments["folder"];
if (!int.TryParse(arguments["days"], out int dayLimit))
{
    Console.WriteLine($"Error: --days parameter should be numeric.");
}

if (!Directory.Exists(folderPath))
{
    Console.WriteLine($"Error: {folderPath} folder not found.");
}

var cleanFiles = new FileCleanupAppCommand(folderPath, dayLimit);

// 🔧 Bu fonksiyon en altta olmalı!
//    ve static olarak tanımlanmalı!
static Dictionary<string, string> ParseArguments(string[] args)
{
    var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    string? currentKey = null;

    foreach (var arg in args)
    {
        if (arg.StartsWith("--"))
        {
            currentKey = arg.TrimStart('-');
            dict[currentKey] = "true";
        }
        else if (currentKey != null)
        {
            dict[currentKey] = arg;
            currentKey = null;
        }
    }

    return dict;
}