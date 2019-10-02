using System;
using System.IO;

namespace File_Stream
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\b.txt", FileMode.OpenOrCreate); // creating file stream
            f.WriteByte(65); // writing byte into stream
            f.Close(); // closing stream
        }
    }
}
