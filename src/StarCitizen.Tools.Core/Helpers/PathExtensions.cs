namespace NSW.StarCitizen.Tools.Helpers
{
    internal static class PathExtensions
    {
        public static string AddPathPart(this string rootPath, params string[] paths)
        {
            var newPaths = new string[paths.Length + 1];
            newPaths[0] = rootPath;
            Array.Copy(paths, 0, newPaths, 1, paths.Length);
            return Path.Combine(newPaths);
        }
    }
}
