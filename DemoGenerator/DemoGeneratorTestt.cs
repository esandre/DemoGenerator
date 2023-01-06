using DemoGenerator.Utilities;

namespace DemoGenerator
{
    public class DemoGeneratorTest
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE 10 voitures, dont 7 ayant une peinture métallisée rouge
            var generator = new VoitureGenerator();
            var voituresNonMétallisées = generator
                .AyantUnePeinture(peinture => peinture.NonMétallisée())
                .Generate(3);

            static Func<PeintureBuilder, PeintureBuilder> MétalliséeRouge() 
                => peinture => peinture.Métallisée().Rouge();

            var voituresMétalliséesRouges =
                generator
                    .AyantUnePeinture(MétalliséeRouge())
                    .Generate(7);

            var voitures = voituresMétalliséesRouges.Concat(voituresNonMétallisées);

            // QUAND on calcule leur prix

            // ALORS il est de 1700€
        }
    }
}