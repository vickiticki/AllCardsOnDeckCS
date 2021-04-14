using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static int findScore(string ihatethis)
        {
            int score = 0;

            switch (ihatethis)
            {
                case "Ac":
                    score = 14;
                    break;
                case "2 ":
                    score = 2;
                    break;
                case "3 ":
                    score = 3;
                    break;
                case "4 ":
                    score = 4;
                    break;
                case "5 ":
                    score = 5;
                    break;
                case "6 ":
                    score = 6;
                    break;
                case "7 ":
                    score = 7;
                    break;
                case "8 ":
                    score = 8;
                    break;
                case "9 ":
                    score = 9;
                    break;
                case "10":
                    score = 10;
                    break;
                case "Ja":
                    score = 11;
                    break;
                case "Qu":
                    score = 12;
                    break;
                case "Ki":
                    score = 13;
                    break;
                default:
                    Console.Write("wtf");
                    break;

            }
            return score;
        }
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


            Console.WriteLine("Dealing two hands");
            string firstCard = deck[0];

            string secondCard = deck[1];

            string thirdCard = deck[2];

            string fourthCard = deck[3];


            var playerHand = new List<string>() { firstCard, thirdCard };

            var opponentHand = new List<string>() { secondCard, fourthCard };

            Console.WriteLine();
            Console.WriteLine("Player's Hand");

            for (var playerCard = 0; playerCard < 2; playerCard++)
            {
                Console.WriteLine(playerHand[playerCard]);
            }

            Console.WriteLine();


            Console.WriteLine("Other Player's Hand");

            for (var opponentCard = 0; opponentCard < 2; opponentCard++)
            {
                Console.WriteLine(opponentHand[opponentCard]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("War!");

            Console.WriteLine("Player's card: " + firstCard);
            Console.WriteLine("Opponent's card: " + secondCard);



            var firstLetterA = firstCard[0];
            var secondLetterA = firstCard[1];
            string firstTwoLetters = $"{firstLetterA}{secondLetterA}";

            var playerScore = findScore(firstTwoLetters);

            var firstLetterB = secondCard[0];
            var secondLetterB = secondCard[1];
            string firstTwoLettersB = $"{firstLetterB}{secondLetterB}";

            var opponentScore = findScore(firstTwoLettersB);


            //testing
            // Console.WriteLine(playerScore);
            // Console.WriteLine(opponentScore);

            if (playerScore > opponentScore)
            {
                Console.WriteLine("Player wins!");

            }
            else if (playerScore < opponentScore)
            {
                Console.WriteLine("Player Loses!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }




        }
    }
}
