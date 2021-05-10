using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
   class TipoTriangulo
   {
        public int x = 0;
        public int y = 0;
        public int z = 0;


        public TipoTriangulo()
        {

        }
        public TipoTriangulo(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z; 
        }

        }
        public string Tipo()
        {
            string tipoTriangulo = "";

            if (Validacao())
            {
                if ((x == y) && (y == z))
                {
                    tipoTriangulo = "Equilátero";
                }
                else if ((x == y) || (x == z) || (y == z))
                {
                    tipoTriangulo = "Isósceles";
                }
                else
                {
                    tipoTriangulo = "Escaleno";
                }
            }
            else
            {
                tipoTriangulo = "";
            }
            return tipoTriangulo;
        }


    }


}
