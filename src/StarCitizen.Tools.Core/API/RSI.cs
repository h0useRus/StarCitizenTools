namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// Star Citizen API is the simple tool to access various local client APIs.
/// </summary>
public class RSI : DirectoryObject
{
    /// <summary>
    /// The game launcher.
    /// </summary>
    public Launcher Launcher { get; init; }
    /// <summary>
    /// Create instance of <see cref="RSI"/>.
    /// </summary>
    /// <param name="libraryPath">The root library path.</param>
    public RSI(string libraryPath) : base(libraryPath)
    {
        Launcher = GetLauncher();
    }
    /// <summary>
    /// Get Star Citizen launcher object.
    /// </summary>
    /// <param name="launcherFolderPath">Otional full folder path. If it is not defined, current <see cref="FileSystemObject.Path"/> and <see cref="Launcher.DefaultFolderName"/> will used for path generation.</param>
    /// <returns>The Star Citizen launcher object.</returns>
    public Launcher GetLauncher(string? launcherFolderPath = null)
        => new(this, CreatePath(launcherFolderPath ?? Launcher.DefaultFolderName));
}
