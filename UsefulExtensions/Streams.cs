using System.Text;

namespace UsefulExtensions.Streams
{
    public static class Streams
    {
        /// <summary>
        /// Reads a stream to its end with the given encoding
        /// </summary>
        /// <param name="stream">Stream that should be read</param>
        /// <param name="encoding">The encoding that the stream should be read with, uses UTF8 as its default if no encoding is given</param>
        /// <returns>The read stream as a <see cref="string"/></returns>
        public static string ReadStreamToEnd(this Stream stream, Encoding? encoding = null)
        {
            ArgumentNullException.ThrowIfNull(stream, nameof(stream));

            encoding ??= Encoding.UTF8;

            using var reader = new StreamReader(stream, encoding);
            return reader.ReadToEnd();
        }
    }
}
