using CRC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayOfBytes = Encoding.ASCII.GetBytes("1170467141PAX_A930_BGWC");

            var crc32 = new Crc32();

            var crcGet = crc32.Get(arrayOfBytes);
            var tostring = crcGet.ToString("X2");

            var result = string.Format("{0:X2}", crc32.Get(arrayOfBytes).ToString("X2"));
        }
    }
}
