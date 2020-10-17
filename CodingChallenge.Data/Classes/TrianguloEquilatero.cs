namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public decimal altura { get; set; }

        public decimal Base { get; set; }
        
        public TrianguloEquilatero(decimal lado) : base(lado)
        {
        }

        public TrianguloEquilatero(decimal _lado, decimal _base)
        {
            altura = _lado;
            Base = _base;
        }
        public override decimal CalcularArea()
        {
            return altura * Base / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return altura + altura + altura;
        }
    }
}