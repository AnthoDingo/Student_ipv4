using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPv4.Converter
{
    internal static class IntToBytes
    {
        internal static byte[] Convert(int value)
        {
            byte[] octet = BitConverter.GetBytes(value);
            return octet;
        }
    }
}
