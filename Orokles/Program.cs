using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember jozef = new Ember("Jozef", 37);
            jozef.Koszon();

            Tanulo mlazsen = new Tanulo("Mlazsen", 16, "10A");
            mlazsen.Koszon();

            Tanar olga = new Tanar("Olga", 25, "testnevelés", false);
            olga.Koszon();

            Tanar stark = new Tanar("Stark úr", 40, "biofizika", true);
            stark.Koszon();

            Console.ReadKey();
        }
    }
}
