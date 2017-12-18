using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand
    {
		private List<Card> cards { get; set; }
		public IReadOnlyList<Card> Cards => cards.AsReadOnly();

		public void Add(Card card)
		{
			this.cards.Add(card);
		}

		public void Remove(Card card)
		{
			this.cards.Remove(card);
		}
    }
}
