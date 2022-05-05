namespace Flashcards
{
    partial class AddNewSetForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.defTermBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelAddNew = new System.Windows.Forms.Label();
            this.newSetTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Term";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Definition";
            // 
            // termTextBox
            // 
            this.termTextBox.Location = new System.Drawing.Point(329, 99);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(184, 22);
            this.termTextBox.TabIndex = 2;
            // 
            // defTermBox
            // 
            this.defTermBox.Location = new System.Drawing.Point(329, 190);
            this.defTermBox.Multiline = true;
            this.defTermBox.Name = "defTermBox";
            this.defTermBox.Size = new System.Drawing.Size(184, 67);
            this.defTermBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAddNew
            // 
            this.labelAddNew.AutoSize = true;
            this.labelAddNew.Location = new System.Drawing.Point(572, 241);
            this.labelAddNew.Name = "labelAddNew";
            this.labelAddNew.Size = new System.Drawing.Size(195, 16);
            this.labelAddNew.TabIndex = 5;
            this.labelAddNew.Text = "Your flashcard has been added";
            this.labelAddNew.Visible = false;
            // 
            // newSetTitleLabel
            // 
            this.newSetTitleLabel.AutoSize = true;
            this.newSetTitleLabel.Location = new System.Drawing.Point(373, 47);
            this.newSetTitleLabel.Name = "newSetTitleLabel";
            this.newSetTitleLabel.Size = new System.Drawing.Size(84, 16);
            this.newSetTitleLabel.TabIndex = 6;
            this.newSetTitleLabel.Text = "*SET TITLE*";
            // 
            // AddNewSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newSetTitleLabel);
            this.Controls.Add(this.labelAddNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.defTermBox);
            this.Controls.Add(this.termTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewSetForm";
            this.Text = "Add new set of cards";
            this.Load += new System.EventHandler(this.AddNewSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.TextBox defTermBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAddNew;
        private System.Windows.Forms.Label newSetTitleLabel;
    }
}