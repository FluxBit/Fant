namespace Fant
{
    partial class DeckControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.lblWhiteCount = new System.Windows.Forms.Label();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.lblYellowCount = new System.Windows.Forms.Label();
            this.pnlPink = new System.Windows.Forms.Panel();
            this.lblPinkCount = new System.Windows.Forms.Label();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.lblRedCount = new System.Windows.Forms.Label();
            this.pnlWhite.SuspendLayout();
            this.pnlYellow.SuspendLayout();
            this.pnlPink.SuspendLayout();
            this.pnlRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.White;
            this.pnlWhite.Controls.Add(this.lblWhiteCount);
            this.pnlWhite.Location = new System.Drawing.Point(3, 3);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(100, 140);
            this.pnlWhite.TabIndex = 0;
            this.pnlWhite.Click += new System.EventHandler(this.pnlWhite_Click);
            // 
            // lblWhiteCount
            // 
            this.lblWhiteCount.AutoSize = true;
            this.lblWhiteCount.Location = new System.Drawing.Point(35, 60);
            this.lblWhiteCount.Name = "lblWhiteCount";
            this.lblWhiteCount.Size = new System.Drawing.Size(0, 13);
            this.lblWhiteCount.TabIndex = 0;
            this.lblWhiteCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhiteCount.Click += new System.EventHandler(this.pnlWhite_Click);
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlYellow.Controls.Add(this.lblYellowCount);
            this.pnlYellow.Location = new System.Drawing.Point(109, 3);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(100, 140);
            this.pnlYellow.TabIndex = 1;
            this.pnlYellow.Click += new System.EventHandler(this.pnlYellow_Click);
            // 
            // lblYellowCount
            // 
            this.lblYellowCount.AutoSize = true;
            this.lblYellowCount.Location = new System.Drawing.Point(35, 60);
            this.lblYellowCount.Name = "lblYellowCount";
            this.lblYellowCount.Size = new System.Drawing.Size(0, 13);
            this.lblYellowCount.TabIndex = 0;
            this.lblYellowCount.Click += new System.EventHandler(this.pnlYellow_Click);
            // 
            // pnlPink
            // 
            this.pnlPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlPink.Controls.Add(this.lblPinkCount);
            this.pnlPink.Location = new System.Drawing.Point(215, 3);
            this.pnlPink.Name = "pnlPink";
            this.pnlPink.Size = new System.Drawing.Size(100, 140);
            this.pnlPink.TabIndex = 2;
            this.pnlPink.Click += new System.EventHandler(this.pnlPink_Click);
            // 
            // lblPinkCount
            // 
            this.lblPinkCount.AutoSize = true;
            this.lblPinkCount.Location = new System.Drawing.Point(35, 60);
            this.lblPinkCount.Name = "lblPinkCount";
            this.lblPinkCount.Size = new System.Drawing.Size(0, 13);
            this.lblPinkCount.TabIndex = 0;
            this.lblPinkCount.Click += new System.EventHandler(this.pnlPink_Click);
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlRed.Controls.Add(this.lblRedCount);
            this.pnlRed.Location = new System.Drawing.Point(321, 3);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(100, 140);
            this.pnlRed.TabIndex = 3;
            this.pnlRed.Click += new System.EventHandler(this.pnlRed_Click);
            // 
            // lblRedCount
            // 
            this.lblRedCount.AutoSize = true;
            this.lblRedCount.Location = new System.Drawing.Point(35, 60);
            this.lblRedCount.Name = "lblRedCount";
            this.lblRedCount.Size = new System.Drawing.Size(0, 13);
            this.lblRedCount.TabIndex = 0;
            this.lblRedCount.Click += new System.EventHandler(this.pnlRed_Click);
            // 
            // DeckControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.pnlPink);
            this.Controls.Add(this.pnlYellow);
            this.Controls.Add(this.pnlWhite);
            this.Name = "DeckControl";
            this.Size = new System.Drawing.Size(426, 149);
            this.Load += new System.EventHandler(this.DeckControl_Load);
            this.pnlWhite.ResumeLayout(false);
            this.pnlWhite.PerformLayout();
            this.pnlYellow.ResumeLayout(false);
            this.pnlYellow.PerformLayout();
            this.pnlPink.ResumeLayout(false);
            this.pnlPink.PerformLayout();
            this.pnlRed.ResumeLayout(false);
            this.pnlRed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlPink;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label lblWhiteCount;
        private System.Windows.Forms.Label lblYellowCount;
        private System.Windows.Forms.Label lblPinkCount;
        private System.Windows.Forms.Label lblRedCount;
    }
}
