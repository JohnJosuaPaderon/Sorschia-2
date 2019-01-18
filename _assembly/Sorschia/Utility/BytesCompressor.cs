using System.IO;
using System.IO.Compression;

namespace Sorschia.Utility
{
    public static class BytesCompressor
    {
        public static byte[] Compress(byte[] uncompressed)
        {
            var output = new MemoryStream();

            using (var deflateStream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                deflateStream.Write(uncompressed, 0, uncompressed.Length);
            }

            return output.ToArray();
        }

        public static byte[] Decompress(byte[] compressed)
        {
            var input = new MemoryStream(compressed);
            var output = new MemoryStream();

            using (var deflateStream = new DeflateStream(input, CompressionMode.Decompress))
            {
                deflateStream.CopyTo(output);
            }

            return output.ToArray();
        }
    }
}
