namespace Fant
{
    partial class CardControl
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.Location = new System.Drawing.Point(0, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(350, 26);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Номер фанта";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(0, 26);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(350, 474);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Текст задания";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblNum);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(350, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblText;
    }
}
