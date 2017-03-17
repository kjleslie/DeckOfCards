using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card : IComparable<Card>
    {
        public enum Suit
        {
            Club = 1,
            Diamond,
            Heart,
            Spade
        }

        public enum Rank
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }

        private Rank _rank;
        private Suit _suit;

        public Card(Rank myRank, Suit mySuit)
        {
            _rank = myRank;
            _suit = mySuit;
        }

        public Suit mySuit => _suit;

        public Rank myRank => _rank;

        public int CompareTo(Card otherCard)
        {
            // If other is not a valid object reference, this instance is greater.
            if (otherCard == null) return 1;

            if (myRank.CompareTo(otherCard.myRank) == 0)
            {
                return mySuit.CompareTo(otherCard.mySuit);
            }
            return myRank.CompareTo(otherCard.myRank);
        }

        // Define the is greater than operator.
        public static bool operator >(Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }

        // Define the is less than operator.
        public static bool operator <(Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        public override string ToString()
        {
            return $"{_rank} of {_suit}s";
        }
    }
}
