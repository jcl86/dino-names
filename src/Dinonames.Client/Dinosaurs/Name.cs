namespace Dinonames.Client
{
    public class Name
    {
        private readonly Word prefix;
        private readonly Word name;
        private readonly Word suffix;

        public Name(string prefix, string name, string suffix)
        {
            this.prefix = new Word(prefix);
            this.name = new Word(name);
            this.suffix = new Word(suffix);
        }

        public override string ToString()
        {
            return $"{prefix}{CalculateName()}{CalculateSuffix()}";
        }

        private string CalculateName()
        {
            if (!prefix.IsEmpty && prefix.EndsWithVocal && name.BeginsWithVocal)
            {
                return name.RemoveFirstCharacter();
            }

            if (!prefix.IsEmpty && prefix.EndsWithConsonant && name.BeginsWithConsonant)
            {
                return name.RemoveFirstCharacter();
            }

            return name.ToString();
        }

        private string CalculateSuffix()
        {
            if (!suffix.IsEmpty && name.EndsWithVocal && suffix.BeginsWithVocal)
            {
                return suffix.RemoveFirstCharacter();
            }

            if (!suffix.IsEmpty && name.EndsWithConsonant && suffix.BeginsWithConsonant)
            {
                return suffix.RemoveFirstCharacter();
            }

            return suffix.ToString();
        }
    }
}
