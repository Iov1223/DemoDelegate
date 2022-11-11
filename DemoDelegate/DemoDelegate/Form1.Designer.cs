namespace DemoDelegate
{
    partial class FormFileSorter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFileContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFileContent
            // 
            this.labelFileContent.AutoSize = true;
            this.labelFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileContent.Location = new System.Drawing.Point(36, 13);
            this.labelFileContent.Name = "labelFileContent";
            this.labelFileContent.Size = new System.Drawing.Size(179, 20);
            this.labelFileContent.TabIndex = 0;
            this.labelFileContent.Text = "Содержимое файла";
            // 
            // FormFileSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 280);
            this.Controls.Add(this.labelFileContent);
            this.Name = "FormFileSorter";
            this.Text = "FileSorter";
            this.DoubleClick += new System.EventHandler(this.FormFileSorter_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileContent;
    }
}

