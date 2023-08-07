using System;
using System.Collections.Generic;
using KlimberNet.Clases;
using NUnit.Framework;

namespace DataTest
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)IdiomasEnum.Espanol));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)IdiomasEnum.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica(new Cuadrado(5)) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)IdiomasEnum.Espanol);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Cuadrado(1)),
                new FormaGeometrica(new Cuadrado(3))
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)IdiomasEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Circulo(3)),
                new FormaGeometrica(new TrianguloEquilatero(4)),
                new FormaGeometrica(new Cuadrado(2)),
                new FormaGeometrica(new TrianguloEquilatero(9)),
                new FormaGeometrica(new Circulo((decimal)2.75)),
                new FormaGeometrica(new TrianguloEquilatero((decimal)4.2))
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)IdiomasEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(new Cuadrado(5)),
                new FormaGeometrica(new Circulo(3)),
                new FormaGeometrica(new TrianguloEquilatero(4)),
                new FormaGeometrica(new Cuadrado(2)),
                new FormaGeometrica(new TrianguloEquilatero(9)),
                new FormaGeometrica(new Circulo((decimal)2.75)),
                new FormaGeometrica(new TrianguloEquilatero((decimal)4.2))
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)IdiomasEnum.Espanol);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triangulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);

        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecio = new List<FormaGeometrica> { new FormaGeometrica(new TraprecioRectangulo(5, 4, 3, 6)) };

            var resumen = FormaGeometrica.Imprimir(trapecio, (int)IdiomasEnum.Espanol);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 30 | Perimetro 18 <br/>TOTAL:<br/>1 formas Perimetro 18 Area 30", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasTrapecios()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(new TraprecioRectangulo(5,4,3,6)),
                new FormaGeometrica(new TraprecioRectangulo(7,5,3,5)),
                new FormaGeometrica(new TraprecioRectangulo(4,3,3,4))
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)IdiomasEnum.Italiano);

            Assert.AreEqual("<h1>Rapporto sui moduli</h1>3 Trapezi | Area 100.5 | Perimetro 52 <br/>TOTAL:<br/>3 Forme Perimetro 52 Area 100.5", resumen);

        }

        [TestCase]
        public void TestResumenListaConMasTiposEnInglesYConTrapecio()
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

            var resumen = FormaGeometrica.Imprimir(formas, (int)IdiomasEnum.Espanol);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>2 Triangulos | Area 14.57 | Perimetro 24.6 <br/>1 Trapecio | Area 18 | Perimetro 14 <br/>TOTAL:<br/>7 formas Perimetro 84.66 Area 74.57",
                resumen);
        }
    }
}