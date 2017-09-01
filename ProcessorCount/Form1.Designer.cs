namespace ProcessorCount
{
    partial class SysFormInfo
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
            this.SysInfo = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SysInfo
            // 
            this.SysInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysInfo.Location = new System.Drawing.Point(12, 12);
            this.SysInfo.Name = "SysInfo";
            this.SysInfo.Size = new System.Drawing.Size(196, 65);
            this.SysInfo.TabIndex = 0;
            this.SysInfo.Text = "Get System Info";
            this.SysInfo.UseVisualStyleBackColor = true;
            this.SysInfo.Click += new System.EventHandler(this.SysInfo_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(12, 83);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(778, 594);
            this.infoTextBox.TabIndex = 1;
            this.infoTextBox.Text = "";
            // 
            // SysFormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 689);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.SysInfo);
            this.Name = "SysFormInfo";
            this.Text = "System Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SysInfo;
        private System.Windows.Forms.RichTextBox infoTextBox;
    }
}

