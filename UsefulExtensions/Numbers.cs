using System.Numerics;

namespace UsefulExtensions.Numbers
{
    public static class Numbers
    {
        /// <summary>
        /// Returns a non null value for a number type
        /// </summary>
        /// <typeparam name="T">Number type</typeparam>
        /// <param name="value">Given number type value</param>
        /// <returns>Zero if value is null, otherwise the value</returns>
        public static T Value<T>(this T? value) where T : INumber<T>
        {
            return value is null ? T.Zero : value;
        }

        /// <summary>
        /// Checks if the number type has a value
        /// </summary>
        /// <typeparam name="T">Number type</typeparam>
        /// <param name="value">Given number type value</param>
        /// <returns>True if the value is not null</returns>
        public static bool HasValue<T>(this T? value) where T : INumber<T>
        {
            return value is not null;
        }

        /// <summary>
        /// Checks if the number type has an actual value
        /// </summary>
        /// <typeparam name="T">Number type</typeparam>
        /// <param name="value">Given number type value</param>
        /// <returns>True if the value is not null or zero</returns>
        public static bool HasActualValue<T>(this T? value) where T : INumber<T>
        {
            return value is not null && value != T.Zero;
        }
    }
}
