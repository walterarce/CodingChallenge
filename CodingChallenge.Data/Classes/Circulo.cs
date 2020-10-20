using System;
using System.Runtime.CompilerServices;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }
        
        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public Circulo(decimal lado, Idioma idioma) : base(lado, idioma)
        {
        }

        public override string ToString()
        {
            return Texto.Traslate_Fig_Name(Idioma,this);
        }
    }
}