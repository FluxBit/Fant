namespace Fant
{
    partial class frmDeck
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
            this.deckControl1 = new Fant.DeckControl();
            this.SuspendLayout();
            // 
            // deckControl1
            // 
            this.deckControl1.Location = new System.Drawing.Point(12, 12);
            this.deckControl1.Name = "deckControl1";
            this.deckControl1.Size = new System.Drawing.Size(426, 149);
            this.deckControl1.TabIndex = 0;
            // 
            // frmDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 166);
            this.Controls.Add(this.deckControl1);
            this.Name = "frmDeck";
            this.Text = "frmDeck";
            this.ResumeLayout(false);

        }

        #endregion

        private DeckControl deckControl1;
    }
}