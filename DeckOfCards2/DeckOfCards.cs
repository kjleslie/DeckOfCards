using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class DeckOfCards : Collection<Card>, IComparable<DeckOfCards>
    {
        public DeckOfCards()
        {
            for (var rank = Card.Rank.Ace; rank <= Card.Rank.King; rank++)
            {
                AddCard(rank, Card.Suit.Club);
                AddCard(rank, Card.Suit.Diamond);
                AddCard(rank, Card.Suit.Heart);
                AddCard(rank, Card.Suit.Spade);
            }
        }

        private void AddCard(Card.Rank rank, Card.Suit suit)
        {
            var card = new Card(rank, suit);
            Add(card);
        }

        private const int CardCount = 52;
        private const int NotEqual = 1;
        private const int Equal = 0;

        public int DeckCount => CardCount;

        public static DeckOfCards Shuffle(DeckOfCards unshuffledDeck)
        {
            var random1 = new Random();

            for (var index = 0; index < unshuffledDeck.Count; index++)
            {
                SwapCards(unshuffledDeck, index, random1.Next(CardCount));
            }
            return unshuffledDeck;
        }

        public int CompareTo(DeckOfCards otherDeck)
        {
            if (IsImproperDeckOfCards(otherDeck))
            {
                return NotEqual;
            }

            if (HasAllTheSameCards(otherDeck))
            {
                return Equal;
            }
            return NotEqual;
        }

        public static bool DecksAreInSameOrder(DeckOfCards deck1, DeckOfCards deck2)
        {
            if (EitherDeckIsNull(deck1, deck2))
            {
                return false;
            }
            return !deck1.Where((card1, index) => card1.CompareTo(deck2[index]) != 0).Any();
        }

        public static bool EitherDeckIsNull(DeckOfCards deck1, DeckOfCards deck2)
        {
            return deck1 == null || deck2 == null;
        }

        private bool HasAllTheSameCards(DeckOfCards otherDeck)
        {
            return otherDeck.Select(CardIsInDeck).All(foundIt => foundIt);
        }

        private bool CardIsInDeck(Card otherCard)
        {
            return this.Any(card => otherCard.CompareTo(card) == 0);
        }

        private bool IsImproperDeckOfCards(DeckOfCards otherDeck)
        {
            return otherDeck?.DeckCount != DeckCount;
        }

        public static DeckOfCards SwapCards(DeckOfCards deck, int position1, int position2)
        {
            var firstCard = deck[position1];
            deck[position1] = deck[position2];
            deck[position2] = firstCard;
            return deck;
        }
    }
}
