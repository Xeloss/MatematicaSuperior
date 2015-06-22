using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaSuperior
{
    public class Tunel
    {
        private Muestra[] Muestras;

        public Tunel(Muestra[] Muestras)
        {
            this.Muestras = Muestras;
        }

        public decimal P(decimal x)
        {
            var b = ((V / n) - ((Y * W) / (Z * n))) / (1 - (Y * Y / (Z * n)));

            var a = (W - (b * Y)) / Z;

            return a * x + b;
        }

        public decimal Error()
        {
            return this.Muestras.Sum(m => Cuadrado(P(m.Fotones) - m.Hidrogeno));
        }

        /// <summary>
        /// Sumatoria de F(xi)
        /// </summary>
        private decimal V 
        {
            get { return this.Muestras.Sum(m => m.Hidrogeno); }
        }

        private decimal n 
        {
            get { return this.Muestras.Length; } 
        }

        /// <summary>
        /// Sumatoria de Xi
        /// </summary>
        private decimal Y 
        {
            get { return this.Muestras.Sum(m => m.Fotones); }
        }

        /// <summary>
        /// Sumatoria de Xi*F(Xi)
        /// </summary>
        private decimal W 
        {
            get { return this.Muestras.Sum(m => m.Fotones * m.Hidrogeno); } 
        }

        /// <summary>
        /// Sumatoria de Xi^2
        /// </summary>
        private decimal Z 
        {
            get { return this.Muestras.Sum(m => m.Fotones * m.Fotones); }
        }

        private decimal Cuadrado(decimal x)
        {
            return x * x;
        }

        public override string ToString()
        {
            return this.Muestras.Aggregate("", (acum, item) => acum + " " + item);
        }
    }
}
