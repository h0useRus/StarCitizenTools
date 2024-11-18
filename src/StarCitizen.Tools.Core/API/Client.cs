using System.Text.Json;
using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public record Client : DirectoryObject
{
    internal Client(string rootPath, ClientMode mode) : base(rootPath.AddPathPart(mode.GetDisplayName()))
    {
        Mode = mode;
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
    public ClientMode Mode { get; init; }
    /// <summary>
    /// The client executable file
    /// </summary>
    public ExeFileObject Executable => new(Path.AddPathPart(BinFolderName, ExecutableFileName));
    /// <summary>
    /// The client build manifest
    /// </summary>
    public BuildManifect Manifest => GetBuildManifest();

    private BuildManifect GetBuildManifest()
    {
        var buildManifectFile = System.IO.Path.Combine(Path, "build_manifest.id");
        if (File.Exists(buildManifectFile))
            try
            {
                using FileStream openStream = File.OpenRead(buildManifectFile);
                var raw = JsonSerializer.Deserialize<BuildManifectRaw>(openStream);
                return raw?.Data ?? BuildManifect.Empty;
            }
            catch
            {
                return BuildManifect.Empty;
            }
        return BuildManifect.Empty;
    }
}
