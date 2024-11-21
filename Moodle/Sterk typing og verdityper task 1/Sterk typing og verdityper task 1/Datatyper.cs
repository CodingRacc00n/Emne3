using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sterk_typing_og_verdityper_task_1
{
    internal class Datatyper
    {
        int tall = 3;

        float desimalTall = 3.01F;
        double desimalTall2 = 3.01;
        decimal desimalTall3 = 3.01M;

        char bokstav = 'A';
        string tekst = "Hello";

        bool santUsant = false;

        private int[] tallArray = { 1, 2, 3 };
        private string[] tekstArray = { "hei", "på", "deg" };

        List<int> listeMedTall = new List<int>();
    }
}
