using System.Text.RegularExpressions;

namespace wordOccurranceCounterApi.Helpers
{
    public class StringHelpers
    {
        public static string FormatStringToAlphbetCharacters(string argument) {
            if (string.IsNullOrEmpty(argument))
            {
                return argument;
            }
            else
            {
                //remove any odd characters from word
                return Consts.notAlphbeticalCharacter.Replace(argument,"");
            }
        }
    }
   
}
