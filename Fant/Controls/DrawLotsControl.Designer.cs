namespace Fant
{
    partial class DrawLotsControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPickPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 220);
            this.listBox1.TabIndex = 3;
            // 
            // btnPickPlayer
            // 
            this.btnPickPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPickPlayer.Location = new System.Drawing.Point(3, 229);
            this.btnPickPlayer.Name = "btnPickPlayer";
            this.btnPickPlayer.Size = new System.Drawing.Size(138, 33);
            this.btnPickPlayer.TabIndex = 2;
            this.btnPickPlayer.Text = "Жеребьевка";
            this.btnPickPlayer.UseVisualStyleBackColor = true;
            this.btnPickPlayer.Click += new System.EventHandler(this.btnPickPlayer_Click);
            // 
            // DrawLotsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnPickPlayer);
            this.Name = "DrawLotsControl";
            this.Size = new System.Drawing.Size(145, 269);
            this.Load += new System.EventHandler(this.DrawLotsControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPickPlayer;
    }
}
