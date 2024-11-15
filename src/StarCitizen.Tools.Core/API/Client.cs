namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The Star Citizen client.
/// </summary>
public class Client : DirectoryObject
{
    private readonly RSI _rsi;
    internal Client(RSI rsi, ClientMode mode) : base(rsi.CreatePath(ClientsFolderName, mode.ToString()))
    {
        _rsi = rsi;
        Mode = mode;
    }
    /// <summary>
    /// The global clients folder name
    /// </summary>
    public const string ClientsFolderName = "StarCitizen";
    /// <summary>
    /// The executable file name
    /// </summary>
    public const string ExecutableFileName = "StarCitizen.exe";
    /// <summary>
    /// The binary folder name.
    /// </summary>
    public const string BinFolderName = "bin64";
    /// <summary>
    /// The clinet data folder name.
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
    public ExeFileObject Executable => new(CreatePath(BinFolderName, ExecutableFileName));
}
