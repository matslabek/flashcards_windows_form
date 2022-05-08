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
    public partial class EditSetForm : Form
    {
        private cardSet currentSet;
        
        public EditSetForm(cardSet _currentCardSet)
        {
            InitializeComponent();
            this.currentSet = _currentCardSet;

            cardSetListView.Sorting = SortOrder.Ascending;
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EditSetForm_Load(object sender, EventArgs e)
        {
            foreach (var card in this.currentSet.cards)
            {
                ListViewItem item = new ListViewItem(card.name);
                item.SubItems.Add(card.description);
                cardSetListView.Items.Add(item);
            }

            this.FormClosing += new FormClosingEventHandler(saveEditedSet);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (cardSetListView.Items.Count > 0)
                cardSetListView.Items.Remove(cardSetListView.SelectedItems[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTerm.Text) || string.IsNullOrEmpty(textBoxDescription.Text))
                return;
            ListViewItem selectedTerm = new ListViewItem(textBoxTerm.Text);
            selectedTerm.SubItems.Add(textBoxDescription.Text);
            cardSetListView.Items.Add(selectedTerm);
            textBoxTerm.Clear();
            textBoxDescription.Clear();
                            
        }


        private void saveEditedSet(object sender, FormClosingEventArgs e)
        {
            string fileName = Program.path + this.currentSet.name + ".txt";
            StreamWriter sw = new StreamWriter(fileName);
            ListView.ListViewItemCollection cards = this.cardSetListView.Items;

            foreach (ListViewItem item in cards)
            {
                sw.WriteLine(item.Text);
                sw.WriteLine(item.SubItems[1].Text);
            }
            sw.Close();
        }

    }
}
