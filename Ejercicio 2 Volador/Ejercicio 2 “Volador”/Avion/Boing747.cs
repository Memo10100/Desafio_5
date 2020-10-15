using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Volador_
{

    class Boing747 : volador
    {
        int Hora_De_vuelo = 0;
        public void volador()
        {
            Hora_De_vuelo += 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
