using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject.Assets
{
    public static class UniverseObjects
    {
        public static IList<SpaceTimeLocation> SpaceTimeLocations = new List<SpaceTimeLocation>()
        {

            new SpaceTimeLocation
            {
                Name = "Aion Base",
                SpaceTimeLocationID = 1,
                Description = "The Norlon Corporation's secret laboratory located deep underground, " +
                  " beneath a nondescript 7-11 on the south-side of Toledo, OH.",
                Accessable = true
            },

            new SpaceTimeLocation
            {
                Name = "Felandrian Plains",
                SpaceTimeLocationID = 3,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                  "Located just north of the equatorial line on the planet of Corlon, they" +
                  "provide excellent habitat for a rich ecosystem of flora and fauna.",
                Accessable = true
            },

            new SpaceTimeLocation
            {
                Name = "Felandrian Plains",
                SpaceTimeLocationID = 3,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                  "Located just north of the equatorial line on the planet of Corlon, they" +
                  "provide excellent habitat for a rich ecosystem of flora and fauna.",
                Accessable = true
            }

        };

        //public IList<SpaceTimeLocation> InitializeSpaceTimeLocations()
        //{
        //    IList<SpaceTimeLocation> STLocations = new List<SpaceTimeLocation>();

        //    STLocations.Add(new SpaceTimeLocation
        //    {
        //        Name = "TARDIS Base",
        //        SpaceTimeLocationID = 1,
        //        Description = "The Norlon Corporation's secret laboratory located deep underground, " +
        //          " beneath a nondescript 7-11 on the south-side of Toledo, OH.",
        //        Accessable = true
        //    });

        //STLocations.Add(new SpaceTimeLocation
        //    {
        //        Name = "Xantoria Market",
        //        SpaceTimeLocationID = 2,
        //        Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
        //                      "open market managed by the Xantorian Commerce Coop. It is a place " +
        //                      "where many races from various systems trade goods.",
        //        Accessable = true
        //    });

        //    STLocations.Add(new SpaceTimeLocation
        //    {
        //        Name = "Felandrian Plains",
        //        SpaceTimeLocationID = 3,
        //        Description = "The Felandrian Plains are a common destination for tourist. " +
        //          "Located just north of the equatorial line on the planet of Corlon, they" +
        //          "provide excellent habitat for a rich ecosystem of flora and fauna.",
        //        Accessable = true
        //    });

        //    return STLocations;
        //}
    }
}
