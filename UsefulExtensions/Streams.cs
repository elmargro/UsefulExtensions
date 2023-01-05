using System.Text;

namespace UsefulExtensions.Streams
{
    public static class Streams
    {
        /// <summary>
        /// Reads a stream to its end
        /// </summary>
        /// <param name="stream">Stream that should be read</param>
        /// <param name="encoding">The encoding that the stream should be read with, default is UTF8</param>
        /// <returns>The read stream as a string</returns>
        public static string ReadStreamToEnd(this Stream stream, Encoding? encoding = null)
        {
            ArgumentNullException.ThrowIfNull(stream, nameof(stream));

            encoding ??= Encoding.UTF8;

            using var reader = new StreamReader(stream, encoding);
            return reader.ReadToEnd();
        }
    }
}
