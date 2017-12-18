using System;
using Xunit;
using Poker;

namespace Poker.Tests
{
    public class DeckTests
    {
        [Fact]
        public void Test1()
        {
			var deck = new Deck();

			Assert.NotNull(deck);
        }
    }
}
