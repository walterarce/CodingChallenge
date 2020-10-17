using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using Microsoft.VisualBasic;

namespace ImplementacionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var nuevoCuadrado = new Cuadrado(5);
            var nuevoCirculo = new Circulo(3);
            var nuevoTriangulo = new TrianguloEquilatero(4, 3);
            var nuevoCuadrado2 = new Cuadrado(2);
            var nuevoTriangulo2 = new TrianguloEquilatero(9, 3);
            var nuevoCirculo2 = new Circulo(2.7m);
            var nuevoTriangulo3 = new TrianguloEquilatero(4.2m, 5.6m);
            FormaGeometrica[] listaRango =
            {
                nuevoCuadrado, nuevoCirculo, nuevoTriangulo, nuevoCuadrado2, nuevoTriangulo2, nuevoCirculo2,
                nuevoTriangulo3
            };
            List<FormaGeometrica> listaFormaGeometricas = new List<FormaGeometrica>();
            listaFormaGeometricas.AddRange(listaRango);
            Printer reporte = new Printer();
            Console.WriteLine(Printer.Imprimir(listaFormaGeometricas, Idioma.Ingles));


        }
    }
}
