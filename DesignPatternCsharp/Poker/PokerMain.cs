using DesignPatternCsharp.Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	class PokerMain
	{
		static Deck deck = new Deck();
		public PokerMain()
		{

		}
		public static void Main(string [] args)
		{
			deck = new Deck();
			var ss = deck.ShuffleDecks();
		}
	}
}
