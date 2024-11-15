namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The folder object
/// </summary>
public class DirectoryObject : FileSystemObject
{
    /// <inheritdoc />
    public override bool IsPathValid => Directory.Exists(Path);
    /// <inheritdoc />
    public DirectoryObject(string path) : base(path)
    {
    }
}
