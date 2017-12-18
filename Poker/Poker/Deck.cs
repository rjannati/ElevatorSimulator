using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace Poker
{
    public class Deck
    {
		private Stack<Card> cards;
		private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

		public Deck()
		{
			var listOfCards = GenerateDeck();
			Shuffle(listOfCards);
			cards = new Stack<Card>(listOfCards);
		}

		private static List<Card> GenerateDeck()
		{
			var cards = new List<Card>();
			var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
			var ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>();

			foreach (var suit in suits)
			{
				foreach(var rank in ranks)
				{
					cards.Add(new Card(suit, rank));
				}
			}
			return cards;
		}

		public void Shuffle(List<Card> cards)
		{
			for (int i = cards.Count -1; i >= 0; i--)
			{
				var randomNumber = GetRandomInt();

				var temp = cards[randomNumber];
				cards[randomNumber] = cards[i];
				cards[i] = temp;
			}
		}

		private static int GetRandomInt()
		{
			byte[] randomBytes = new byte[1];
			rngCsp.GetBytes(randomBytes);

			var randomNumber = Convert.ToInt32(randomBytes[0]) % 52;
			return randomNumber;
		}

		public Card Deal()
		{
			return cards.Pop();
		}
    }
}
