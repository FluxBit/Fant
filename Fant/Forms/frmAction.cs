using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fant
{
    public partial class frmAction : Form
    {
        Card card = null;

        public frmAction(Card card)
        {
            InitializeComponent();
            bind(card);
        }
        private void bind(Card card)
        {
            this.card = card;
            if (this.card != null)
            {

            }
            else
            {
                btnToGame.Hide();
                btnPickCard.Hide();
            }
        }
        private void btnToGame_Click(object sender, EventArgs e)
        {
            Game.Instance.toGame(Game.Instance.Current.color + 1);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPickCard_Click(object sender, EventArgs e)
        {
            frmDeck f = new frmDeck();
            f.ShowDialog();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
