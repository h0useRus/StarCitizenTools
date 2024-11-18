namespace NSW.StarCitizen.Tools.API;

/// <summary>
/// Base object container for files and folders.
/// </summary>
public abstract record FileSystemObject(
    /// <summary>
    /// The file system object path.
    /// </summary>
    string Path)
{
    /// <summary>
    /// Return that <see cref="Path"/> is actual.
    /// </summary>
    public bool IsPathValid => !string.IsNullOrWhiteSpace(Path) && System.IO.Path.Exists(Path);
}
