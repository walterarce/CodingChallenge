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
            var providerIdioma = new ProviderIdioma();
            if (!formas.Any())
            {
              sb.Append(providerIdioma.GetTextoIdioma(idioma)) ;
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
               sb.Append(providerIdioma.GetTextoIdioma(idioma).Encabezado);
              

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
                    sb.Append($"{providerIdioma.GetTextoIdioma(idioma).Traslate_Fig_Title}: {providerIdioma.GetTextoIdioma(idioma, scr.Stream.Name).NombredeFigura }, " +
                              $"{providerIdioma.GetTextoIdioma(idioma).Traslate_Fig_Cantidad}:{scr.SumaFigura}" +
                              $"{providerIdioma.GetTextoIdioma(idioma).Traslate_Suma_Area} : {scr.SumaArea:#.##} " +
                              $"{providerIdioma.GetTextoIdioma(idioma).Traslate_Suma_Perimetro} : {scr.SumaPerimetro:#.##} <br/>");
                }

                // FOOTER
                 sb.Append($"</br>TOTAL:{formas.Count} , {providerIdioma.GetTextoIdioma(idioma).Traslate_Fig_Title}s <br/>");
                 sb.Append(providerIdioma.GetTextoIdioma(idioma).Traslate_Fig_Perimetro+ (formas.Sum(x=>x.CalcularPerimetro())).ToString("#.##") + " ");
                 sb.Append(providerIdioma.GetTextoIdioma(idioma).Traslate_Fig_Area + (formas.Sum(x =>x.CalcularArea())).ToString("#.##"));
            }

            return sb.ToString();
        }
   

    }
}