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
            // var nuevoCirculo = new Circulo(3);
            // var nuevoTriangulo = new TrianguloEquilatero(4, 3);
            // var nuevoCuadrado2 = new Cuadrado(2);
            // var nuevotrianguloc = new Triangulo(4.3m);
            FormaGeometrica[] listaRango =
            {
                nuevoCuadrado
            };
            List<FormaGeometrica> listaFormaGeometricas = new List<FormaGeometrica>();
            listaFormaGeometricas.AddRange(listaRango);
            
            Console.WriteLine(Reporte.Imprimir(listaFormaGeometricas, Idioma.Portugues));


        }
    }
}
