using System.Reflection;

namespace NSW.StarCitizen.Tools.Helpers
{
    internal static class AssemblyHelpers
    {
        public static string GetTitle()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? string.Empty;
        }

        public static string GetFileVersion()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version ?? string.Empty;
        }
        public static string GetProduct()
        {
            return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>()?.Product ?? string.Empty;
        }
    }
}
