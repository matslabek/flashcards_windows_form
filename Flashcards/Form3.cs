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
        private cardSet currentSet;
        private int noOfCards;
        private int currentCardIndex;


        public LearnForm(cardSet _currentSet)
        {
            InitializeComponent();
            this.currentSet = _currentSet;
            this.noOfCards = this.currentSet.cards.Count;
            this.currentCardIndex = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            labelCardSetTitle.Text = this.currentSet.name;
            if (this.noOfCards == 0)
            {
                return;
            }    
            labelTerm.Text = this.currentSet.cards[0].name;
            labelDescription.Text = "???";
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            labelDescription.Text = this.currentSet.cards[currentCardIndex].description;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.currentCardIndex == this.noOfCards - 1)
            {
                string text = "Congrats, you're done!";
                MessageBox.Show(text);
                buttonNext.Enabled = false;
                buttonGoAgain.Visible = true;
            }
            else
            {
                this.currentCardIndex++;
                labelDescription.Text = "???";
                labelTerm.Text = currentSet.cards[currentCardIndex].name;
            }


        }

        private void buttonGoAgain_Click(object sender, EventArgs e)
        {
            this.currentCardIndex = 0;
            this.currentSet.shuffle();
            buttonNext.Enabled = true;
            labelDescription.Text = "???";
            buttonGoAgain.Visible= false;
            labelTerm.Text = currentSet.cards[currentCardIndex].name;
        }
    }
}
