namespace DemoGenerator.Domain
{
    public class Voiture : IEstimable
    {
        private readonly Peinture _peinture;

        public Voiture(Peinture peinture)
        {
            _peinture = peinture;
        }

        /// <inheritdoc />
        public decimal Prix => 100 + _peinture.Prix;

        /// <inheritdoc />
        public override string ToString()
        {
            return "Voiture" + _peinture.ToString();
        }
    }
}