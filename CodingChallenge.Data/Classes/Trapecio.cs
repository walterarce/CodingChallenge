namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public decimal baseinferior { get; set; }
        public decimal basesuperior { get; set; }
        public decimal altura { get; set; }
        public Trapecio(decimal lado) : base(lado)
        {

        }

        public Trapecio(decimal _basesuperior, decimal _baseinferior, decimal _altura)
        {
            altura = _altura;
            baseinferior = _baseinferior;
            basesuperior = _basesuperior;
        }
        public override decimal CalcularArea()
        {
            return (basesuperior + baseinferior) / 2 * altura;
        }

        public override decimal CalcularPerimetro()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"Trapecio";
        }
    }
}