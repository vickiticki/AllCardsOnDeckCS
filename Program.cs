﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            var deck = new List<string>();

            var cardValues = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // make hearts

            int cardValue = 0;

            while (cardValue < 13)
            {
                string nameOfValue = cardValues[cardValue];
                deck.Add(nameOfValue + " of Hearts");
                cardValue++;
            }

            // make diamonds

            cardValue = 0;


            while (cardValue < 13)
            {
                string nameOfValue = cardValues[cardValue];
                deck.Add(nameOfValue + " of Diamonds");
                cardValue++;
            }

            // make spades

            cardValue = 0;


            while (cardValue < 13)
            {
                string nameOfValue = cardValues[cardValue];
                deck.Add(nameOfValue + " of Spades");
                cardValue++;
            }

            // make clubs

            cardValue = 0;


            while (cardValue < 13)
            {
                string nameOfValue = cardValues[cardValue];
                deck.Add(nameOfValue + " of Clubs");
                cardValue++;
            }

            // test deck

            // for (var deckFace = 0; deckFace < 52; deckFace++)
            // {
            //     Console.WriteLine(deck[deckFace]);

            // }

            int numberOfCards = deck.Count;


            for (int rightIndex = numberOfCards - 1; rightIndex > -1; rightIndex--)
            {
                string rightCard = deck[rightIndex];

                var randomNumberGenerator = new Random();

                var leftIndex = randomNumberGenerator.Next(rightIndex);

                string leftCard = deck[leftIndex];

                deck[rightIndex] = leftCard;

                deck[leftIndex] = rightCard;

            }

            // test shuffle 
            // for (var deckFace = 0; deckFace < 52; deckFace++)
            // {
            //     Console.WriteLine(deck[deckFace]);

            // }

            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);

            string firstCard = deck[0];

            string secondCard = deck[1];

            Console.WriteLine(firstCard);
            Console.WriteLine(secondCard);






        }
    }
}
