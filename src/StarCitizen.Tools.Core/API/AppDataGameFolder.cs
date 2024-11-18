using NSW.StarCitizen.Tools.API.Json;

namespace NSW.StarCitizen.Tools.API
{
    public record AppDataGameFolder : FileSystemEntity
    {
        /// <summary>
        /// Graphics settings folder
        /// </summary>
        public const string GraphicsSettingsFolder = "GraphicsSettings";
        /// <summary>
        /// Shaders folder
        /// </summary>
        public const string ShadersFolder = "shaders";
        /// <summary>
        /// Che if folder contains game data
        /// </summary>
        public bool IsGameFolder => Directory.Exists(Path.Combine(EntityPath, ShadersFolder));
        /// <summary>
        /// The display ready directory name
        /// </summary>
        public string Name { get; init; }

        internal AppDataGameFolder(string path) : base(path)
        {
            Name = TryGetName();
        }
        /// <summary>
        /// Load Graphics settings
        /// </summary>
        /// <returns></returns>
        public GraphicsSettings? GetGraphicsSettings() => GraphicsSettings.Load(Path.Combine(EntityPath, GraphicsSettingsFolder));

        private string TryGetName()
        {
            var dirName = new DirectoryInfo(EntityPath).Name;
            var split = dirName.Split('_');
            if (split.Length > 1)
            {
                return split[1].Substring(1, split[1].Length - 2);
            }
            return dirName;
        }
    }
}
