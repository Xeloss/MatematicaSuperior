using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaSuperior
{
    public class Muestra
    {
        public Muestra(int numero, int hidrogeno, int fotones)
        {
            this.Numero = numero;
            this.Hidrogeno = hidrogeno;
            this.Fotones = fotones;
        }

        public int Numero { get; set; }
        public int Hidrogeno { get; set; }
        public int Fotones { get; set; }

        public override string ToString()
        {
            return this.Numero.ToString();
        }
    }
}
