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
                selectSetComboBox.Items.Add(deck.Substring(0, deck.Length - 4));
            }
            
        }

        public void addItemToComboBox(string cardSet)
        {
            this.selectSetComboBox.Items.Add(cardSet);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectSetComboBox.SelectedIndex > -1)
            {
                cardSet selectedSet = new cardSet(selectSetComboBox.SelectedItem.ToString());

                LearnForm learnForm = new LearnForm(selectedSet);
                learnForm.Show();
            }
            else
            {
                MessageBox.Show("Select a set");
                labelSetNotSelected.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (newSetTextBox.Text == "")
            {
                string msg = "Please provide name.";
                MessageBox.Show(msg);
            }
            else if (this.cardDecks.Contains(newSetTextBox.Text))
            {
                string msg = "You already have a set with this name";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
