using System;


namespace Triangulos.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
           TipoTriangulo equilatero = new TipoTriangulo();
           TipoTriangulo isoseles = new TipoTriangulo();
           TipoTriangulo escaleno = new TipoTriangulo();

            int x = 30;
            int y = 30;
            int z = 20;

            if ((x < 0) || (y < 0) || (z < 0))
            {

                Console.WriteLine("\nOs valores não podem formar um triangulo\n");

            }

            else if ((x == y) && (x == z) && (y == z))
            {

                Console.WriteLine("O triangulo e equilátero\n");

            }

            else if ((x == y) && (x == z) || (y == z))
            {

                Console.WriteLine("O triangulo e isósceles\n");

            }

            else if ((x != y) && (x != z) && (y != z))
            {

                Console.WriteLine("O triangulo e escaleno\n");

            }
            else
            {
                Console.WriteLine("Triangulo Invalido");
             
            }
            Console.ReadLine();

        }
    }
}
