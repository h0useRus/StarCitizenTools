namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// Star Citizen API is the simple tool to access various local client APIs.
/// </summary>
public record RSI : FileSystemEntity
{
    private Dictionary<ClientMode, Client> _clients = [];
    /// <summary>
    /// Create instance of <see cref="RSI"/>.
    /// </summary>
    /// <param name="libraryPath">The root library path.</param>
    public RSI(string libraryPath) : base(libraryPath)
    {
        Rebuild();
    }
    /// <summary>
    /// Rebuild RSI structure
    /// </summary>
    public void Rebuild()
    {
        Launcher = GetLauncher();
        _clients.Clear();
        foreach (var client in GetInstalledClients())
        {
            _clients.Add(client.Mode, client);
        }
    }

    #region AppData
    public AppDataRootFolder AppData { get; } = new AppDataRootFolder();
    #endregion

    #region Launcher
    /// <summary>
    /// The game launcher.
    /// </summary>
    public Launcher Launcher { get; private set; } = null!;
    /// <summary>
    /// Get Star Citizen launcher object.
    /// </summary>
    /// <param name="launcherFolderPath">Otional full folder path. If it is not defined, current <see cref="FileSystemEntity.Path"/> and <see cref="Launcher.DefaultFolderName"/> will used for path generation.</param>
    /// <returns>The Star Citizen launcher object.</returns>
    public Launcher GetLauncher(string? launcherFolderPath = null)
        => new(Path.Combine(EntityPath, launcherFolderPath ?? Launcher.DefaultFolderName));
    #endregion

    #region Clients
    /// <summary>
    /// The global clients folder name
    /// </summary>
    public const string ClientsFolderName = "StarCitizen";
    /// <summary>
    /// The <see cref="ClientMode.LIVE"/> client instance.
    /// </summary>
    public Client LIVE => _clients[ClientMode.Live];
    /// <summary>
    /// The <see cref="ClientMode.PTU"/> client instance.
    /// </summary>
    public Client PTU => _clients[ClientMode.PTU];
    /// <summary>
    /// Get Star Citizen client object.
    /// </summary>
    /// <param name="mode">The client mode</param>
    /// <returns>The Star Citizen client object.</returns>
    public Client GetClient(ClientMode mode) => new(Path.Combine(EntityPath, ClientsFolderName), mode);
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
    #endregion
}
