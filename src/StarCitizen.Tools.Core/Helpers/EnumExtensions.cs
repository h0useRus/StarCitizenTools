using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace NSW.StarCitizen.Tools.Helpers
{
    internal static class EnumExtensions
    {
        internal static string GetDisplayName(this Enum enumValue)
        {
            var enumType = enumValue.GetType();
            var memInfo = enumType.GetMember(enumValue.ToString()).First();
            var attribute = memInfo.GetCustomAttributes<DisplayAttribute>(false).FirstOrDefault();
            return attribute != null ? attribute.Name ?? string.Empty : enumValue.ToString();
        }
    }
}
