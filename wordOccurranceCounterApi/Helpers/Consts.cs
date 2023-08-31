using System.Text.RegularExpressions;

namespace wordOccurranceCounterApi.Helpers
{
    public class Consts
    {
        public static readonly Regex notAlphbeticalChar = new Regex("[^a-zA-Z]"); //true if not within interval

        public static readonly Regex onlyAlphbeticalChar = new Regex("^[a-zA-Z]+$"); //true if string only uses alphabetical characters
    }
}
