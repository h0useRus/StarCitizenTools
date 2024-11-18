using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API.Json
{
    public record BuildManifect
    {
        /// <summary>
        /// The build manifest file name
        /// </summary>
        public const string FileName = "build_manifest.id";
        /// <summary>
        /// Empty manifest
        /// </summary>
        public static BuildManifect Default { get; } = new BuildManifect();
        /// <summary>
        /// The Branch (usually same as server version).
        /// </summary>
        public string Branch { get; set; } = string.Empty;
        /// <summary>
        /// The release date.
        /// </summary>
        public string BuildDateStamp { get; set; } = string.Empty;
        /// <summary>
        /// The build Id.
        /// </summary>
        public string BuildId { get; set; } = string.Empty;
        /// <summary>
        /// The release time
        /// </summary>
        public string BuildTimeStamp { get; set; } = string.Empty;
        /// <summary>
        /// The build config
        /// </summary>
        public string Config { get; set; } = string.Empty;
        /// <summary>
        /// The build platfrom (PC)
        /// </summary>
        public string Platform { get; set; } = string.Empty;
        /// <summary>
        /// The internal repository chnage number
        /// </summary>
        public string RequestedP4ChangeNum { get; set; } = string.Empty;
        /// <summary>
        /// The internal repository shelved chnage
        /// </summary>
        public string Shelved_Change { get; set; } = string.Empty;
        /// <summary>
        /// Build tag (public)
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// The executable version
        /// </summary>
        public Version Version { get; set; } = new Version();
        /// <summary>
        /// Load from file.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Return deserialized <see cref="BuildManifect"/> or <see cref="Default"/>.</returns>
        public static BuildManifect LoadOrDefault(string path) => JsonHelper.GetFromFile<BuildManifectRaw>(Path.Combine(path, FileName))?.Data ?? Default;
    }

    internal record BuildManifectRaw(BuildManifect Data);
}
