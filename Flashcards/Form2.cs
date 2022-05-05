using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class AddNewSetForm : Form
    {
        private cardSet currentDeck;
        private MenuForm mainForm;

        public AddNewSetForm(cardSet _currentDeck, MenuForm callingForm)
        {
            this.mainForm = callingForm as MenuForm;
            InitializeComponent();
            this.currentDeck = _currentDeck;
            newSetTitleLabel.Text = this.currentDeck.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (termTextBox.Text == "" || defTermBox.Text == "")
            {
                string msg = "Please provide both term and definition!";
                MessageBox.Show(msg);
            }
            else
            {
                //Transform newlines into spaces.
                string processedDescription = defTermBox.Text.Replace(System.Environment.NewLine, " ");
                Card addedCard = new Card(termTextBox.Text, processedDescription);
                this.currentDeck.addCard(addedCard);
                labelAddNew.Text = "Card " + addedCard.name + " has been added!";
                labelAddNew.Visible = true;
                termTextBox.Text = "";
                defTermBox.Text = "";
            }
        }
        
        private void SaveOn_Close(object sender, FormClosingEventArgs e)
        {
            string fileName = Program.path + this.currentDeck.name + ".txt";
            StreamWriter sw = new StreamWriter(fileName, append: true);
            foreach(Card card in this.currentDeck.cards)
            {
                sw.WriteLine(card.name);
                sw.WriteLine(card.description);
            }
            sw.Close();

        }

        private void AddNewSetForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(SaveOn_Close);
            this.mainForm.addItemToComboBox(this.currentDeck.name);
        }
    }
}
