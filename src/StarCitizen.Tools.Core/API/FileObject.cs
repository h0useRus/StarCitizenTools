namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The file object
/// </summary>
public abstract class FileObject : FileSystemObject
{
    /// <inheritdoc/>
    public override bool IsPathValid => File.Exists(Path);
    /// <inheritdoc/>
    protected FileObject(string path) : base(path)
    {
    }
}
