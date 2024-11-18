
using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// Star Citizen API is the simple tool to access various local client APIs.
/// </summary>
public record RSI : DirectoryObject
{
    /// <summary>
    /// The game launcher.
    /// </summary>
    public Launcher Launcher { get; init; }
    /// <summary>
    /// Create instance of <see cref="RSI"/>.
    /// </summary>
    /// <param name="libraryPath">The root library path.</param>
    public RSI(string libraryPath) : base(libraryPath)
    {
        Launcher = GetLauncher();
    }
    public DirectoryObject AppData { get; } = new StarCitizenAppData();
    /// <summary>
    /// Get Star Citizen launcher object.
    /// </summary>
    /// <param name="launcherFolderPath">Otional full folder path. If it is not defined, current <see cref="FileSystemObject.Path"/> and <see cref="Launcher.DefaultFolderName"/> will used for path generation.</param>
    /// <returns>The Star Citizen launcher object.</returns>
    public Launcher GetLauncher(string? launcherFolderPath = null)
        => new(Path.AddPathPart(launcherFolderPath ?? Launcher.DefaultFolderName));
    /// <summary>
    /// The global clients folder name
    /// </summary>
    public const string ClientsFolderName = "StarCitizen";
    /// <summary>
    /// The <see cref="ClientMode.LIVE"/> client instance.
    /// </summary>
    public Client LIVE => GetClient(ClientMode.Live);
    /// <summary>
    /// The <see cref="ClientMode.PTU"/> client instance.
    /// </summary>
    public Client PTU => GetClient(ClientMode.PTU);
    /// <summary>
    /// Get Star Citizen client object.
    /// </summary>
    /// <param name="mode">The client mode</param>
    /// <returns>The Star Citizen client object.</returns>
    public Client GetClient(ClientMode mode)
        => new(Path.AddPathPart(ClientsFolderName), mode);
    /// <summary>
    /// Get all installed Star Citizen clients.
    /// </summary>
    /// <returns>The enumerable of installed Star Citizen clients</returns>
    public IEnumerable<Client> GetInstalledClients()
    {
        if (IsPathValid)
        {
            foreach (ClientMode clientMode in Enum.GetValues<ClientMode>())
            {
                var client = GetClient(clientMode);
                if (client.IsPathValid)
                    yield return client;
            }
        }
    }
}
