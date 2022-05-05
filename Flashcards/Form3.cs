using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class LearnForm : Form
    {
        private cardSet currentDeck;
        private int noOfCards;
        private int currentCardIndex;


        private cardSet loadCardSet(cardSet emptyCardSet)
        {

            string fileName = Program.path + emptyCardSet.name + ".txt";
            cardSet fullCardSet = new cardSet(emptyCardSet.name);
            string [] lines = File.ReadAllLines(fileName);
            try
            {
                for (int i = 1; i < lines.Length; i += 2)
                {
                    Card _cardToAdd = new Card(lines[i - 1], lines[i]);
                    fullCardSet.addCard(_cardToAdd);
                }
            } catch (Exception ex)
            {
                string message = "Sorry, we encountered problem with the card file, does it have correct structure? Error: " + ex.Message;
                MessageBox.Show(message);
            }
            return fullCardSet;
            
            
        }
        public LearnForm(cardSet _currentDeck)
        {
            InitializeComponent();
            this.currentDeck = loadCardSet(_currentDeck);
            this.noOfCards = this.currentDeck.cards.Count;
            this.currentCardIndex = 0;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            labelCardSetTitle.Text = this.currentDeck.name;
            labelTerm.Text = this.currentDeck.cards[0].name;
            labelDescription.Text = this.currentDeck.cards[0].description;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelDescription.Visible = true;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.currentCardIndex == this.noOfCards - 1)
            {
                string text = "Congrats, you're done!";
                MessageBox.Show(text);
                buttonNext.Enabled = false;
                
            }
            else
            {
                this.currentCardIndex++;
                labelDescription.Visible = false;
                labelTerm.Text = currentDeck.cards[currentCardIndex].name;
                labelDescription.Text = currentDeck.cards[currentCardIndex].description;
            }


        }
    }
}
