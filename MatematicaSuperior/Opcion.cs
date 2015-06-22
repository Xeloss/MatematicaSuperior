using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaSuperior
{
    public class Opcion
    {
        public Tunel Tunel1 { get; set; }

        public Tunel Tunel2 { get; set; }

        public Opcion(Tunel tunel1, Tunel tunel2)
        {
            this.Tunel1 = tunel1;
            this.Tunel2 = tunel2;
        }

        public bool ErroresMenoresA(decimal e)
        {
            return Tunel1.Error() < e
                && Tunel2.Error() < e;
        }

        public override string ToString()
        {
            return "Tunel 1: (" + Tunel1 + ") Tunel 2: (" + Tunel2 + ")";
        }

        public static Opcion[] ConstruirCon(Muestra[] muestras)
        {
            var opciones = new List<Opcion>();

            for (int i = 2; i < muestras.Length - 3; i++)
            {
                for (int j = i + 1; j < muestras.Length - 2; j++)
                {
                    for (int k = j + 1; k < muestras.Length - 1; k++)
                    {
                        for (int l = k + 1; l < muestras.Length; l++)
                        {
                            var muestrasTunel1 = new Muestra[] { 
                                muestras[0],
                                muestras[i],
                                muestras[j],
                                muestras[k],
                                muestras[l]
                            };

                            var muestrasTunel2 = muestras.Except(muestrasTunel1).ToArray();

                            var tunel1 = new Tunel(muestrasTunel1);
                            var tunel2 = new Tunel(muestrasTunel2);

                            opciones.Add(new Opcion(tunel1, tunel2));
                        }
                    }
                }
            }

            return opciones.ToArray();
        }

    }
}
