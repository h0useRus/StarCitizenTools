namespace NSW.StarCitizen.Tools.API
{
    public record StarCitizenAppData : DirectoryObject
    {
        public StarCitizenAppData()
            : base(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Star Citizen"))
        {
        }
    }
}
