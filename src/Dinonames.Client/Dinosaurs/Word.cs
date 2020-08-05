using System;
using System.Linq;

namespace Dinonames.Client
{
    public class Word
    {
        public const int MinLength = 2;

        private readonly string name;
        public bool IsEmpty => string.IsNullOrEmpty(name);

        public Word(string name)
        {
            this.name = name;

            if (name.Length <= MinLength)
            {
                throw new ArgumentOutOfRangeException($"{name} must be at least {MinLength} characters long");
            }
        }

        public bool BeginsWithVocal => name.First().IsVowel();
        public bool EndsWithVocal => name.Last().IsVowel();
        public bool BeginsWithConsonant => name.First().IsConsonant();
        public bool EndsWithConsonant => name.Last().IsConsonant();

        public string RemoveFirstCharacter() => name.Substring(1);

        public string RemoveLastCharacter() => name.Substring(0, name.Length - 1);

        public override string ToString() => name?.ToString() ?? "";
    }
}
