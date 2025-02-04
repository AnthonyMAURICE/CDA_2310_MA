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
            CardContainer firstDeck = new CardContainer();

            for(int i = 0; i < firstDeck.Cards.Count; i++)
            {
                Console.WriteLine(firstDeck.Cards[i].CardFamily.Name + ", " + firstDeck.Cards[i].CardFamily.Elem + ", " + firstDeck.Cards[i].Name + ", " + firstDeck.Cards[i].Skill);
            }           
        }
    }
}