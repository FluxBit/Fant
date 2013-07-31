using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fant
{
    public enum Color { WHITE, YELLOW, PINK, RED, BLACK }
    //public enum Player { Guy, Girl }

    public class Card
    {
        public static String[] WhiteTexts = { "", "", "" };
        public int number;
        public String text = null;
        public Color color;
        public List<String> TagList = null;

        public Boolean HasAction
        {
            get
            {
                foreach(String tag in TagList)
                {
                    switch (tag)
                    {
                        case "togame": return true;
                        case "choice": return true;
                    }
                }
                return false;
            }
        }

        private Card()
        {

        }

        public Card(String row)
        {
            Parse(row);
        }

        public Card(int num, Color col, String text)
        {
            number = num;
            color = col;
            TagList = new List<String>();
            this.text = text;
            this.text = "        " + this.text.Replace("@", "\n        \t");
        }

        public static Card Parse(String row)
        {
            Card ans = new Card();
            return ans;
        }

        public void Action()
        {
            foreach (String tag in TagList)
            {
                try
                {
                    int count = Int32.Parse(tag);
                    if (count > 0) Game.Instance.Change(count, color);
                }
                catch (Exception ex) { }
            }
            if (HasAction)
            {
                frmAction f = new frmAction(this);
                f.ShowDialog();
            }
        }
    }
}
