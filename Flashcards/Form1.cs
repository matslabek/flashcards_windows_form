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
    public partial class MenuForm : Form
    {
        private List<String> cardDecks;

        public MenuForm()
        {
            InitializeComponent();
            this.cardDecks = Directory.EnumerateFiles(Program.path)
                                       .Select(p => Path.GetFileName(p))
                                       .ToList();
            foreach (string deck in this.cardDecks)
            {
                // -4 to cut off file ext
                selectSetComboBox.Items.Add(deck.Substring(0, deck.Length - 4));
            }
            
        }

        private cardSet loadCardSet(cardSet emptyCardSet)
        {

            string fileName = Program.path + emptyCardSet.name + ".txt";
            cardSet fullCardSet = new cardSet(emptyCardSet.name);
            string[] lines = File.ReadAllLines(fileName);
            try
            {
                for (int i = 1; i < lines.Length; i += 2)
                {
                    Card _cardToAdd = new Card(lines[i - 1], lines[i]);
                    fullCardSet.addCard(_cardToAdd);
                }
            }
            catch (Exception ex)
            {
                string message = "Sorry, we encountered problem with the card file, does it have correct structure? Error: " + ex.Message;
                MessageBox.Show(message);
            }
            return fullCardSet;


        }

        public void addItemToComboBox(string cardSet)
        {
            this.selectSetComboBox.Items.Add(cardSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectSetComboBox.SelectedIndex > -1)
            {
                cardSet emptySelectedSet = new cardSet(selectSetComboBox.SelectedItem.ToString());

                cardSet selectedSet = loadCardSet(emptySelectedSet);

                LearnForm learnForm = new LearnForm(selectedSet);
                learnForm.Show();
            }
            else
            {
                MessageBox.Show("Select a set");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newSetTextBox.Text == "")
            {
                string msg = "Please provide a name.";
                MessageBox.Show(msg);
            }
            else if (this.cardDecks.Contains(newSetTextBox.Text))
            {
                string msg = "You've already created a set with this name!";
                MessageBox.Show(msg);
            } 
            else
            {
                bool alreadyThere = false;
                foreach (string item in this.cardDecks)//Iterate through each item.
                {
                    if (item.Contains(newSetTextBox.Text))
                    {
                            alreadyThere = true;
                    }
                }
                if (alreadyThere)
                {
                    string msg = "You already have a set with this name";
                    MessageBox.Show(msg);
                }
                else 
                {
                    cardSet newDeck = new cardSet(newSetTextBox.Text);
                    AddNewSetForm addNewSetForm = new AddNewSetForm(newDeck, this);
                    addNewSetForm.Show();
                }
            }

        }

        private void buttonEditDeck_Click(object sender, EventArgs e)
        {
            if (selectSetComboBox.SelectedIndex > -1)
            {
                cardSet emptySelectedSet = new cardSet(selectSetComboBox.SelectedItem.ToString());

                cardSet selectedSet = loadCardSet(emptySelectedSet);

                EditSetForm editSetForm = new EditSetForm(selectedSet);
                editSetForm.Show();
            }
            else
            {
                MessageBox.Show("Select a set");
            }
        }
    }
}
