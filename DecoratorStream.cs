namespace TestDome
{
    using System;
    using System.IO;
    using System.Text;

    public class DecoratorStream : Stream
    {
        private bool isFirst = true;
        private string prefix;
        private Stream stream;

        public DecoratorStream(Stream stream, string prefix) : base()
        {
            this.stream = stream;
            this.prefix = prefix;
        }

        public override bool CanRead { get { return false; } }
        public override bool CanSeek { get { return false; } }
        public override bool CanWrite { get { return true; } }
        public override long Length { get; }
        public override long Position { get; set; }

        public static void Main(string[] args)
        {
            byte[] message = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21 };
            using (MemoryStream stream = new MemoryStream())
            {
                using (DecoratorStream decoratorStream = new DecoratorStream(stream, "First line: "))
                {
                    decoratorStream.Write(message, 0, message.Length);
                    stream.Position = 0;
                    Console.WriteLine(new StreamReader(stream).ReadLine());  //should print "First line: Hello, world!"
                }
            }
        }

        public override void Flush()
        {
            stream.Flush();
        }

        public override int Read(byte[] bytes, int offset, int count)
        {
            return stream.Read(bytes, offset - prefix.Length, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return stream.Seek(offset + prefix.Length, origin);
        }

        public override void SetLength(long length)
        {
            stream.SetLength(length + prefix.Length);
        }

        public override void Write(byte[] bytes, int offset, int count)
        {
            if (isFirst != null)
            {
                SetLength(stream.Length);

                var result = Encoding.UTF8.GetBytes(prefix);
                stream.Write(result, 0, result.Length);

                isFirst = false;
            }

            stream.Write(bytes, offset, count);
        }
    }
}
