using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCasos
{
    public class Procesos
    {
        public Procesos()
        {
        }

        public void ProcesoInicial()
        {
            int i = 0;

            while (i < 1000)
            {
                Console.WriteLine("--- Proceso inicial. Linea: {0} ---", i++);
            }

        }
    }
}
