using NSW.StarCitizen.Tools.API.Json;

namespace NSW.StarCitizen.Tools.API
{
    public record AppDataGameFolder : FileSystemEntity
    {
        public const string GraphicsSettingsFolder = "GraphicsSettings";
        public const string ShadersFolder = "shaders";
        public bool IsGameFolder => Directory.Exists(Path.Combine(EntityPath, ShadersFolder));
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
