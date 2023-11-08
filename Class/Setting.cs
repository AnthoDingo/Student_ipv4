using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPv4.Class
{
    [Serializable]
    internal class Setting
    {
        public string Password { get; set; } = "admin";
        public int Number { get; set; } = 10;
    }
}
