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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.newSetTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newSetErrorLabel = new System.Windows.Forms.Label();
            this.buttonEditDeck = new System.Windows.Forms.Button();
            this.selectSetComboBox = new System.Windows.Forms.ComboBox();
            this.labelSetNotSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateSet
            // 
            this.buttonCreateSet.Location = new System.Drawing.Point(568, 466);
            this.buttonCreateSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateSet.Name = "buttonCreateSet";
            this.buttonCreateSet.Size = new System.Drawing.Size(157, 50);
            this.buttonCreateSet.TabIndex = 0;
            this.buttonCreateSet.Text = "Create a set";
            this.buttonCreateSet.UseVisualStyleBackColor = true;
            this.buttonCreateSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(356, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Flashcards program!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLearn
            // 
            this.buttonLearn.Location = new System.Drawing.Point(307, 305);
            this.buttonLearn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(197, 76);
            this.buttonLearn.TabIndex = 2;
            this.buttonLearn.Text = "Learn";
            this.buttonLearn.UseVisualStyleBackColor = false;
            this.buttonLearn.Click += new System.EventHandler(this.button2_Click);
            // 
            // newSetTextBox
            // 
            this.newSetTextBox.Location = new System.Drawing.Point(407, 474);
            this.newSetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newSetTextBox.Name = "newSetTextBox";
            this.newSetTextBox.Size = new System.Drawing.Size(136, 31);
            this.newSetTextBox.TabIndex = 3;
            this.newSetTextBox.Text = "sdfas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name of the new set:";
            // 
            // newSetErrorLabel
            // 
            this.newSetErrorLabel.AutoSize = true;
            this.newSetErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.newSetErrorLabel.Location = new System.Drawing.Point(762, 474);
            this.newSetErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newSetErrorLabel.Name = "newSetErrorLabel";
            this.newSetErrorLabel.Size = new System.Drawing.Size(194, 23);
            this.newSetErrorLabel.TabIndex = 5;
            this.newSetErrorLabel.Text = "Please provide name!";
            this.newSetErrorLabel.Visible = false;
            this.newSetErrorLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonEditDeck
            // 
            this.buttonEditDeck.Location = new System.Drawing.Point(539, 305);
            this.buttonEditDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditDeck.Name = "buttonEditDeck";
            this.buttonEditDeck.Size = new System.Drawing.Size(186, 76);
            this.buttonEditDeck.TabIndex = 7;
            this.buttonEditDeck.Text = "Edit deck";
            this.buttonEditDeck.UseVisualStyleBackColor = false;
            // 
            // selectSetComboBox
            // 
            this.selectSetComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectSetComboBox.FormattingEnabled = true;
            this.selectSetComboBox.Location = new System.Drawing.Point(385, 224);
            this.selectSetComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectSetComboBox.Name = "selectSetComboBox";
            this.selectSetComboBox.Size = new System.Drawing.Size(242, 31);
            this.selectSetComboBox.TabIndex = 8;
            this.selectSetComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelSetNotSelected
            // 
            this.labelSetNotSelected.AutoSize = true;
            this.labelSetNotSelected.BackColor = System.Drawing.Color.White;
            this.labelSetNotSelected.ForeColor = System.Drawing.Color.Red;
            this.labelSetNotSelected.Location = new System.Drawing.Point(762, 229);
            this.labelSetNotSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSetNotSelected.Name = "labelSetNotSelected";
            this.labelSetNotSelected.Size = new System.Drawing.Size(174, 23);
            this.labelSetNotSelected.TabIndex = 9;
            this.labelSetNotSelected.Text = "Please choose a set";
            this.labelSetNotSelected.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 647);
            this.Controls.Add(this.labelSetNotSelected);
            this.Controls.Add(this.selectSetComboBox);
            this.Controls.Add(this.buttonEditDeck);
            this.Controls.Add(this.newSetErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newSetTextBox);
            this.Controls.Add(this.buttonLearn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateSet);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "Flashcards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.TextBox newSetTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newSetErrorLabel;
        private System.Windows.Forms.Button buttonEditDeck;
        private System.Windows.Forms.ComboBox selectSetComboBox;
        private System.Windows.Forms.Label labelSetNotSelected;
    }
}

