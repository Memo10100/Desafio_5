using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2__Volador_
{
    class TorreDeControl
    {

        List<volador> Lista_De_Voladores = new List<volador>();

        public void vuelenTodos()
        {


            foreach (volador i in Lista_De_Voladores)
            {
                i.volador();
            }

        }

        public void agregarVolador(volador unVolable)
        {
            Lista_De_Voladores.Add(unVolable);
        }
    }
}
