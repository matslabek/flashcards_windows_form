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
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCardSetTitle
            // 
            this.labelCardSetTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCardSetTitle.AutoSize = true;
            this.labelCardSetTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCardSetTitle.Location = new System.Drawing.Point(285, 65);
            this.labelCardSetTitle.Name = "labelCardSetTitle";
            this.labelCardSetTitle.Size = new System.Drawing.Size(114, 23);
            this.labelCardSetTitle.TabIndex = 0;
            this.labelCardSetTitle.Text = "*CARD SET*";
            // 
            // labelTerm
            // 
            this.labelTerm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTerm.Location = new System.Drawing.Point(162, 225);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(80, 23);
            this.labelTerm.TabIndex = 1;
            this.labelTerm.Text = "*TERM*";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(370, 153);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(300, 169);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "* DESCRIPTION *";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDescription.Visible = false;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShow.Location = new System.Drawing.Point(466, 338);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(95, 38);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNext.Location = new System.Drawing.Point(166, 338);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 38);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(742, 464);
            this.Controls.Add(this.buttonNext);
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
        private System.Windows.Forms.Button buttonNext;
    }
}