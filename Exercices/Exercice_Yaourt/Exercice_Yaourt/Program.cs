using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Exercice_Yaourt
{
    public class PollResults
    {
        public List<string> results { get; set; }
    }
        
 
    internal class Program
    {

        private static HttpClient client = new()
        {
            BaseAddress = new Uri(" https://api.devoldere.net/polls/yoghurts/")
        };

        static void Main(string[] args)
        {
            ProcessRepositoriesAsync(client).Wait();   
        }

        static async Task ProcessRepositoriesAsync(HttpClient client)
        {
            var json = await client.GetStringAsync(client.BaseAddress);
            string colorFile = json.ToString();
            PollResults results = JsonSerializer.Deserialize<PollResults>(colorFile);
            Console.WriteLine(PollResult(results));
        }

        public static string PollResult(PollResults _results)
        {
            List<string> poll = new();
            SortedDictionary<string, int> pollResultsList = new();
            string resultsOfPoll = "";
            foreach (var result in _results.results)
            {
                poll.Add(result.ToString());
            }
            
            var occurences = poll.GroupBy(i => i);
            
            foreach(var data in occurences)
            {
                pollResultsList.Add(data.Key, data.Count());
                Console.WriteLine(data.Key + " " + data.Count());
            }

            foreach (var item in pollResultsList.OrderByDescending(r => r.Value).Take(2))
            {
                resultsOfPoll += $"{item.Key} ";
            }

            return resultsOfPoll;
        }
    }
}