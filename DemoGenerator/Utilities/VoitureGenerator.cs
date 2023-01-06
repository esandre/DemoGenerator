using DemoGenerator.Domain;

namespace DemoGenerator.Utilities
{
    internal class VoitureGenerator
    {
        private readonly VoitureBuilder _prototypeBuilder;

        public VoitureGenerator()
        {
            _prototypeBuilder = new VoitureBuilder();
        }

        private VoitureGenerator(VoitureBuilder preconfigured)
        {
            _prototypeBuilder = preconfigured;
        }

        public IEnumerable<Voiture> Generate(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                yield return _prototypeBuilder.Build();
            }
        }

        public VoitureGenerator AyantUnePeinture(Func<PeintureBuilder, PeintureBuilder> configuration)
        {
            return new VoitureGenerator(_prototypeBuilder.AyantUnePeinture(configuration));
        }

        private class VoitureBuilder
        {
            private readonly Peinture _peinture = PeintureBuilder.Default;

            public VoitureBuilder()
            {
            }

            private VoitureBuilder(Peinture peinture)
            {
                _peinture = peinture;
            }

            public VoitureBuilder AyantUnePeinture(
                Func<PeintureBuilder, PeintureBuilder> configuration)
            {
                var peintureBuilder = new PeintureBuilder();
                configuration(peintureBuilder);
                var peinture = peintureBuilder.Build();

                return new VoitureBuilder(peinture);
            }

            public Voiture Build()
            {
                return new Voiture(_peinture);
            }
        }
    }
}
