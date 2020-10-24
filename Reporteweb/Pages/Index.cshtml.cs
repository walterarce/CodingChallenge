using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Reporteweb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var nuevoCuadrado = new Cuadrado(5, Idioma.Castellano);
            var nuevoCirculo = new Circulo(3, Idioma.Castellano);
            var nuevoTriangulo = new TrianguloEquilatero(4, 3);
            var nuevoCuadrado2 = new Cuadrado(2, Idioma.Castellano);
            var nuevoTriangulo2 = new TrianguloEquilatero(9, 3);
            var nuevoCirculo2 = new Circulo(2.7m, Idioma.Castellano);
            var nuevoTriangulo3 = new TrianguloEquilatero(4.2m, 5.6m);
            var nuevotrianguloc = new Triangulo(4.3m, Idioma.Castellano);
            FormaGeometrica[] listaRango =
            {
                nuevoCuadrado, nuevoCirculo, nuevoTriangulo
            };
            List<FormaGeometrica> listaFormaGeometricas = new List<FormaGeometrica>();
            listaFormaGeometricas.AddRange(listaRango);
          //  Response.BodyWriter(Reporte.Imprimir(listaFormaGeometricas, Idioma.Ingles));
        }
    }
}
