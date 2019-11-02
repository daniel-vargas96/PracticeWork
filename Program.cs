using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to Virtual Blackjack");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Console.WriteLine("I will deal two cards to each player: first one card to each player and then the second card to each player");
            Console.WriteLine("There are a total of three players in this game");

            //dealing cards  
            Console.WriteLine("Dealing cards...");
            Console.WriteLine("Player 1...");
            Card card0 = deck.TakeTopCard();
           
            Console.ReadLine();

            Console.WriteLine("Player 2...");
            Card card1 = deck.TakeTopCard();


            Console.ReadLine();

            Console.WriteLine("Player 3...");
            Card card2 = deck.TakeTopCard();


            Console.ReadLine();

            Console.WriteLine("Second round of dealing...");

            Console.WriteLine("Player 1...");
            Card card3 = deck.TakeTopCard();


            Console.ReadLine();

            Console.WriteLine("Player 2...");
            Card card4 = deck.TakeTopCard();

            Console.ReadLine();

            Console.WriteLine("Player 3...");
            Card card5 = deck.TakeTopCard();

            Console.ReadLine();

            // flip all the cards over
            // print the cards for player 1
            Console.WriteLine("Flip your cards!");
            Console.ReadLine();
            Console.WriteLine("Player 1...");

            Console.WriteLine("First Card: " + card0.Rank + " of " + card0.Suit);
            Console.WriteLine("Second Card: " + card3.Rank + " of " + card3.Suit);

            Console.ReadLine();

            // print the cards for player 2
            Console.WriteLine("Player 2...");
            Console.WriteLine("First Card: " + card1.Rank + " of " + card1.Suit);
            Console.WriteLine("Second Card: " + card4.Rank + " of " + card4.Suit);

            Console.ReadLine();

            // print the cards for player 3
            Console.WriteLine("Player3...");
            Console.WriteLine("First Card: " + card2.Rank + " of " + card2.Suit);
            Console.WriteLine("Second Card: " + card5.Rank + " of " + card5.Suit);

            Console.ReadLine();

            Console.WriteLine("Winner Winner Chicken Dinner!");
            Console.ReadLine();

        }
    }
}
