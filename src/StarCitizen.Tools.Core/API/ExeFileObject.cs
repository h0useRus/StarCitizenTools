using System.Diagnostics;

namespace NSW.StarCitizen.Tools.API;
/// <summary>
/// The executable file object
/// </summary>
public record ExeFileObject : FileObject
{
    /// <summary>
    /// An executable file version.
    /// </summary>
    public FileVersionInfo? Version => IsPathValid ? FileVersionInfo.GetVersionInfo(Path) : null;
    /// <inheritdoc/>
    public ExeFileObject(string path) : base(path)
    {
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
            var startInfo = new ProcessStartInfo(Path);
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
