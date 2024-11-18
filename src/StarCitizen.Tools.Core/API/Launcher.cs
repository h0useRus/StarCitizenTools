using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The Star Citizen launcher.
/// </summary>
public record Launcher : DirectoryObject
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
    public ExeFileObject Executable => new(Path.AddPathPart(ExecutableFileName));
}
