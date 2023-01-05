using System;
using System.Net.Http;
using System.Text;

namespace UsefulExtensions.Strings
{
    public static class Strings
    {
        /// <summary>
        /// Returns a non null string-value of a nullable string
        /// </summary>
        /// <param name="value">String value</param>
        /// <returns>The value if its not null, otherwise string.Empty</returns>
        public static string Value(this string? value) => value is null ? string.Empty : value;

        /// <summary>
        /// Checks if a string has a value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the string is not null</returns>
        public static bool HasValue(this string? value) => value is not null;

        /// <summary>
        /// Checks if a string has an actual value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the string is not null, empty or whitespace</returns>
        public static bool HasActualValue(this string? value) => !string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Writes a string as a stream
        /// </summary>
        /// <param name="value">String/byte array that should be written as a stream</param>
        /// <param name="encoding">Encoding in which the stream should be written</param>
        /// <returns>Stream with the value as its buffer</returns>
        public static Stream AsStream(this string value, Encoding? encoding = null)
        {
            ArgumentNullException.ThrowIfNull(value);

            encoding ??= Encoding.UTF8;

            return new MemoryStream(encoding.GetBytes(value));
        }
    }
}
