namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal altura { get; set; }

        public Rectangulo(decimal lado, decimal _altura)
        {
            altura = _altura;
        }
        public Rectangulo(decimal lado) : base(lado)
        {
        }

        public override decimal CalcularArea()
        {
            return _lado * altura;
        }

        public override decimal CalcularPerimetro()
        {
            return (_lado + _altura) + (_lado + _altura);
        }

      
    }
}