using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaCastellano : TextoIdioma
    {
        public IdiomaCastellano()
        {
            Encabezado_ListaVacia = "<h1>Lista vacía de formas!</h1>";
            Encabezado = "<h1>Reporte de Formas</h1>";
            Traslate_Fig_Title = "Figura";
            Traslate_Fig_Cantidad = "Cantidad";
            Traslate_Fig_Perimetro = "Perimetro";
            Traslate_Fig_Area = "Area";
            Traslate_Suma_Perimetro = "Suma de Perimetros";
            Traslate_Suma_Area = "Suma de Area";
          

        }

       

        public override string TraducirNombreForma(string forma)
        {
            return "Cuadrado";
        }
    }
}
