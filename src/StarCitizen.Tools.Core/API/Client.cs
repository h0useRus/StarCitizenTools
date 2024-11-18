using NSW.StarCitizen.Tools.API.Json;
using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public record Client : FileSystemEntity
{
    internal Client(string rootPath, ClientMode mode) : base(Path.Combine(rootPath, mode.GetDisplayName()))
    {
        Mode = mode;
        Executable = new(Path.Combine(EntityPath, BinFolderName, ExecutableFileName));
        Manifest = BuildManifect.Load(EntityPath);
    }
    /// <summary>
    /// The executable file name
    /// </summary>
    public const string ExecutableFileName = "StarCitizen.exe";
    /// <summary>
    /// The binary folder name.
    /// </summary>
    public const string BinFolderName = "bin64";
    /// <summary>
    /// The client data folder name.
    /// </summary>
    public const string DataFolderName = "data";
    /// <summary>
    /// The user data folder name.
    /// </summary>
    public const string UserFolderName = "user";
    /// <summary>
    /// The client mode.
    /// </summary>
    public ClientMode Mode { get; }
    /// <summary>
    /// The client executable file
    /// </summary>
    public ExeFile Executable { get; }
    /// <summary>
    /// The client build manifest
    /// </summary>
    public BuildManifect? Manifest { get; }
}
