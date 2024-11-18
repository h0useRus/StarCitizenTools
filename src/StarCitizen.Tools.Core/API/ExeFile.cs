using System.Diagnostics;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The executable file object
/// </summary>
public record ExeFile : FileSystemEntity
{
    /// <summary>
    /// An executable file version.
    /// </summary>
    public FileVersionInfo? Version { get; }
    /// <inheritdoc/>
    public ExeFile(string path) : base(path)
    {
        Version = IsPathValid ? FileVersionInfo.GetVersionInfo(EntityPath) : null;
    }
    /// <summary>
    /// Run Executable file
    /// </summary>
    /// <returns></returns>
    public int Run()
    {
        if (!IsPathValid)
            return -1;

        try
        {
            var startInfo = new ProcessStartInfo(EntityPath);
            using var process = Process.Start(startInfo);
            if (process != null)
            {
                process.WaitForExit();

                return process.ExitCode;
            }
            return -1;
        }
        catch
        {
            return -1;
        }
    }
}
