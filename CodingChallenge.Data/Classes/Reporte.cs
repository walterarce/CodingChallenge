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
              sb.Append(ProviderIdioma.GetTextoIdioma(idioma)) ;
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
               sb.Append(ProviderIdioma.GetTextoIdioma(idioma).Encabezado);
              

                var groupFormas =
                    from lstforma in formas
                    group lstforma by lstforma.GetType() into formaGrupo
                    select new
                    {
                        Stream = formaGrupo.Key,
                        SumaFigura= formaGrupo.Count(),
                        SumaArea = formaGrupo.Sum(x => x.CalcularArea()),
                        SumaPerimetro = formaGrupo.Sum(x => x.CalcularPerimetro())
                    };

                foreach (var scr in groupFormas)
                {
                    sb.Append($"{ProviderIdioma.GetTextoIdioma(idioma).Traslate_Fig_Title}: {ProviderIdioma.GetTextoIdioma(idioma).TraducirNombreForma(scr.Stream.Name) }, " +
                              $"{ProviderIdioma.GetTextoIdioma(idioma).Traslate_Fig_Cantidad}:{scr.SumaFigura}" +
                              $"{ProviderIdioma.GetTextoIdioma(idioma).Traslate_Suma_Area} : {scr.SumaArea:#.##} " +
                              $"{ProviderIdioma.GetTextoIdioma(idioma).Traslate_Suma_Perimetro} : {scr.SumaPerimetro:#.##} <br/>");
                }

                // FOOTER
                 sb.Append($"</br>TOTAL:{formas.Count} , {ProviderIdioma.GetTextoIdioma(idioma).Traslate_Fig_Title}s <br/>");
                 sb.Append(ProviderIdioma.GetTextoIdioma(idioma).Traslate_Fig_Perimetro+ (formas.Sum(x=>x.CalcularPerimetro())).ToString("#.##") + " ");
                 sb.Append(ProviderIdioma.GetTextoIdioma(idioma).Traslate_Fig_Area + (formas.Sum(x =>x.CalcularArea())).ToString("#.##"));
            }

            return sb.ToString();
        }
   

    }
}