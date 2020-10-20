namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        public decimal baseinferior { get; set; }
        public decimal basesuperior { get; set; }
        public decimal altura { get; set; }
        public Trapecio(decimal lado, Idioma idioma) : base(lado,idioma)
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
            return (basesuperior + baseinferior) / 2 * altura;
        }

        public override string ToString()
        {
            return Texto.Traslate_Fig_Name(Idioma, this);
        }
    }
}