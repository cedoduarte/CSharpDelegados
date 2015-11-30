using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class MiClase
    {
        public void Inicia()
        {
            Ejecuta(Proceso1);
            Ejecuta(Proceso2);
            Proceso1();
            Proceso2();
            Console.Read();
        }

        private void Ejecuta(Proceso proceso)
        {
            proceso();
        }

        private void Proceso1()
        {
            Console.WriteLine("Proceso 1");
        }

        private void Proceso2()
        {
            Console.WriteLine("Proceso 2");
        }

        private delegate void Proceso();
    }
}
