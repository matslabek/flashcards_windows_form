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
        private int points = 0;


        public LearnForm(cardSet _currentSet)
        {
            InitializeComponent();
            this.currentSet = _currentSet;
            this.noOfCards = this.currentSet.cards.Count;
            this.currentCardIndex = 0;
        }

        private bool checkFinished()
        {
            if (this.currentCardIndex == this.noOfCards - 1)
            {
                string text = "Congrats, you're done! You scored " + this.points.ToString() + " out of " + this.noOfCards.ToString() + " points!";
                MessageBox.Show(text);
                labelCorrect.Visible = false;
                buttonX.Visible = false;
                buttonV.Visible = false;
                buttonGoAgain.Visible = true;
                return true;
            }
            return false;
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
            buttonV.Visible = true;
            buttonX.Visible = true;
            labelCorrect.Visible = true;
            buttonShow.Enabled = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (this.currentCardIndex == this.noOfCards - 1)
            {            }
            else
            {
                this.currentCardIndex++;
                labelDescription.Text = "???";
                labelTerm.Text = currentSet.cards[currentCardIndex].name;
                buttonShow.Enabled = true;
            }


        }

        private void buttonGoAgain_Click(object sender, EventArgs e)
        {
            this.currentCardIndex = 0;
            this.points = 0;
            this.currentSet.shuffle();
            labelDescription.Text = "???";
            buttonGoAgain.Visible= false;
            labelTerm.Text = currentSet.cards[currentCardIndex].name;
            buttonShow.Enabled= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.points++;
            labelCorrect.Visible = false;
            buttonX.Visible = false;
            buttonV.Visible = false;
            if (!this.checkFinished())
            {
                this.currentCardIndex++;
                labelDescription.Text = "???";
                labelTerm.Text = currentSet.cards[currentCardIndex].name;
                buttonShow.Enabled = true;
            }

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            labelCorrect.Visible = false;
            buttonX.Visible = false;
            buttonV.Visible = false;
            if (!this.checkFinished())
            {
                this.currentCardIndex++;
                labelDescription.Text = "???";
                labelTerm.Text = currentSet.cards[currentCardIndex].name;
                buttonShow.Enabled = true;
            }

        }
    }
}
