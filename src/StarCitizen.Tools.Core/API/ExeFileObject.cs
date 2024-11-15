using System.Diagnostics;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The executable file object
/// </summary>
public class ExeFileObject : FileObject
{
    /// <summary>
    /// An executable file version.
    /// </summary>
    public FileVersionInfo? Version => IsPathValid ? FileVersionInfo.GetVersionInfo(Path) : null;
    /// <inheritdoc/>
    public ExeFileObject(string path) : base(path)
    {
    }
}
