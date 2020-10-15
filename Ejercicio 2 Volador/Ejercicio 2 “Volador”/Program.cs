using Ejercicio_2__Volador_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Volador
{
    class Program
    {
        static void Main(string[] args)
        {

            Pato A1 = new Pato();
            Boing747 Av1 = new Boing747();
            SuperMan SH1 = new SuperMan();
            TorreDeControl TC1 = new TorreDeControl();

            TC1.agregarVolador(A1);
            TC1.agregarVolador(Av1);
            TC1.agregarVolador(SH1);

            TC1.vuelenTodos();
            Console.ReadKey();

        }
    }
}
