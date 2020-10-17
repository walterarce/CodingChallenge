/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {


        public readonly decimal _lado;

        public readonly decimal _altura;
        //private static FormaGeometrica FormaGeometrica;

        public FormaGeometrica Tipo { get; set; }


        public Idioma Idioma { get; set; }


        public FormaGeometrica(decimal lado)
        {
            _lado = lado;
            Tipo = this;
        }

        public FormaGeometrica(decimal lado, decimal altura)
        {
            _lado = lado;
            _altura = altura;
            Tipo = this;
        }

        protected FormaGeometrica()
        {
            
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}
