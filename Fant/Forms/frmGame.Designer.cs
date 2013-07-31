namespace Fant
{
    partial class frmGame
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPick = new System.Windows.Forms.Button();
            this.strip = new System.Windows.Forms.StatusStrip();
            this.tslblStatistic = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnComplete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLotsControl1 = new Fant.DrawLotsControl();
            this.ctrlCard = new Fant.CardControl();
            this.strip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPick.Location = new System.Drawing.Point(160, 532);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(171, 46);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Тянуть карту";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // strip
            // 
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatistic});
            this.strip.Location = new System.Drawing.Point(0, 582);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(860, 22);
            this.strip.TabIndex = 20;
            this.strip.Text = "statusStrip1";
            // 
            // tslblStatistic
            // 
            this.tslblStatistic.BackColor = System.Drawing.SystemColors.Control;
            this.tslblStatistic.Name = "tslblStatistic";
            this.tslblStatistic.Size = new System.Drawing.Size(32, 17);
            this.tslblStatistic.Text = "Карт";
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplete.Location = new System.Drawing.Point(337, 532);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(173, 46);
            this.btnComplete.TabIndex = 21;
            this.btnComplete.Text = "Выполнено!";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Visible = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGame,
            this.mnuInfo,
            this.mnuPositions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuGame
            // 
            this.mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuExit});
            this.mnuGame.Name = "mnuGame";
            this.mnuGame.Size = new System.Drawing.Size(46, 20);
            this.mnuGame.Text = "Игра";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuNewGame.Size = new System.Drawing.Size(155, 22);
            this.mnuNewGame.Text = "Новая игра";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(155, 22);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(93, 20);
            this.mnuInfo.Text = "Информация";
            this.mnuInfo.Click += new System.EventHandler(this.mnuInfo_Click);
            // 
            // mnuPositions
            // 
            this.mnuPositions.Name = "mnuPositions";
            this.mnuPositions.Size = new System.Drawing.Size(84, 20);
            this.mnuPositions.Text = "Каталог поз";
            this.mnuPositions.Click += new System.EventHandler(this.mnuPositions_Click);
            // 
            // drawLotsControl1
            // 
            this.drawLotsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawLotsControl1.Location = new System.Drawing.Point(516, 27);
            this.drawLotsControl1.Name = "drawLotsControl1";
            this.drawLotsControl1.Size = new System.Drawing.Size(145, 269);
            this.drawLotsControl1.TabIndex = 17;
            // 
            // ctrlCard
            // 
            this.ctrlCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ctrlCard.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlCard.ForeColor = System.Drawing.Color.Black;
            this.ctrlCard.Location = new System.Drawing.Point(160, 27);
            this.ctrlCard.MinimumSize = new System.Drawing.Size(350, 500);
            this.ctrlCard.Name = "ctrlCard";
            this.ctrlCard.Size = new System.Drawing.Size(350, 500);
            this.ctrlCard.TabIndex = 3;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(860, 604);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.drawLotsControl1);
            this.Controls.Add(this.ctrlCard);
            this.Controls.Add(this.btnPick);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGame";
            this.Text = "Игра Фанты-Абсент";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private CardControl ctrlCard;
        private DrawLotsControl drawLotsControl1;
        private System.Windows.Forms.StatusStrip strip;
        private System.Windows.Forms.ToolStripStatusLabel tslblStatistic;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuPositions;
    }
}

