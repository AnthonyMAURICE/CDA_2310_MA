using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCard
{
    public class CardContainer
    {
        public List<Card> cards;
        public List<CardFamily> family;

        public CardContainer()
        {
            this.cards = new List<Card>();
            this.family = new List<CardFamily>();
        }

        public List<Card> PrimaryDeck()
        {
            using (StreamReader file = File.OpenText("../../../../ClassCard/data/cards.json"))
            {
                string jsonstring = file.ReadToEnd();
                JObject obj = JObject.Parse(jsonstring);
                var jsonArray = JArray.Parse(obj["cards"].ToString());
                this.cards = jsonArray.ToObject<List<Card>>();
            }
            return this.cards;
        }

        public List<CardFamily> GenerateFamily()
        {
            using (StreamReader file = File.OpenText("../../../../ClassCard/data/cardFamily.json"))
            {
                string jsonstring = file.ReadToEnd();
                JObject obj = JObject.Parse(jsonstring);
                var jsonArray = JArray.Parse(obj["family"].ToString());
                this.family = jsonArray.ToObject<List<CardFamily>>();
            }
            return this.family;
        }


    }
}
