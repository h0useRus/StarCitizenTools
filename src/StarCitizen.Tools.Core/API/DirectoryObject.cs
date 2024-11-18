namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The folder object
/// </summary>
public record DirectoryObject : FileSystemObject
{
    /// <inheritdoc />
    public DirectoryObject(string path) : base(path)
    {
    }
}
