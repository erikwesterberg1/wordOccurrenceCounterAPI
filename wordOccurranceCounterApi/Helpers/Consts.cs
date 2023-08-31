using System.Text.RegularExpressions;

namespace wordOccurranceCounterApi.Helpers
{
    public class Consts
    {
        public static readonly Regex notAlphbeticalCharacter = new Regex("[^a-zA-Z]"); //true if one character is not within interval

        public static readonly Regex onlyAlphbeticalCharacters = new Regex("^[a-zA-Z]+$"); //true if string only uses alphabetical characters
    }
}
