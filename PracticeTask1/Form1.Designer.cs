namespace PracticeTask1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ввестиВручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Input_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиВручнуюToolStripMenuItem,
            this.ввестиИзФайлаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ввестиВручнуюToolStripMenuItem
            // 
            this.ввестиВручнуюToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ввестиВручнуюToolStripMenuItem.Name = "ввестиВручнуюToolStripMenuItem";
            this.ввестиВручнуюToolStripMenuItem.Size = new System.Drawing.Size(194, 37);
            this.ввестиВручнуюToolStripMenuItem.Text = "Ввести вручную";
            this.ввестиВручнуюToolStripMenuItem.Click += new System.EventHandler(this.ввестиВручнуюToolStripMenuItem_Click);
            // 
            // ввестиИзФайлаToolStripMenuItem
            // 
            this.ввестиИзФайлаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ввестиИзФайлаToolStripMenuItem.Name = "ввестиИзФайлаToolStripMenuItem";
            this.ввестиИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(203, 37);
            this.ввестиИзФайлаToolStripMenuItem.Text = "Ввести из файла";
            this.ввестиИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.ввестиИзФайлаToolStripMenuItem_Click);
            // 
            // Input_Label
            // 
            this.Input_Label.AutoSize = true;
            this.Input_Label.BackColor = System.Drawing.Color.Transparent;
            this.Input_Label.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input_Label.Location = new System.Drawing.Point(12, 59);
            this.Input_Label.Name = "Input_Label";
            this.Input_Label.Size = new System.Drawing.Size(177, 33);
            this.Input_Label.TabIndex = 1;
            this.Input_Label.Text = "Входные данные:";
            this.Input_Label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PracticeTask1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(426, 186);
            this.Controls.Add(this.Input_Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Взлом хеш-функции";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ввестиВручнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиИзФайлаToolStripMenuItem;
        private System.Windows.Forms.Label Input_Label;
    }
}

