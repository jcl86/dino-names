using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dinonames.Client
{
    public class NameDinosaurizer
    {
        private readonly Random random;

        public NameDinosaurizer(Random random)
        {
            this.random = random;
        }

        public string Dinosaurize(string name)
        {
            string prefix = "";
            if (FiftyPercent())
            {
                prefix = DinosaurNames.Prefixes.ElementAt(random.Next(0, DinosaurNames.Prefixes.Count()));
            }

            string suffix = "";
            if (FiftyPercent())
            {
                suffix = DinosaurNames.Suffixes.ElementAt(random.Next(0, DinosaurNames.Suffixes.Count()));
            }

            return new Name(prefix, name, suffix).ToString();
        }

        private bool FiftyPercent() => random.Next(0, 2) == 0;
    }
}
