using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class Kunde
    {
        private string name;
        private List<Bil> MyCars;

        public Kunde(string name, List<Bil> myCars)
        {
            this.name = name;
            MyCars = myCars;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{name}");
        }
    }
}
