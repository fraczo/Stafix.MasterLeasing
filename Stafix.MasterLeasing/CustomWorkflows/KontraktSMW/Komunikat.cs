using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KontraktSMW
{
    public class Komunikat
    {
        public DateTime DataZgloszenia { get; set; }
        public string Klient { get; set; }
        public string WartoscPLN { get; set; }
        public string CelFinansowania { get; set; }
        public string Ustalenia { get; set; }
        public string StatusLeadu { get; set; }
    }
}
