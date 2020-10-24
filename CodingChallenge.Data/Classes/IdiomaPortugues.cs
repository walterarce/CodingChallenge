using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class IdiomaPortugues:TextoIdioma
    {
        public IdiomaPortugues()
        {
            Encabezado_ListaVacia = "<h1>Lista vazia de formas!</h1>";
            Encabezado = "<h1>Relatório de forma</h1>";
            Traslate_Fig_Title = "Figura";
            Traslate_Fig_Cantidad = "Quantidade";
            Traslate_Fig_Perimetro = "Perímetro";
            Traslate_Fig_Area = "Area";
            Traslate_Suma_Perimetro = "Suma de Perimetros";
            Traslate_Suma_Area = "Suma de Area";
        }

        public IdiomaPortugues(string forma)
        {
            if (forma == "Cuadrado")
            { NombredeFigura = "Praça"; }
        }
    }
}
