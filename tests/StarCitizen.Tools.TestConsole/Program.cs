using NSW.StarCitizen.Tools.API;

Console.Write("Enter Star Citizen root path: ");
var path = Console.ReadLine();
if (string.IsNullOrEmpty(path))
    return;

var rsi = new RSI(path);

Console.WriteLine($"RSI path {rsi.EntityPath} is valid {rsi.IsPathValid}");
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine($"Launcher path {rsi.Launcher.EntityPath} is valid {rsi.Launcher.IsPathValid}");
if (rsi.Launcher.Executable.IsPathValid)
    Console.WriteLine($"Launcher exe {rsi.Launcher.Executable.EntityPath} version {rsi.Launcher.Executable.Version?.ProductVersion}");
foreach (var client in rsi.GetInstalledClients())
{
    Console.WriteLine("---------------------------------------------------------------------");
    Console.WriteLine($"Found {client.Mode} client");
    Console.WriteLine($"Path {client.EntityPath} is valid {client.IsPathValid}");
    Console.WriteLine($"Exe {client.Executable.EntityPath} version {client.Executable.Version?.ProductVersion}");
    Console.WriteLine(client.Manifest);
}
Console.WriteLine("---------------------------------------------------------------------");
Console.WriteLine(rsi.AppData.EntityPath);
Console.WriteLine(rsi.AppData.IsPathValid);

foreach (var folder in rsi.AppData.GetGameFolders())
{
    Console.WriteLine(folder);
    Console.WriteLine(folder.GetGraphicsSettings()?.GraphicsRenderer);
}

Console.ReadLine();
