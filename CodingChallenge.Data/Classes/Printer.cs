using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.Globalization;
using System.Net.Mime;

namespace CodingChallenge.Data.Classes
{
    public  class Printer
    {
      
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                if (idioma == Idioma.Castellano)
                    sb.Append( "<h1>Lista vacía de formas!</h1>");
                else if (idioma == Idioma.Portugues)
                    sb.Append("<h1>Lista vazia de formas!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                if (idioma == Idioma.Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else if (idioma == Idioma.Portugues)
                    sb.Append("<h1>Relatório de forma</h1>");
                else
                    // default es inglés
                    sb.Append("<h1>Shapes report</h1>");

                int numeroCuadrados = 0, numeroCirculos = 0, numeroTriangulos = 0, numeroRectangulos = 0;
                decimal areaCuadrados = 0m, areaCirculos = 0m, areaTriangulos = 0m, areaRectangulos = 0m;
                decimal perimetroCuadrados = 0m, perimetroCirculos = 0m, perimetroTriangulos = 0m, perimetroRectangulos = 0m;
                

                for (var i = 0; i < formas.Count; i++)
                {
                    if (formas[i].Tipo is Cuadrado)
                    {
                        numeroCuadrados++;
                        areaCuadrados += formas[i].CalcularArea();
                        perimetroCuadrados += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo is Circulo)
                    {
                        numeroCirculos++;
                        areaCirculos += formas[i].CalcularArea();
                        perimetroCirculos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo is Triangulo)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo is TrianguloEquilatero)
                    {
                        numeroTriangulos++;
                        areaTriangulos += formas[i].CalcularArea();
                        perimetroTriangulos += formas[i].CalcularPerimetro();
                    }
                    if (formas[i].Tipo is Rectangulo)
                    {
                        numeroRectangulos++;
                        areaRectangulos += formas[i].CalcularArea();
                        perimetroRectangulos += formas[i].CalcularPerimetro();
                    }

                }

                 sb.Append(ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, tipoFormaGeometrica.Cuadrado, idioma));
                 sb.Append(ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, tipoFormaGeometrica.Circulo, idioma));
                 sb.Append(ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, tipoFormaGeometrica.Triangulo, idioma));
                 sb.Append(ObtenerLinea(numeroRectangulos, areaRectangulos, perimetroRectangulos, tipoFormaGeometrica.Rectangulo, idioma));

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Idioma.Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Idioma.Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));
            }

            return sb.ToString();
        }
        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, tipoFormaGeometrica tipo, Idioma idioma)
       {
           if (cantidad > 0)
           {

               if (idioma == Idioma.Castellano)
                   return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
               else if (idioma == Idioma.Portugues)
                   return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perímetro {perimetro:#.##} <br/>";

               return $"{cantidad} {TraducirForma(tipo, cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
           }

           return string.Empty;
       }

        private static string TraducirForma(tipoFormaGeometrica tipo, int cantidad, Idioma idioma)
        {
            
            switch (tipo)
            {
                case tipoFormaGeometrica.Cuadrado:
                    if (idioma == Idioma.Castellano)
                        return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    else if (idioma == Idioma.Portugues)
                        return cantidad == 1 ? "Praça" : "Praça";
                    else
                        return cantidad == 1 ? "Square" : "Squares";
                case tipoFormaGeometrica.Circulo:
                    if (idioma == Idioma.Castellano)
                        return cantidad == 1 ? "Círculo" : "Círculos";
                     else if (idioma == Idioma.Portugues)
                        return cantidad == 1 ? "Círculo" : "Círculos";
                    else
                        return cantidad == 1 ? "Circle" : "Circles";
                case tipoFormaGeometrica.TrianguloEquilatero:
                    if (idioma == Idioma.Castellano) 
                        return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else if (idioma == Idioma.Portugues)
                        return cantidad == 1 ? "Triângulo" : "Triângulos";
                    else 
                        return cantidad == 1 ? "Triangle" : "Triangles";
                case tipoFormaGeometrica.Triangulo:
                    if (idioma == Idioma.Castellano)
                        return cantidad == 1 ? "Triángulo" : "Triángulos";
                    else if (idioma == Idioma.Portugues)
                        return cantidad == 1 ? "Triângulo" : "Triângulos";
                    else
                        return cantidad == 1 ? "Triangle" : "Triangles"; 
            }

            return string.Empty;
        }

    }
}