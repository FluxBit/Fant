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
    public partial class CardControl : UserControl
    {
        private Card _card;
        public Card Card
        {
            set
            {
                _card = value;
                bind();
            }
        }
        private void bind()
        {
            if (_card != null)
            {
                lblNum.Text = _card.number.ToString();
                lblText.Text = _card.text;
                switch (_card.color)
                {
                    case Color.WHITE: BackColor = System.Drawing.Color.White; ForeColor = System.Drawing.Color.Black; break;
                    case Color.YELLOW: BackColor = System.Drawing.Color.Gold; ForeColor = System.Drawing.Color.Black; break;
                    case Color.PINK: BackColor = System.Drawing.Color.HotPink; ForeColor = System.Drawing.Color.Black; break;
                    case Color.RED: BackColor = System.Drawing.Color.Red; ForeColor = System.Drawing.Color.Gold; break;
                }
            }
        }
        public CardControl()
        {
            InitializeComponent();
        }
    }
}
