using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaSuperior
{
    class Program
    {        
        static void Main(string[] args)
        {
            new Program().Execute();
        }

        public Muestra[] Muestras;

        public Program()
        {
            this.Muestras = new Muestra[] { 
                new Muestra(1, 54, 100),
                new Muestra(2, 83, 150),
                new Muestra(3, 118, 230),
                new Muestra(4, 123, 240),
                new Muestra(5, 132, 260),
                new Muestra(6, 148, 290),
                new Muestra(7, 150, 300),
                new Muestra(8, 178, 350),
                new Muestra(9, 184, 375),
                new Muestra(10, 198, 390)
            };
        }

        public void Execute()
        {
            var opciones = Opcion.ConstruirCon(this.Muestras);

            for (int i = 0; i < opciones.Length; i++)
            {
                var opcion = opciones[i];

                Console.WriteLine("\r\nAlternativa " + (i+1) + ":");
                Console.WriteLine(opcion.ToString());

                if (opcion.ErroresMenoresA(0.3m))
                {
                    Console.WriteLine("Se econtro la mejor alternativa");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
