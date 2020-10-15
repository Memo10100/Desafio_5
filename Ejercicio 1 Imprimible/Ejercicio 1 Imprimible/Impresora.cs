using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Imprimible
{
    class Impresora
    {
        List<Imprimible> Cola_De_Impresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach (Imprimible i in Cola_De_Impresion)
            {
                i.Imprimir();
            }
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            Cola_De_Impresion.Add(unImprimible);
        }

    }
}
