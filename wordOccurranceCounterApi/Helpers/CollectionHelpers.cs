using System.Text.RegularExpressions;

namespace wordOccurranceCounterApi.Helpers
{
    public class CollectionHelpers
    {
        //removes any odd characters from each word and formats them to lowercase.
        public static List<string> PrettyfyCollection(List<string> list)
        {
            List<string> prettyList = new();
            foreach (var word in list)
            {
                string temp = StringHelpers.FormatStringToAlphbetCharacters(word.ToLower());
                if (Consts.onlyAlphbeticalCharacters.IsMatch(temp))
                {
                    prettyList.Add(temp); 
                }
            }
            return prettyList;
        }

        //returns a sorted dictionary by the greatest key value
        public static Dictionary<string, int> SortDictionaryOnDescendingValue(Dictionary<string, int> keyValueWords) => keyValueWords.OrderByDescending(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

        //returns the 10 words that occur the most 
        public static Dictionary<string, int> ReturnTopTenValues(Dictionary<string, int> keyValuePairs) => keyValuePairs.Take(10).ToDictionary(pair => pair.Key, pair => pair.Value);
    }
}
