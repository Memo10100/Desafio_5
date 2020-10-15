using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Imprimible
{
    class Program
    {
        static void Main(string[] args)
        {

            Contrato C1 = new Contrato();
            Foto F1 = new Foto();
            Documento Doc1 = new Documento();
            Impresora I1 = new Impresora();

            I1.AgregarImprimible(C1);
            I1.AgregarImprimible(F1);
            I1.AgregarImprimible(Doc1);

            I1.ImprimirTodo();
            Console.ReadKey();


        }
    }
}
