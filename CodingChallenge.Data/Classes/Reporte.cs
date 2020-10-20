using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.Globalization;
using System.Net.Mime;

namespace CodingChallenge.Data.Classes
{
    public  class Reporte
    {
      
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
              sb.Append(Texto.Encabezado_ListaVacia(idioma)) ;
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
               sb.Append(Texto.Encabezado(idioma));
                foreach (var forma in formas)
                {
                   
                    forma.area=forma.CalcularArea();
                    forma.perimetro = forma.CalcularPerimetro();
                    
                }

                var groupFormas =
                    from lstforma in formas
                    group lstforma by lstforma.GetType() into formaGrupo
                    select new
                    {
                        Stream = formaGrupo.Key,
                        SumaFigura= formaGrupo.Count(),
                        SumaArea = formaGrupo.Sum(x => x.area),
                        SumaPerimetro = formaGrupo.Sum(x => x.perimetro)
                    };

                foreach (var scr in groupFormas)
                {
                    sb.Append($"{Texto.Traslate_Fig_Title(idioma)}: {scr.Stream.Name}, {Texto.Traslate_Fig_Cantidad(idioma)}:{scr.SumaFigura}" +
                              $"{Texto.Traslate_Suma_Area(idioma)} : {scr.SumaArea:#.##} {Texto.Traslate_Suma_Perimetro(idioma)} : {scr.SumaPerimetro:#.##} <br/>");
                }

                // FOOTER
                 sb.Append($"</br>TOTAL:{formas.Count} , {Texto.Traslate_Fig_Title(idioma)}s <br/>");
                 sb.Append(Texto.Traslate_Fig_Perimetro(idioma)+ (formas.Sum(x=>x.perimetro)).ToString("#.##") + " ");
                 sb.Append(Texto.Traslate_Fig_Area(idioma) + (formas.Sum(x =>x.area)).ToString("#.##"));
            }

            return sb.ToString();
        }
   

    }
}