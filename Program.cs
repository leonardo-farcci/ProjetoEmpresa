using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor v = new Vendedor("Tmr", "141451", 1500, 50000);
            Administrativo a = new Administrativo("Leo", "444444", 2600, 58);

            Console.WriteLine(v);
            v.imprimirSalario();

            Console.WriteLine(a);
            a.imprimirSalario();


            Console.ReadKey();
        }
    }
}
