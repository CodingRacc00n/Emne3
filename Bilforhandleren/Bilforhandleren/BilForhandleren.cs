using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandleren
{
    internal class BilForhandleren
    {
        private string name;
        private List<Bil> bilList;

        public BilForhandleren(string Name)
        {
            name = Name;
            bilList = [
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
                new Bil("Ford", 2010, "NE65133", 120000),
            ];
        }
    }
}
