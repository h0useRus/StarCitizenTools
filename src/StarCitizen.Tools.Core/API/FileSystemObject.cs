namespace NSW.StarCitizen.Tools.API;

/// <summary>
/// Base object container for files and folders.
/// </summary>
public abstract class FileSystemObject
{
    /// <summary>
    /// The file system object path.
    /// </summary>
    public string Path { get; init; }
    /// <summary>
    /// Return that <see cref="Path"/> is actual.
    /// </summary>
    public abstract bool IsPathValid { get; }
    /// <summary>
    /// Create new instance.
    /// </summary>
    /// <param name="path">The file system path.</param>
    protected FileSystemObject(string path)
    {
        Path = path;
    }
    /// <summary>
    /// Create new path based on <see cref="Path"/>.
    /// </summary>
    /// <param name="paths">Array of paths</param>
    /// <returns>New path inside <see cref="Path"/>.</returns>
    public string CreatePath(params string[] paths)
    {
        var newPaths = new string[paths.Length + 1];
        newPaths[0] = Path;
        Array.Copy(paths, 0, newPaths, 1, paths.Length);
        return System.IO.Path.Combine(newPaths);
    }
}
