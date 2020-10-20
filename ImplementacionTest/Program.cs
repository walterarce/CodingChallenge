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
            var nuevoCuadrado = new Cuadrado(5, Idioma.Ingles);
            var nuevoCirculo = new Circulo(3, Idioma.Ingles);
            var nuevoTriangulo = new TrianguloEquilatero(4, 3);
            var nuevoCuadrado2 = new Cuadrado(2, Idioma.Ingles);
            var nuevotrianguloc = new Triangulo(4.3m, Idioma.Ingles);
            FormaGeometrica[] listaRango =
            {
                nuevoCuadrado, nuevoCirculo, nuevoTriangulo,nuevotrianguloc
            };
            List<FormaGeometrica> listaFormaGeometricas = new List<FormaGeometrica>();
            listaFormaGeometricas.AddRange(listaRango);
            
            Console.WriteLine(Reporte.Imprimir(listaFormaGeometricas, Idioma.Ingles));


        }
    }
}
