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
    public partial class DrawLotsControl : UserControl
    {
        private int PlayerNumber = -1;
        private BindingList<String> Names = null;

        public DrawLotsControl()
        {
            InitializeComponent();
        }

        private void btnPickPlayer_Click(object sender, EventArgs e)
        {
            if (Names.Count < 2)
            {
                //if(!DesignMode) MessageBox.Show("Need more Players!"); //TODO
                return;
            }
            Random rnd = new Random();
            if (listBox1.Items.Count > 5) listBox1.Items.RemoveAt(0);
            if (rnd.Next(100) % 2 == 0) PlayerNumber = 0;
            else PlayerNumber = 1;

            listBox1.Items.Add(Names[PlayerNumber]);
        }

        public void AddPlayer(String name)
        {
            Names.Add(name);
        }

        private void DrawLotsControl_Load(object sender, EventArgs e)
        {
            Names = new BindingList<String>();
            btnPickPlayer_Click(null, null);
        }
    }
}
