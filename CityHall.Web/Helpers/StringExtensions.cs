using System;
namespace CityHall.Web.Helpers
{
	public static class StringExtensions
	{
        public static bool ToBoolean(this string value)
        {
            bool.TryParse(value, out var result);
            return result;
        }

        public static bool IsNull(this string s) => string.IsNullOrWhiteSpace(s);
        public static bool IsNotNull(this string s) => !string.IsNullOrWhiteSpace(s);


        public static string FormatMe(this string value, params object[] args)
            => string.Format(value, args);

    }
}

