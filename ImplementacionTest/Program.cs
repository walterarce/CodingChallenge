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

            FormaGeometrica[] listaRango =
            {
                nuevoCuadrado
            };
            List<FormaGeometrica> listaFormaGeometricas = new List<FormaGeometrica>();
            listaFormaGeometricas.AddRange(listaRango);
            
            Console.WriteLine(Reporte.Imprimir(listaFormaGeometricas, Idioma.Ingles));


        }
    }
}
