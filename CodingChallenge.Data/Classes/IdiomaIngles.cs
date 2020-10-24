using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaIngles:TextoIdioma
    {
       

        public IdiomaIngles()
        {
            Encabezado_ListaVacia = "<h1>Shapes report</h1>";
            Encabezado = "<h1>Shapes report</h1>";
            Traslate_Fig_Title = "Shape";
            Traslate_Fig_Cantidad = "Amount";
            Traslate_Fig_Perimetro = "Perimeter";
            Traslate_Fig_Area = "Area";
            Traslate_Suma_Perimetro = "Amount of Perimeter";
            Traslate_Suma_Area="Amount of Area";
        }

        public IdiomaIngles(string forma)
        {
            if (forma == "Cuadrado")
            { NombredeFigura = "Square"; }
        }

        public override string TraducirNombreForma(string forma)
        {
            return "Square";
        }
    }
}
