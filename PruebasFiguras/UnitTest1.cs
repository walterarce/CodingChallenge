using System;
using System.Collections.Generic;
using CodingChallenge.Data;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Printer.Imprimir(new List<FormaGeometrica>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Printer.Imprimir(new List<FormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(4) };

            var resumen = Printer.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 16 | Perimetro 16 <br/>TOTAL:<br/>1 formas Perimetro 16 Area 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Printer.Imprimir(cuadrados, Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4,3),
                new Cuadrado(2),
                new TrianguloEquilatero(9,3),
                new Circulo(2.7m),
                new TrianguloEquilatero(4.2m,5.6m)
            };

            var resumen = Printer.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 12.79 | Perimeter 17.91 <br/>TOTAL:<br/>4 shapes Perimeter 45.91 Area 41.79",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4,1.5m),
                new Cuadrado(2),
                new TrianguloEquilatero(9,4),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m,2.5m)
            };

            var resumen = Printer.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>TOTAL:<br/>4 formas Perimetro 46.06 Area 42.01",
                resumen);
        }
    }
}
