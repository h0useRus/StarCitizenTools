namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The file object
/// </summary>
public abstract record FileObject : FileSystemObject
{
    /// <inheritdoc/>
    protected FileObject(string path) : base(path)
    {
    }
}
