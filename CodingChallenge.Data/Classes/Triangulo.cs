using System;

namespace CodingChallenge.Data.Classes
{
    public class Triangulo: FormaGeometrica
    {
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public Triangulo(decimal lado, Idioma idioma) : base(lado,idioma)
        {
        }

        public override string ToString()
        {
            return Texto.Traslate_Fig_Name(Idioma, this);
        }
    }
}