using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fant
{
    public partial class DeckControl : UserControl
    {
        private Deck _WhiteDeck = null;
        private Deck _YellowDeck = null;
        private Deck _PinkDeck = null;
        private Deck _RedDeck = null;
        
        public Deck WhiteDeck { set { _WhiteDeck = value; bind(); } }
        public Deck YellowDeck { set { _YellowDeck = value; bind(); } }
        public Deck PinkDeck { set { _PinkDeck = value; bind(); } }
        public Deck RedDeck { set { _RedDeck = value; bind(); } }

        private void bind()
        {
            if(_WhiteDeck!=null)
                lblWhiteCount.Text = _WhiteDeck.Count.ToString();
            if (_YellowDeck != null)
                lblYellowCount.Text = _YellowDeck.Count.ToString();
            if (_PinkDeck != null)
                lblPinkCount.Text = _PinkDeck.Count.ToString();
            if (_RedDeck != null)
                lblRedCount.Text = _RedDeck.Count.ToString();
        }

        public DeckControl()
        {
            InitializeComponent();
        }

        public void SetDecks(Deck white, Deck yellow, Deck pink, Deck red)
        {
            _WhiteDeck = white;
            _YellowDeck = yellow;
            _PinkDeck = pink;
            _RedDeck = red;
            bind();
        }

        private void pnlWhite_Click(object sender, EventArgs e)
        {
            if (_WhiteDeck != null)
            {
                Card picked = _WhiteDeck.GetRandomCard();
                if (picked != null)
                {
                    Game.Instance.Current = picked;
                    (Parent as Form).DialogResult = DialogResult.OK;
                }
                else (Parent as Form).DialogResult = DialogResult.Cancel;
            }
            else (Parent as Form).DialogResult = DialogResult.Cancel;
            
            (Parent as Form).Close();
        }

        private void pnlYellow_Click(object sender, EventArgs e)
        {
            if (_YellowDeck != null)
            {
                Card picked = _YellowDeck.GetRandomCard();
                if (picked != null) Game.Instance.Current = picked; //TODO condition like in white
                (Parent as Form).DialogResult = DialogResult.OK;
            }
            else (Parent as Form).DialogResult = DialogResult.Cancel;
            
            (Parent as Form).Close();
        }

        private void pnlPink_Click(object sender, EventArgs e)
        {
            if (_PinkDeck != null)
            {
                Card picked = _PinkDeck.GetRandomCard();
                if (picked != null) Game.Instance.Current = picked;
                (Parent as Form).DialogResult = DialogResult.OK;
            }
            else (Parent as Form).DialogResult = DialogResult.Cancel;
            
            (Parent as Form).Close();
        }

        private void pnlRed_Click(object sender, EventArgs e)
        {
            if (_RedDeck != null)
            {
                Card picked = _RedDeck.GetRandomCard();
                if (picked != null) Game.Instance.Current = picked;
                (Parent as Form).DialogResult = DialogResult.OK;
            }
            else (Parent as Form).DialogResult = DialogResult.Cancel;
            
            (Parent as Form).Close();
        }

        private void DeckControl_Load(object sender, EventArgs e)
        {
            Game game = Game.Instance;
            SetDecks(game.WhiteSet, game.YellowSet, game.PinkSet, game.RedSet);
        }
    }
}
