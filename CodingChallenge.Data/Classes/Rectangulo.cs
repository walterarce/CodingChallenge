namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal altura { get; set; }

        public Rectangulo(decimal lado, decimal _altura)
        {
            altura = _altura;
        }
        public Rectangulo(decimal lado, Idioma idioma) : base(lado,idioma)
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

        public override string ToString()
        {
            return Texto.Traslate_Fig_Name(Idioma, this);
        }
    }
}