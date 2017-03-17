using DeckOfCards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsForCard
{
    [TestClass]
    public class UnitTestsForCard
    {
        [TestMethod]
        public void TestAceOfClubsIsLessThanAceOfSpades()
        {
            var aceOfClubs = new DeckOfCards.Card(Card.Rank.Ace, Card.Suit.Club);
            var aceOfSpades = new DeckOfCards.Card(Card.Rank.Ace, Card.Suit.Spade);

            Assert.AreNotEqual(aceOfSpades, aceOfClubs);
            Assert.IsTrue(condition: aceOfSpades > aceOfClubs);
        }

        [TestMethod]
        public void TestAceIsLessThanTwo()
        {
            var aceOfClubs = new DeckOfCards.Card(Card.Rank.Ace, Card.Suit.Club);
            var twoOfClubs = new DeckOfCards.Card(Card.Rank.Two, Card.Suit.Club);

            Assert.AreNotEqual(twoOfClubs, aceOfClubs);
            Assert.IsTrue(condition: twoOfClubs > aceOfClubs);
        }

        [TestMethod]
        public void TestToStringOverrideForAce()
        {
            var aceOfClubs = new Card(Card.Rank.Ace, Card.Suit.Club);
            Assert.AreEqual(expected: "Ace of Clubs", actual: aceOfClubs.ToString());
        }

        [TestMethod]
        public void TestToStringOverrideForKing()
        {
            var aceOfClubs = new Card(Card.Rank.King, Card.Suit.Spade);
            Assert.AreEqual(expected: "King of Spades", actual: aceOfClubs.ToString());
        }
    }
}
