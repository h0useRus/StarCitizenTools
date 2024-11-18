namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The Star Citizen launcher.
/// </summary>
public record Launcher : FileSystemEntity
{
    internal Launcher(string rootPath) : base(rootPath)
    {
    }
    /// <summary>
    /// The default launcher folder name.
    /// </summary>
    public const string DefaultFolderName = "RSI Launcher";
    /// <summary>
    /// The executive file name
    /// </summary>
    public const string ExecutableFileName = "RSI Launcher.exe";

    /// <summary>
    /// The launcher executable file.
    /// </summary>
    public ExeFile Executable => new(Path.Combine(EntityPath, ExecutableFileName));
}
