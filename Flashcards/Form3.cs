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


        public LearnForm(cardSet _currentDeck)
        {
            InitializeComponent();
            this.currentDeck = _currentDeck;
            this.noOfCards = this.currentDeck.cards.Count;
            this.currentCardIndex = 0;
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            labelCardSetTitle.Text = this.currentDeck.name;
            labelTerm.Text = this.currentDeck.cards[0].name;
            labelDescription.Text = "???";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelDescription.Text = this.currentDeck.cards[currentCardIndex].description;
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
                labelDescription.Text = "???";
                labelTerm.Text = currentDeck.cards[currentCardIndex].name;
            }


        }
    }
}
