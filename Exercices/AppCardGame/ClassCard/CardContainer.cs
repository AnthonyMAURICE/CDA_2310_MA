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
        private List<Card> cards;
        private List<CardFamily> family;

        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        public List<CardFamily> Family
        {
            get { return family; }
            set { family = value; }
        }

        public CardContainer()
        {
            this.cards = PrimaryDeck("../../../../ClassCard/data/cards.json", "cards");
            this.family = GenerateFamily("../../../../ClassCard/data/cardFamily.json", "family");
        }

        public List<Card> PrimaryDeck(string path, string data)
        {
            using (StreamReader file = File.OpenText(path))
            {
                string jsonstring = file.ReadToEnd();
                JObject obj = JObject.Parse(jsonstring);
                var jsonArray = JArray.Parse(obj[data].ToString());
                this.cards = jsonArray.ToObject<List<Card>>();
                
            }
            return this.cards;
        }

        public List<CardFamily> GenerateFamily(string path, string data)
        {
            using (StreamReader file = File.OpenText(path))
            {
                string jsonstring = file.ReadToEnd();
                JObject obj = JObject.Parse(jsonstring);
                var jsonArray = JArray.Parse(obj[data].ToString());
                this.family = jsonArray.ToObject<List<CardFamily>>();
                SetFamily();
            }
            return this.family;
        }

        public void SetFamily()
        {
            for(int i = 0; i < this.cards.Count; i++)
            {
                if (this.cards[i].Power < 5)
                {
                    this.cards[i].CardFamily = this.family[1];
                }
                else if (this.cards[i].Power == 5)
                {
                    this.cards[i].CardFamily = this.family[4];
                }
                else if (this.cards[i].Power == 6)
                {
                    this.cards[i].CardFamily = this.family[3];
                }
                else if (this.cards[i].Power == 7)
                {
                    this.cards[i].CardFamily = this.family[0];
                }
                else
                {
                    this.cards[i].CardFamily = this.family[2];
                }
            }
        }
    }
}
