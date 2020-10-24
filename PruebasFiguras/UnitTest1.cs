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
                Reporte.Imprimir(new List<FormaGeometrica>(), Idioma.Castellano));
        }
        [TestCase]
        public void TestConUnRectangulo()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4) };

            var resumen = Reporte.Imprimir(rectangulo, Idioma.Castellano);
            Assert.AreEqual("<h1>Reporte de Formas</h1>Figura: Rectangulo, Cantidad:1Suma de Area :  Suma de Perimetros : 8 <br/></br>TOTAL:1 , Figuras <br/>Perimetro8 Area", resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(4) };

            var resumen = Reporte.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>Figura: Cuadrado, Cantidad:1Suma de Area : 16 Suma de Perimetros : 16 <br/></br>TOTAL:1 , Figuras <br/>Perimetro16 Area16", resumen);
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

            var resumen = Reporte.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>Figura: Cuadrado, Cantidad:3Suma de Area : 35 Suma de Perimetros : 36 <br/></br>TOTAL:3 , Figuras <br/>Perimetro36 Area35", resumen);
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

            var resumen = Reporte.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>Figura: Cuadrado, Cantidad:2Suma de Area : 29 Suma de Perimetros : 28 <br/>Figura: Circulo, Cantidad:2Suma de Area : 12.79 Suma de Perimetros : 17.91 <br/>Figura: TrianguloEquilatero, Cantidad:3Suma de Area : 31.26 Suma de Perimetros : 51.6 <br/></br>TOTAL:7 , Figuras <br/>Perimetro97.51 Area73.05",
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

            var resumen = Reporte.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>Figura: Cuadrado, Cantidad:2Suma de Area : 29 Suma de Perimetros : 28 <br/>Figura: Circulo, Cantidad:2Suma de Area : 13.01 Suma de Perimetros : 18.06 <br/>Figura: TrianguloEquilatero, Cantidad:3Suma de Area : 26.25 Suma de Perimetros : 51.6 <br/></br>TOTAL:7 , Figuras <br/>Perimetro97.66 Area68.26",
                resumen);
        }

       
    }
}
