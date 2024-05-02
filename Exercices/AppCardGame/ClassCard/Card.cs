using Newtonsoft.Json;
using ClassCard.Exceptions;
namespace ClassCard
{
    public class Card
    {
        private string name;
        private int power;
        private int defense;
        private string skill;
        private List<CardContainer> cardFamily;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }

        public Card()
        {
            this.name = "Placeholder";
            this.power = 6;
            this.defense = 6;
            this.skill = "Prendre de la place";
        }

        protected Card(string name, int power, int defense, string skill)
        {
            this.name = name;
            this.power = power;
            this.defense = defense;
            this.skill = skill;
        }

        public static Card CreateCard(string name, int power, int defense, string skill)
        {
            try
            {
                CardExceptions.NotValidCardValue(power, defense);
                return new Card(name, power, defense, skill);
            }
            catch(CardExceptions ex)
            {
                Console.WriteLine(ex.Message);
                return new Card();
            }
        }
  
        
        
    }
}