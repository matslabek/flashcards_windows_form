namespace Flashcards
{
    partial class LearnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnForm));
            this.labelCardSetTitle = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonGoAgain = new System.Windows.Forms.Button();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCardSetTitle
            // 
            this.labelCardSetTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCardSetTitle.AutoSize = true;
            this.labelCardSetTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCardSetTitle.Location = new System.Drawing.Point(249, 62);
            this.labelCardSetTitle.Name = "labelCardSetTitle";
            this.labelCardSetTitle.Size = new System.Drawing.Size(114, 23);
            this.labelCardSetTitle.TabIndex = 0;
            this.labelCardSetTitle.Text = "*CARD SET*";
            // 
            // labelTerm
            // 
            this.labelTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTerm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelTerm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTerm.Location = new System.Drawing.Point(47, 124);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(187, 216);
            this.labelTerm.TabIndex = 1;
            this.labelTerm.Text = "*TERM*";
            this.labelTerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(387, 124);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(187, 216);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "* DESCRIPTION *";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShow.Location = new System.Drawing.Point(268, 386);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(95, 38);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonGoAgain
            // 
            this.buttonGoAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoAgain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGoAgain.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoAgain.Location = new System.Drawing.Point(253, 203);
            this.buttonGoAgain.Name = "buttonGoAgain";
            this.buttonGoAgain.Size = new System.Drawing.Size(113, 58);
            this.buttonGoAgain.TabIndex = 5;
            this.buttonGoAgain.Text = "Start again";
            this.buttonGoAgain.UseVisualStyleBackColor = false;
            this.buttonGoAgain.Visible = false;
            this.buttonGoAgain.Click += new System.EventHandler(this.buttonGoAgain_Click);
            // 
            // labelCorrect
            // 
            this.labelCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCorrect.ForeColor = System.Drawing.Color.Black;
            this.labelCorrect.Location = new System.Drawing.Point(267, 302);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(87, 22);
            this.labelCorrect.TabIndex = 6;
            this.labelCorrect.Text = "Correct?";
            this.labelCorrect.Visible = false;
            // 
            // buttonX
            // 
            this.buttonX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonX.Image = ((System.Drawing.Image)(resources.GetObject("buttonX.Image")));
            this.buttonX.Location = new System.Drawing.Point(319, 340);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 28);
            this.buttonX.TabIndex = 7;
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Visible = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonV
            // 
            this.buttonV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonV.Image = ((System.Drawing.Image)(resources.GetObject("buttonV.Image")));
            this.buttonV.Location = new System.Drawing.Point(271, 340);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(35, 28);
            this.buttonV.TabIndex = 8;
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Visible = false;
            this.buttonV.Click += new System.EventHandler(this.button2_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(638, 464);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.buttonGoAgain);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelCardSetTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LearnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCardSetTitle;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonGoAgain;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonV;
    }
}