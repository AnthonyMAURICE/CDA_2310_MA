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
            firstDeck.PrimaryDeck();
            
            Console.WriteLine(firstDeck.cards[1].Name);

        }
    }
}