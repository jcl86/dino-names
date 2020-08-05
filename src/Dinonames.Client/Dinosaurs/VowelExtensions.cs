namespace Dinonames.Client
{
    public static class VowelExtensions
    {
        public static bool IsVowel(this string character)
        {
            return character.ToLower().Equals("a") ||
                       character.ToLower().Equals("e") ||
                        character.ToLower().Equals("i") ||
                        character.ToLower().Equals("o") ||
                        character.ToLower().Equals("u");
        }

        public static bool IsVowel(this char character)
        {
            return character.ToString().ToLower().Equals("a") ||
                       character.ToString().ToLower().Equals("e") ||
                        character.ToString().ToLower().Equals("i") ||
                        character.ToString().ToLower().Equals("o") ||
                        character.ToString().ToLower().Equals("u");
        }
    }
}
