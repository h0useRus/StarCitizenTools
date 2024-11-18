namespace NSW.StarCitizen.Tools.API
{
    public record BuildManifect(
    string Branch,
    string BuildDateStamp,
    string BuildId,
    string BuildTimeStamp,
    string Config,
    string Platform,
    string RequestedP4ChangeNum,
    string Shelved_Change,
    string Tag,
    Version Version)
    {
        public static BuildManifect Empty { get; }
            = new BuildManifect(
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                new Version(1, 1));
    }

    internal record BuildManifectRaw(BuildManifect Data);
}
