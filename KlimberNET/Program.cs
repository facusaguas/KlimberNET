using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlimberNet.Clases;

namespace KlimberSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Circulo(3)),
                new FormaGeometrica(new TrianguloEquilatero(4)),
                new FormaGeometrica(new Cuadrado(2)),
                new FormaGeometrica(new Circulo((decimal)2.75)),
                new FormaGeometrica(new TrianguloEquilatero((decimal)4.2)),
                new FormaGeometrica(new TraprecioRectangulo(4,3,3,4))
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)IdiomasEnum.Italiano);

            Console.WriteLine(resumen);

            Console.ReadKey();
        }
    }
}