using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Volador_
{
    class SuperMan : volador
    {
        int Exp = 0;
        public void volador()
        {
            Exp += 3;
            Console.WriteLine("Estoy volando como un campeón...");
        }

    }
}
