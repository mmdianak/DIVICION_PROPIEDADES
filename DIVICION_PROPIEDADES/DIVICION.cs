using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIVICION_PROPIEDADES
{
    internal class DIVICION
    {
        internal class cldivisión
        {
            // Propiedades, campos, etc.
            private double n1;
            private double n2;

            // Encapsulamiento de las propiedades.
            public double N1 { get => n1; set => n1 = value; }
            public double N2 { get => n2; set => n2 = value; }

            // Metodos.
            public double Dividir()
            {
                return n1 / n2;
            }
        }
    }
}

