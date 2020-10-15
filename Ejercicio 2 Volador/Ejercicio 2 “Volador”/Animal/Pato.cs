using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Volador_
{
    class Pato : volador
    {

        int Energia = 100;
        public void volador()
        {
            Energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }

    }
}
