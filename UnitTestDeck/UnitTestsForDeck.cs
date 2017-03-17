using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeckOfCards;

namespace UnitTestsForDeck
{
    [TestClass]
    public class UnitTestsForDeck
    {
        [TestMethod]
        public void TestForIdenticalDecks()
        {
            var deckOfCards1 = new DeckOfCards.DeckOfCards();
            var deckOfCards2 = new DeckOfCards.DeckOfCards();

            Assert.IsTrue(deckOfCards1.CompareTo(deckOfCards2) == 0);
        }

        [TestMethod]
        public void TestForSwappedCards()
        {
            var deckOfCards = new DeckOfCards.DeckOfCards();
            const int position1 = 0;
            const int position2 = 1;
            var firstCard = deckOfCards[position1];
            var secondCard = deckOfCards[position2];

            deckOfCards = DeckOfCards.DeckOfCards.SwapCards(deckOfCards, position2, position1);
            Assert.IsTrue(deckOfCards[position1] == secondCard);
            Assert.IsTrue(deckOfCards[position2] == firstCard);
        }

        [TestMethod]
        public void TestForShuffledDeckNotInSameOrderAsSortedDeck()
        {
            var deckOfCardsShuffled = DeckOfCards.DeckOfCards.Shuffle(new DeckOfCards.DeckOfCards());
            var deckOfCardsUnshuffled = new DeckOfCards.DeckOfCards();

            Assert.IsFalse(DeckOfCards.DeckOfCards.DecksAreInSameOrder(deckOfCardsShuffled, deckOfCardsUnshuffled));
        }

        [TestMethod]
        public void TestForSortedDeck()
        {
            var deckOfCardsSorted1 = new DeckOfCards.DeckOfCards();
            var deckOfCardsSorted2 = new DeckOfCards.DeckOfCards();

            Assert.IsTrue(DeckOfCards.DeckOfCards.DecksAreInSameOrder(deckOfCardsSorted1, deckOfCardsSorted2));
        }

        [TestMethod]
        public void TestEitherDeckIsNull()
        {
            var deckOfCardsSorted1 = new DeckOfCards.DeckOfCards();
            var deckOfCardsSorted2 = new DeckOfCards.DeckOfCards();

            deckOfCardsSorted2 = null;

            Assert.IsTrue(DeckOfCards.DeckOfCards.EitherDeckIsNull(deckOfCardsSorted1, deckOfCardsSorted2));

            deckOfCardsSorted2 = new DeckOfCards.DeckOfCards();
            deckOfCardsSorted1 = null;

            Assert.IsTrue(DeckOfCards.DeckOfCards.EitherDeckIsNull(deckOfCardsSorted1, deckOfCardsSorted2));

            deckOfCardsSorted1 = new DeckOfCards.DeckOfCards();

            Assert.IsFalse(DeckOfCards.DeckOfCards.EitherDeckIsNull(deckOfCardsSorted1, deckOfCardsSorted2));
        }
    }
}
