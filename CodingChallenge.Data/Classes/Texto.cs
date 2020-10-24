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
