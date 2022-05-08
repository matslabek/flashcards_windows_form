namespace Flashcards
{
    partial class EditSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardSetListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTerm = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelDefinition = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardSetListView
            // 
            this.cardSetListView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardSetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.cardSetListView.FullRowSelect = true;
            this.cardSetListView.GridLines = true;
            this.cardSetListView.HideSelection = false;
            this.cardSetListView.Location = new System.Drawing.Point(107, 125);
            this.cardSetListView.Name = "cardSetListView";
            this.cardSetListView.Size = new System.Drawing.Size(634, 253);
            this.cardSetListView.TabIndex = 0;
            this.cardSetListView.UseCompatibleStateImageBehavior = false;
            this.cardSetListView.View = System.Windows.Forms.View.Details;
            this.cardSetListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Term";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 474;
            // 
            // labelTerm
            // 
            this.labelTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(116, 30);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(45, 16);
            this.labelTerm.TabIndex = 1;
            this.labelTerm.Text = "Term :";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.Location = new System.Drawing.Point(552, 92);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(84, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelDefinition
            // 
            this.labelDefinition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDefinition.AutoSize = true;
            this.labelDefinition.Location = new System.Drawing.Point(233, 30);
            this.labelDefinition.Name = "labelDefinition";
            this.labelDefinition.Size = new System.Drawing.Size(81, 16);
            this.labelDefinition.TabIndex = 3;
            this.labelDefinition.Text = "Description :";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTerm.Location = new System.Drawing.Point(119, 49);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(100, 22);
            this.textBoxTerm.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescription.Location = new System.Drawing.Point(236, 49);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(107, 22);
            this.textBoxDescription.TabIndex = 5;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(167, 92);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(126, 27);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Add";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTerm);
            this.Controls.Add(this.labelDefinition);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.cardSetListView);
            this.Name = "EditSetForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.EditSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView cardSetListView;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelDefinition;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonEdit;
    }
}