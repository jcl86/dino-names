namespace Dinonames.Client
{
    public static class ConsonantExtensions
    {
        public static bool IsConsonant(this string character) => !character.IsVowel();

        public static bool IsConsonant(this char character) => !character.IsVowel();
    }
}
