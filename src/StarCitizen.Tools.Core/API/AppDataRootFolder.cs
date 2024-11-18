namespace NSW.StarCitizen.Tools.API
{
    public record AppDataRootFolder : FileSystemEntity
    {
        /// <summary>
        /// The AppData folder name
        /// </summary>
        public const string FolderName = "Star Citizen";
        internal AppDataRootFolder()
            : base(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FolderName))
        {
        }
        /// <summary>
        /// Get list of AppData game folders.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AppDataGameFolder> GetGameFolders()
            => Directory.GetDirectories(EntityPath).Select(directory => new AppDataGameFolder(directory));
    }
}
