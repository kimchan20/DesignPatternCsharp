using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp.Poker
{
	public class Suit
	{
		public string[] clubs = { "cAce", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "cJack", "cQueen", "cKing" };
		public string[] diamonds = { "dAce", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "d10", "dJack", "dQueen", "dKing" };
		public string[] hearts = { "hAce", "h2", "h3", "h4", "h5", "h6", "h7", "h8", "h9", "h10", "hJack", "hQueen", "hKing" };
		public string[] spades = { "sAce", "s2", "s3", "s4", "s5", "s6", "c7", "s8", "s9", "s10", "sJack", "sQueen", "sKing" };

		public Suit() { }
		public Suit(string[] clubs, string[] diamonds, string[] hearts, string[] spades)
		{
			this.clubs = clubs;
			this.diamonds = diamonds;
			this.hearts = hearts;
			this.spades = spades;
		}
	}
	public class Deck
	{
		private const int size = 51;
		public string[] deckCard = new string[size];
		private readonly Suit suit;
		private readonly Random random;
		public List<String> shuffledDecks = new List<String>();
		public Deck()
		{
			suit = new Suit();
			random = new Random();
		}
		public List<string[]> DrawDecks()
		{
			var suits = new List<string[]>() { suit.clubs, suit.diamonds, suit.hearts, suit.spades };
			return suits;
		}
		public List<String> ShuffleDecks()
		{
			while (shuffledDecks.Count < 52)
			{
				var randSuit = random.Next(0, 3);
				var randSuitDeck = random.Next(0, 12);

				var selSuit = DrawDecks()[randSuit];
				var selSuitDeck = selSuit[randSuitDeck];
				if (shuffledDecks.Count() == 0)
					shuffledDecks.Add(selSuitDeck);
				else
					shuffledDecks.Add(selSuitDeck);
			}

			return shuffledDecks.Distinct().ToList();
		}
	}
}
