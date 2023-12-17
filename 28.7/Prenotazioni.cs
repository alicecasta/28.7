using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Prenotazioni
    {
        public DateTime Dataprenotazione { get; set; }
        public int Numeroprogressivo { get; set; }
        public int Anno { get; set; }
        public DateTime Dalgiorno { get; set; }
        public DateTime Algiorno { get; set; }
        public float Caparra { get; set; }
        public float Tariffa { get; set;}
        public Servizi Serviziaggiuntivi { get; set; }
     
    }
}
