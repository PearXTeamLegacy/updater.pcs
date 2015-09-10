namespace updater.pcs
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.barDownloading = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelDownloading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barDownloading
            // 
            this.barDownloading.Location = new System.Drawing.Point(2, 41);
            this.barDownloading.Name = "barDownloading";
            this.barDownloading.Size = new System.Drawing.Size(357, 29);
            this.barDownloading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barDownloading.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelDownloading
            // 
            this.labelDownloading.AutoSize = true;
            this.labelDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDownloading.Location = new System.Drawing.Point(12, 9);
            this.labelDownloading.Name = "labelDownloading";
            this.labelDownloading.Size = new System.Drawing.Size(79, 29);
            this.labelDownloading.TabIndex = 1;
            this.labelDownloading.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 78);
            this.Controls.Add(this.labelDownloading);
            this.Controls.Add(this.barDownloading);
            this.Name = "Main";
            this.Text = "Обновление PCS...";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barDownloading;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDownloading;
    }
}

