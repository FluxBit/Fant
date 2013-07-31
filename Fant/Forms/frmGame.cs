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
    public partial class frmGame : Form
    {
        Game game = Game.Instance;

        public frmGame()
        {
            InitializeComponent();
        }

        private void RefreshStatistic()
        {
            if (game == null) return;
            String white = "", yellow = "", pink = "", red = "";
            game.GetPercent(out white, out yellow, out pink, out red);
            tslblStatistic.Text = "В колоде: " + game.GetDeckCount().ToString() + " | Белых: " + white + " | Желтых: " + yellow + " | Розовых: " + pink + " | Красных: " + red;
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            Game.Instance.Current = game.getCard();
            if (Game.Instance.Current == null)
            {
                MessageBox.Show("Игра окончена. Надеюсь, Вам понравилось ;)");
                Application.Exit();
                return;
            }
            ctrlCard.Card = Game.Instance.Current;

            btnComplete.Show();
            btnPick.Hide();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            drawLotsControl1.AddPlayer("Парень");
            drawLotsControl1.AddPlayer("Девушка");
            Game.Instance.CurrentCardChanged -= CurrentCardChanged;
            Game.Instance.CurrentCardChanged += CurrentCardChanged;
            RefreshStatistic();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Game.Instance.Current.Action();
            RefreshStatistic();
            btnPick.Show();
            btnComplete.Hide();
        }

        private void CurrentCardChanged(Card card)
        {
            ctrlCard.Card = card;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuInfo_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void mnuPositions_Click(object sender, EventArgs e)
        {
            frmPositions form = new frmPositions();
            form.Show();
        }
    }
}
