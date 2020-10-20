using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
   public  static class Texto
    {
    
        
        public static string Encabezado_ListaVacia(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida= "<h1>Lista vacía de formas!</h1>";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "<h1>Lista vazia de formas!</h1>";
            else
                textosalida = "<h1>Empty list of shapes!</h1>";

            return textosalida;
        }

        public static string Encabezado(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "<h1>Reporte de Formas</h1>";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "<h1>Relatório de forma</h1>";
            else
                // default es inglés
                textosalida = "<h1>Shapes report</h1>";

            return textosalida;
        }
        public static string Traslate_Fig_Title(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "Figura";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "Figura";
            else
                // default es inglés
                textosalida = "Shape";

            return textosalida;
        }

        public static string Traslate_Fig_Cantidad(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "Cantidad";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "Quantidade";
            else
                // default es inglés
                textosalida = "Amount";

            return textosalida;
        }
        public static string Traslate_Fig_Perimetro(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "Perimetro";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "Perímetro";
            else
                // default es inglés
                textosalida = "Perimeter";

            return textosalida;
        }
        public static string Traslate_Fig_Area(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "Area";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "Área";
            else
                // default es inglés
                textosalida = "Area";

            return textosalida;
        }

         public static string Traslate_Suma_Perimetro(Idioma IdiomaTexto)
        {
            var textosalida = "";
            if (IdiomaTexto == Idioma.Castellano)
                textosalida = "Suma de Perimetros";
            else if (IdiomaTexto == Idioma.Portugues)
                textosalida = "Suma de Perimetros";
            else
                // default es inglés
                textosalida = "Amount of Perimeter";

            return textosalida;
        }

         public static string Traslate_Suma_Area(Idioma IdiomaTexto)
         {
             var textosalida = "";
             if (IdiomaTexto == Idioma.Castellano)
                 textosalida = "Suma de Area";
             else if (IdiomaTexto == Idioma.Portugues)
                 textosalida = "Suma de Area";
             else
                 // default es inglés
                 textosalida = "Amount of Area";

             return textosalida;
         }
        public static string Traslate_Fig_Name(Idioma IdiomaTexto, FormaGeometrica forma)
        {
            var textosalida = "";
            switch (IdiomaTexto)
            {
                case Idioma.Castellano:
                    if (forma is Cuadrado)
                    {
                        return textosalida = "Cuadrado";
                    }
                    if (forma is Circulo)
                    {
                        return textosalida = "Circulo";
                    }
                    if (forma is Rectangulo)
                    {
                        return textosalida = "Rectangulo";
                    }
                    if (forma is Trapecio)
                    {
                        return textosalida = "Trapecio";
                    }
                    else
                    {
                        return textosalida = "Triangulo Equilatero";
                    }
                case Idioma.Portugues:
                    if (forma is Cuadrado)
                    {
                        return textosalida = "Praça";
                    }
                    if (forma is Circulo)
                    {
                        return textosalida = "Círculo";
                    }
                    if (forma is Rectangulo)
                    {
                        return textosalida = "Retângulo";
                    }
                    if (forma is Trapecio)
                    {
                        return textosalida = "Trapézio";
                    }
                    else
                    {
                        return textosalida = "Triângulo Equilátero";
                    }
                default:
                    if (forma is Cuadrado)
                    {
                        return textosalida = "Square";
                    }
                    if (forma is Circulo)
                    {
                        return textosalida = "Circle";
                    }
                    if (forma is Rectangulo)
                    {
                        return textosalida = "Rectangle";
                    }
                    if (forma is Trapecio)
                    {
                        return textosalida = "Trapeze";
                    }
                    else
                    {
                        return textosalida = "Equilateral Triangle";
                    };
            }
            
            return textosalida;
        }

    }
}
