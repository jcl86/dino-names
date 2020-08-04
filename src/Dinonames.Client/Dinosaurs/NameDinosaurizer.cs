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
            if (name.Length < 3)
            {
                return name;
            }

            string result = string.Join("", Words(name));
            return result.First().ToString().ToUpper() + result.Substring(1).ToLower();
        }

        private IEnumerable<string> Words(string name)
        {
            bool addPrefix = FiftyPercent();
            string prefix = "";
            if (addPrefix)
            {
                prefix = DinosaurNames.Prefixes.ElementAt(random.Next(0, DinosaurNames.Prefixes.Count() - 1));
                yield return prefix;
            }

            if (addPrefix && IsVowel(name.First().ToString()) && IsVowel(prefix.Last().ToString()))
            {
                name = name.Substring(1);
            }

            if (!addPrefix || FiftyPercent())
            {
                string suffix = DinosaurNames.Suffixes.ElementAt(random.Next(0, DinosaurNames.Suffixes.Count() - 1));
                if (IsVowel(name.First().ToString()) && IsVowel(suffix.Last().ToString()))
                {
                    name = name.Substring(0, name.Length - 1);
                }

                yield return name + suffix;
            }
            else yield return name;
        }

        private bool FiftyPercent() => random.Next(0, 2) == 0;
        private bool IsVowel(string character)
            => character.ToLower().Equals("a") ||
                character.ToLower().Equals("e") ||
                 character.ToLower().Equals("i") ||
                 character.ToLower().Equals("o") ||
                 character.ToLower().Equals("u");
    }
}
