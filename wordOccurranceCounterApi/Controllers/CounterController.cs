using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using System.Text;
using wordOccurranceCounterApi.Helpers;


namespace wordOccurranceCounterApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class CounterController : ControllerBase
    {
        private string inputString = "";
        private readonly ILogger<CounterController> _logger;

        public CounterController(ILogger<CounterController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult?> CountWordOccurrances()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    inputString = await reader.ReadToEndAsync();
                }

                if (string.IsNullOrEmpty(inputString))
                {
                    return BadRequest("No input, please provide a string");
                }
                if (!inputString.Contains(' '))
                {
                    return BadRequest("Bad input, please provide a delimiter between each word. (see documentation https://github.com/erikwesterberg1/wordOccurrenceCounterAPI)");
                }
                else
                {
                    //split words on delimiter "whitespace´" and store in array
                    string[] words = inputString.Split(' ');

                    //pass words to helper method to remove any non alphabetical characters
                    List<string> prettyWords = CollectionHelpers.PrettyfyCollection(words.ToList());

                    //instantiate dictionary to store word as key and the number of occurances as value 
                    Dictionary<string, int> keyValueWords = new();

                    //handle logic for counting each word occurance
                    foreach (string word in prettyWords)
                    {
                        string formattedWord = StringHelpers.FormatStringToAlphbetCharacters(word);
                        if (keyValueWords.ContainsKey(formattedWord))
                        {
                            keyValueWords[formattedWord]++;
                        }
                        else
                        {
                            keyValueWords.Add(formattedWord, 1);
                        }
                    }

                    //sort the dictionary
                    var sortedDictionary = CollectionHelpers.SortDictionaryOnDescendingValue(keyValueWords);
                    var topTenResult = CollectionHelpers.ReturnTopTenValues(sortedDictionary);
                    //_logger.LogInformation("Received data: {data}", topTenResult);
                    foreach (var item in topTenResult)
                    {
                        await Console.Out.WriteLineAsync($"{item.Key}: {item.Value}");
                    }

                    //pass the sorted to top10 helper and return
                    return Ok(topTenResult);
                }

                /*using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
                {
                    inputString = await reader.ReadToEndAsync();
                }*/
            }
            catch (Exception ex) {
                _logger.LogInformation("exception", ex.Message);
                return StatusCode(500);
            }

            

        }
    }
}
