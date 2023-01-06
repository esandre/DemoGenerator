using System.Drawing;

namespace DemoGenerator.Domain
{
    public class Peinture : IEstimable
    {
        public required Color Couleur { get; init; }
        public required bool Métallisée { get; init; }

        /// <inheritdoc />
        public decimal Prix => Métallisée ? 10 : 0;

        /// <inheritdoc />
        public override string ToString()
        {
            return Métallisée ? " ayant une peinture métallisée" : " peinte";
        }
    }
}
