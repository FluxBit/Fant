namespace Fant
{
    partial class frmAction
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnToGame = new System.Windows.Forms.Button();
            this.btnPickCard = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnToGame, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPickCard, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnToGame
            // 
            this.btnToGame.Image = global::Fant.Properties.Resources.toGameIcon;
            this.btnToGame.Location = new System.Drawing.Point(3, 3);
            this.btnToGame.Name = "btnToGame";
            this.btnToGame.Size = new System.Drawing.Size(64, 70);
            this.btnToGame.TabIndex = 0;
            this.btnToGame.Text = "К Игре";
            this.btnToGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToGame.UseVisualStyleBackColor = true;
            this.btnToGame.Click += new System.EventHandler(this.btnToGame_Click);
            // 
            // btnPickCard
            // 
            this.btnPickCard.Image = global::Fant.Properties.Resources.PickCard;
            this.btnPickCard.Location = new System.Drawing.Point(74, 3);
            this.btnPickCard.Name = "btnPickCard";
            this.btnPickCard.Size = new System.Drawing.Size(64, 70);
            this.btnPickCard.TabIndex = 1;
            this.btnPickCard.Text = "Выбрать Фант";
            this.btnPickCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPickCard.UseVisualStyleBackColor = true;
            this.btnPickCard.Click += new System.EventHandler(this.btnPickCard_Click);
            // 
            // frmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 80);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAction";
            this.Text = "Выберите действие";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnToGame;
        private System.Windows.Forms.Button btnPickCard;
    }
}