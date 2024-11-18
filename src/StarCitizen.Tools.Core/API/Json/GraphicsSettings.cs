using NSW.StarCitizen.Tools.Helpers;

namespace NSW.StarCitizen.Tools.API.Json
{
    public class GraphicsSettings
    {
        /// <summary>
        /// The build manifest file name
        /// </summary>
        public const string FileName = "GraphicsSettings.json";
        /// <summary>
        /// Graphics renderer
        /// </summary>
        public GraphicRender GraphicsRenderer { get; set; }
        /// <summary>
        /// Load from file. 
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Return deserialized <see cref="GraphicsSettings"/> or <see cref="Default"/>.</returns>
        public static GraphicsSettings? Load(string path) => JsonHelper.GetFromFile<GraphicsSettingsRaw>(Path.Combine(path, FileName))?.GraphicsSettings;
    }

    internal record GraphicsSettingsRaw(GraphicsSettings GraphicsSettings);

    public enum GraphicRender
    {
        DX11,
        Vulcan
    }
}
