using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanar : Ember
    {
        private string szak;
        private bool osztalyfonok;

        public Tanar(string nev, int eletkor, string szak, bool osztalyfonok) :base(nev, eletkor)
        {
            this.szak = szak;
            this.osztalyfonok = osztalyfonok;
        }
        public new void Koszon()
        {
            if (osztalyfonok)
            {
                Console.WriteLine($"{nev} vagyok, a(z) {szak} tanár. Osztályfőnök.");
            }
            else
            {
                Console.WriteLine($"{nev} vagyok, a(z) {szak} tanár.");
            }
            
        }
    }
}
