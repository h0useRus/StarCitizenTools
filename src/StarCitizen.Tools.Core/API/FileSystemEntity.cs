namespace NSW.StarCitizen.Tools.API;

/// <summary>
/// Base object container for files and folders.
/// </summary>
public abstract record FileSystemEntity(
    /// <summary>
    /// The file system object path.
    /// </summary>
    string EntityPath)
{
    /// <summary>
    /// Return that <see cref="Path"/> is actual.
    /// </summary>
    public bool IsPathValid => !string.IsNullOrWhiteSpace(EntityPath) && Path.Exists(EntityPath);
}
