namespace Fant
{
    partial class PlayerControl
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPicked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Player Name";
            // 
            // lblPicked
            // 
            this.lblPicked.AutoSize = true;
            this.lblPicked.Location = new System.Drawing.Point(13, 39);
            this.lblPicked.Name = "lblPicked";
            this.lblPicked.Size = new System.Drawing.Size(58, 13);
            this.lblPicked.TabIndex = 1;
            this.lblPicked.Text = "Вытянуто:";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPicked);
            this.Controls.Add(this.lblName);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(136, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPicked;
    }
}
