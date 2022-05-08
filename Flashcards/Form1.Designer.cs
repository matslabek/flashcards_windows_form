namespace Flashcards
{
    partial class MenuForm
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
            this.buttonCreateSet = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.newSetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditDeck = new System.Windows.Forms.Button();
            this.selectSetComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCreateSet
            // 
            this.buttonCreateSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateSet.Location = new System.Drawing.Point(641, 419);
            this.buttonCreateSet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateSet.Name = "buttonCreateSet";
            this.buttonCreateSet.Size = new System.Drawing.Size(198, 83);
            this.buttonCreateSet.TabIndex = 0;
            this.buttonCreateSet.Text = "Create a set";
            this.buttonCreateSet.UseVisualStyleBackColor = true;
            this.buttonCreateSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(344, 43);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(325, 23);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Welcome to the Flashcards program!";
            // 
            // buttonLearn
            // 
            this.buttonLearn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLearn.Location = new System.Drawing.Point(255, 214);
            this.buttonLearn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(233, 150);
            this.buttonLearn.TabIndex = 2;
            this.buttonLearn.Text = "Learn";
            this.buttonLearn.UseVisualStyleBackColor = false;
            this.buttonLearn.Click += new System.EventHandler(this.button2_Click);
            // 
            // newSetTextBox
            // 
            this.newSetTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newSetTextBox.Location = new System.Drawing.Point(385, 446);
            this.newSetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newSetTextBox.Name = "newSetTextBox";
            this.newSetTextBox.Size = new System.Drawing.Size(220, 31);
            this.newSetTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name of the new set:";
            // 
            // buttonEditDeck
            // 
            this.buttonEditDeck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditDeck.Location = new System.Drawing.Point(544, 214);
            this.buttonEditDeck.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditDeck.Name = "buttonEditDeck";
            this.buttonEditDeck.Size = new System.Drawing.Size(217, 148);
            this.buttonEditDeck.TabIndex = 7;
            this.buttonEditDeck.Text = "Edit deck";
            this.buttonEditDeck.UseVisualStyleBackColor = false;
            this.buttonEditDeck.Click += new System.EventHandler(this.buttonEditDeck_Click);
            // 
            // selectSetComboBox
            // 
            this.selectSetComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectSetComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectSetComboBox.FormattingEnabled = true;
            this.selectSetComboBox.Location = new System.Drawing.Point(407, 131);
            this.selectSetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectSetComboBox.Name = "selectSetComboBox";
            this.selectSetComboBox.Size = new System.Drawing.Size(242, 31);
            this.selectSetComboBox.TabIndex = 8;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.selectSetComboBox);
            this.Controls.Add(this.buttonEditDeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newSetTextBox);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCreateSet);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Flashcards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSet;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.TextBox newSetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditDeck;
        private System.Windows.Forms.ComboBox selectSetComboBox;
    }
}

