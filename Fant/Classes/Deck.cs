using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fant
{
    public class Deck
    {
        List<Card> _Deck = null;
        public List<Card> Cards
        {
            get
            {
                if (_Deck == null) _Deck = new List<Card>();
                return _Deck;
            }
            set
            {
                _Deck = value;
            }
        }
        public int Count { get { return _Deck == null ? 0 : _Deck.Count; } }

        public Deck()
        {

        }

        public Card GetLastCard()
        {
            return GetCard(_Deck.Count - 1);
        }

        public Card GetRandomCard()
        {
            Random rnd = new Random();
            int pickedIndex = rnd.Next(_Deck.Count);
            return GetCard(pickedIndex);
        }

        private Card GetCard(int num)
        {
            if (_Deck!=null && num < _Deck.Count)
            {
                Card picked = _Deck[num];
                _Deck.RemoveAt(num);
                return picked;
            }
            else return null;
        }

        public void Clear()
        {
            _Deck.Clear();
        }
    }
}
