using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huset
{
    internal class Rom
    {
        public string Romnavn { get; set; }
        public string Romtype { get; set; }

        public Rom(string romnavn, string romtype)
        {
            Romnavn = romnavn;
            Romtype = romtype;
        }   
    }
}
