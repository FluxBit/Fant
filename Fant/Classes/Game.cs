using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Fant
{
    public class Game
    {
        #region Sets definition
        Deck _WhiteSet = null;
        Deck _YellowSet = null;// = new List<Card>();
        Deck _PinkSet = null;// = new List<Card>();
        Deck _RedSet = null;// = new List<Card>();

        Deck deck = null;

        public Deck WhiteSet
        {
            get
            {
                if (_WhiteSet != null) return _WhiteSet;
                else _WhiteSet = LoadSet(Color.WHITE);
                return _WhiteSet;
            }
        }

        public Deck YellowSet
        {
            get
            {
                if (_YellowSet != null) return _YellowSet;
                else _YellowSet = LoadSet(Color.YELLOW);

                return _YellowSet;
            }
        }

        public Deck PinkSet
        {
            get
            {
                if (_PinkSet != null) return _PinkSet;
                else _PinkSet = LoadSet(Color.PINK);

                return _PinkSet;
            }
        }

        public Deck RedSet
        {
            get
            {
                if (_RedSet != null) return _RedSet;
                else _RedSet = LoadSet(Color.RED);

                return _RedSet;
            }
        }
        #endregion

        public delegate void CurrentCardChangedH(Card card);
        public event CurrentCardChangedH CurrentCardChanged;


        private static Game _Game = null;
        public static Game Instance
        {
            get
            {
                if (_Game == null) _Game = new Game();
                return _Game;
            }
        }

        private Card _Current = null;
        public Card Current
        {
            get
            {
                return _Current;
            }
            set
            {
                _Current = value;
                if (CurrentCardChanged != null)
                    CurrentCardChanged(value);
            }
        }

        public int Count
        {
            get
            {
                if (deck == null) return 0;
                return deck.Count;
            }
        }

        public Game()
        {
            Start();
        }

        private void bind()
        {

        }

        private Deck LoadSet(Color color)
        {
            SqlConnection con = new SqlConnection("Data Source=fluxbit.ru;Initial Catalog=CardDB;Persist Security Info=True;User ID=CardUser");
            try
            {
                con.Open();
            }
            catch (InvalidOperationException ex)
            {
                Debug.WriteLine("Не установить подключение");
                throw;
                return null;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            Deck Set = new Deck();

            String Color_Name = String.Empty;
            switch(color)
            {
                case Color.WHITE: Color_Name="White"; break;
                case Color.YELLOW: Color_Name="Yellow"; break;
                case Color.PINK: Color_Name="Pink"; break;
                case Color.RED: Color_Name="Red"; break;
            }
            cmd.CommandText="SELECT * FROM Card WHERE Color_Name=@Color_Name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Color_Name", Color_Name);
            try
            {
                SqlDataReader result = cmd.ExecuteReader(); //Загрузить все карты цвета @Color_Name
                while (result.Read()) //Cards without Tags
                {
                    int number = Int32.Parse(result["Number"].ToString());
                    String text = result["Text"].ToString();
                    Card newCard = new Card(number, color, text);
                    Set.Cards.Add(newCard);
                }
                result.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ошибка при загрузке карт " + Color_Name + " колоды");
                throw;
                return null;
            }

            cmd.CommandText = "SELECT Tag FROM CardTags WHERE Number=@Number AND Color_Name=@Color_Name;";
            for (int i = 0; i < 50; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Number", i+1);
                cmd.Parameters.AddWithValue("@Color_Name", Color_Name);
                SqlDataReader readed = cmd.ExecuteReader(); //Загрузить Теги для карты цвета @Color_Name и Номера @Number
                while (readed.Read())
                {
                    if(Set.Cards[i].number!=i+1)break; //проверка на соответствие позиции и номера карты
                    Set.Cards[i].TagList.Add(readed["Tag"].ToString());
                }
                readed.Close();
            }
            con.Close();
            return Set;
        }

        public void Start()
        {
            deck = new Deck();
            
            toGame(Color.WHITE);
        }

        public void toGame(Color col)
        {
            Deck Set = GetSet(col);

            for (int i = 0; i < deck.Count; i++)
            {
                if (deck.Cards[i].color < col)
                {
                    deck.Cards.RemoveAt(i);
                    i--;
                }
            }

            while (Set.Count > 0)
            {
                Random rnd = new Random();
                int i = rnd.Next(Set.Count);
                deck.Cards.Add(Set.Cards[i]);
                Set.Cards.RemoveAt(i);
            }
            Set.Clear();
        }

        private Deck GetSet(Color col)
        {
            Deck Set = null;

            switch (col)
            {
                case Color.WHITE: Set = WhiteSet; break;
                case Color.YELLOW: Set = YellowSet; break;
                case Color.PINK: Set = PinkSet; break;
                case Color.RED: Set = RedSet; break;
            }
            return Set;
        }

        public Card getCard()
        {
            return deck.GetRandomCard();
        }

        public void Change(int count, Color col)
        {
            int deleted = 0;
            int added = 0;
            Deck Set = GetSet(col+1);

            for (int i = 0; deleted < count && i < deck.Count; i++)
            {
                if (deck.Cards[i].color == col)
                {
                    deck.Cards.RemoveAt(i);
                    i--;
                    deleted++;
                }
            }
            for (added = 0; added < count; added++) //Добавление требуемого количества карт
            {
                Random rnd = new Random();
                int i = rnd.Next(Set.Count);
                deck.Cards.Add(Set.Cards[i]);
                Set.Cards.RemoveAt(i);
            }
        }

        public void GetPercent(out String white, out String yellow, out String pink, out String red)
        {
            int cwhite = 0, cyellow = 0, cpink = 0, cred = 0;
            for (int i = 0; i < deck.Count; i++)
            {
                switch (deck.Cards[i].color)
                {
                    case Color.WHITE: cwhite++; break;
                    case Color.YELLOW: cyellow++; break;
                    case Color.PINK: cpink++; break;
                    case Color.RED: cred++; break;
                }
            }

            white = String.Format("{0,0:P1}", (double)cwhite / deck.Count);
            yellow = String.Format("{0,0:P1}", (double)cyellow / deck.Count);
            pink = String.Format("{0,0:P1}", (double)cpink / deck.Count);
            red = String.Format("{0,0:P1}", (double)cred / deck.Count);
        }

        public int GetDeckCount()
        {
            return deck.Count;
        }
    }
}
