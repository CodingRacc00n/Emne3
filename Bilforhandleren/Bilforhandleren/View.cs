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
        private BilForhandleren Dealership;

        public View()
        {
            selectedKunde = new Kunde("Kåre", []);
            Dealership = new BilForhandleren("Eventyr på hjul");
            Run();
        }

        private void Run()
        {
            selectedKunde.ShowInfo();
            selectedKunde.GetName();
            Console.WriteLine($"{selectedKunde.GetName()}");
            Dealership.GoToStore();
        }
    }
}
