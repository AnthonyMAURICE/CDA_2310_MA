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

        public static string PollResult(PollResults _results) // méthode retournant les deux couleurs plébiscitées sous forme de chaine de caractères
        {
            SortedDictionary<string, int> pollResultsList = new();
            string resultsOfPoll = "";

            var occurences = _results.results.GroupBy(i => i); // liste récupérée et stockée dans une variable sous forme de paires clés/valeurs

            foreach (var data in occurences) // pour boucler dessus
            {
                pollResultsList.Add(data.Key, data.Count()); // et mettre dans un Dictionaire les paires clé/occurrences 
                //Console.WriteLine(data.Key + " " + data.Count()); //servait à contrôler les résultats
            }

            foreach (var item in pollResultsList.OrderByDescending(r => r.Value).Take(2)) // pour finalement les mettre en ordre descendant et récupérer les deux premières valeurs
            {
                resultsOfPoll += $"{item.Key} "; // pour les stocker dans une chaine de caractères
            }

            return resultsOfPoll; // et au final, la retourner
        }

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
            Console.WriteLine(PollResults.PollResult(results));
        }

        
    }
}