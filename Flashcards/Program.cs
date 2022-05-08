using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public class Card
    {
        public string name { get; set; }
        public string description { get; set; }

        public Card(string _name, string _description)
        {
            name = _name;
            description = _description;
        }

    }

    public class cardSet
    {
        public List<Card> cards { get; set;}
        public string name { get; set;}
        public cardSet(string _name)
        {
            this.cards = new List<Card>();
            this.name = _name;
        }

        public void addCard(Card card)
        {
            this.cards.Add(card);
        }

        public void shuffle()
        {
            Random rand = new Random();
            int n = this.cards.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                var c = this.cards[k];
                this.cards[k] = this.cards[n];
                this.cards[n] = c;
            }
        }

    }

    internal static class Program
    {
        public static string path = @"C:\Users\user\source\repos\Flashcards\Flashcards\decks\";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
