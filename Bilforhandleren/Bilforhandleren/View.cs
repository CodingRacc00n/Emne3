using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class View
    {
        private Kunde selectedKunde;

        public View()
        {
            selectedKunde = new Kunde("Kåre", []);
            Run();
        }

        private void Run()
        {
            selectedKunde.ShowInfo();
        }
    }
}
