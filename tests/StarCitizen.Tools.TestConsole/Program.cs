using NSW.StarCitizen.Tools.API;

Console.Write("Enter Star Citizen root path: ");
var path = Console.ReadLine();
if (string.IsNullOrEmpty(path))
    return;

var rsi = new RSI(path);

Console.WriteLine($"RSI path {rsi.Path} is valid {rsi.IsPathValid}");
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine($"Launcher path {rsi.Launcher.Path} is valid {rsi.Launcher.IsPathValid}");
if (rsi.Launcher.Executable.IsPathValid)
    Console.WriteLine($"Launcher exe {rsi.Launcher.Executable.Path} version {rsi.Launcher.Executable.Version?.ProductVersion}");
foreach (var client in rsi.GetInstalledClients())
{
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine($"Found {client.Mode} client");
    Console.WriteLine($"Path {client.Path} is valid {client.IsPathValid}");
    Console.WriteLine($"Exe {client.Executable.Path} version {client.Executable.Version?.ProductVersion}");
    Console.WriteLine(client.Manifest);
}
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine(rsi.AppData.Path);
Console.WriteLine(rsi.AppData.IsPathValid);

//Console.WriteLine($"Exit code: {rsi.Launcher.Executable.Run()}");

Console.ReadLine();
