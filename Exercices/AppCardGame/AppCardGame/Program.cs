using ClassCard;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace AppCardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            using (StreamReader file = File.OpenText("../../../../ClassCard/data/cards.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                cards.Add(o2.ToObject<Card>());
            }


        }
    }
}