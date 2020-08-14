using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<string>() { "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts" };

            // var suit = new List<string>() { "Spades", "Hearts", "Clubs", "Diamonds" };
            // var rank = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            // for each(suit) { };
            // for each(rank){ };
            // deck.Add();

            // make n = number of cards in our deck
            var n = deck.Count();
            var randomNumberGenerator = new Random();


            // for rightIndex from n - 1 down to 1 do:
            for (var rightIndex = n - 1; rightIndex > 1; rightIndex--)
            {
                //   leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex
                var leftIndex = randomNumberGenerator.Next(rightIndex);

                //   Now swap the values at rightIndex and leftIndex by doing this:



                //  leftCard = the value from deck[rightIndex]
                var leftCard = deck[rightIndex];
                //     rightChard = the value from deck[leftIndex]
                var rightCard = deck[leftIndex];
                //     deck[rightIndex] = rightChard
                deck[rightIndex] = rightCard;
                //     deck[leftIndex] = leftCard
                deck[leftIndex] = leftCard;
            }

            // Output the first card in the deck
            // Output the second card in the deck
            Console.WriteLine($"Here is your first card {deck[0]}");
            Console.WriteLine($"Here is your second card {deck[1]}");


        }
    }
}
