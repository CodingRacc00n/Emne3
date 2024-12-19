using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class Bil
    {
        private string merke;
        private int årsmodel;
        private string registreringsnummer;
        private int kilometerstand;

        public Bil(string merke, int årsmodel, string registreringsnummer, int kilometerstand)
        {
            this.merke = merke;
            this.årsmodel = årsmodel;
            this.registreringsnummer = registreringsnummer;
            this.kilometerstand = kilometerstand;
        }
    }
}
