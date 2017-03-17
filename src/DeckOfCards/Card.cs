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

        private Rank _myRank;
        private Suit _mySuit;

        public Card(Rank myRank, Suit mySuit)
        {
            _myRank = myRank;
            _mySuit = mySuit;
        }

        public Suit mySuit
        {
            get
            {
                return _mySuit;
            }
        }

        public Rank MyRank
        {
            get
            {
                return _myRank;
            }
        }

        public int CompareTo(Card otherCard)
        {
            // If other is not a valid object reference, this instance is greater.
            if (otherCard == null) return 1;

            return MyRank.CompareTo(otherCard.MyRank);
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
    }
}
