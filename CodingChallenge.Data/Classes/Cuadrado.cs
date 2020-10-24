using System.Runtime.Remoting.Contexts;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public override decimal CalcularArea()
        {
            return _lado * _lado; 
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public Cuadrado(decimal lado) : base(lado)
        {
            Tipo = this;
        }

       
    }
}