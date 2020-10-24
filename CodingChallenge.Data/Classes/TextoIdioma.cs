using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract  class TextoIdioma
    {
        public string Encabezado_ListaVacia;
        public string Traslate_Fig_Title;
        public string Encabezado;
        public string Traslate_Fig_Cantidad;
        public string Traslate_Fig_Perimetro;
        public string Traslate_Fig_Area;
        public string Traslate_Suma_Perimetro;
        public string Traslate_Suma_Area;
        public string NombredeFigura;

        public abstract string TraducirNombreForma(string forma);
    }
}
