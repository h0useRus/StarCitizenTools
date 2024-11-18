namespace NSW.StarCitizen.Tools.API;

/// <summary>
/// Base file system entity
/// </summary>
/// <param name="EntityPath">Tha entity path.</param>
public abstract record FileSystemEntity(string EntityPath)
{
    /// <summary>
    /// Return that <see cref="Path"/> is actual.
    /// </summary>
    public bool IsPathValid => !string.IsNullOrWhiteSpace(EntityPath) && Path.Exists(EntityPath);
}
