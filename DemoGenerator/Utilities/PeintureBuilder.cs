using System.Drawing;
using DemoGenerator.Domain;

namespace DemoGenerator.Utilities
{
    internal class PeintureBuilder
    {
        public static readonly Peinture Default = new PeintureBuilder().Build();

        private readonly Color _color;
        private readonly bool _métallisée;

        public PeintureBuilder()
        {
            _color = Color.White;
            _métallisée = false;
        }

        private PeintureBuilder(Color color, bool métallisée)
        {
            _color = color;
            _métallisée = métallisée;
        }

        public PeintureBuilder Rouge()
        {
            return new PeintureBuilder(Color.Red, _métallisée);
        }

        public PeintureBuilder Métallisée()
        {
            return new PeintureBuilder(_color, true);
        }

        public PeintureBuilder NonMétallisée()
        {
            return new PeintureBuilder(_color, false);
        }

        public Peinture Build()
        {
            return new Peinture() { Couleur = _color, Métallisée = _métallisée };
        }
    }
}
