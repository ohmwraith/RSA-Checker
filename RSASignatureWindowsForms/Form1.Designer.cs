namespace RSASignatureWindowsForms
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
            this.ключиRSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОткрытыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытыйКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияПодписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ключиRSAToolStripMenuItem,
            this.подписьToolStripMenuItem,
            this.верификацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ключиRSAToolStripMenuItem
            // 
            this.ключиRSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПаруToolStripMenuItem,
            this.сохранитьПаруToolStripMenuItem,
            this.сохранитьОткрытыйToolStripMenuItem});
            this.ключиRSAToolStripMenuItem.Name = "ключиRSAToolStripMenuItem";
            this.ключиRSAToolStripMenuItem.Size = new System.Drawing.Size(105, 25);
            this.ключиRSAToolStripMenuItem.Text = "Ключи RSA";
            // 
            // создатьПаруToolStripMenuItem
            // 
            this.создатьПаруToolStripMenuItem.Name = "создатьПаруToolStripMenuItem";
            this.создатьПаруToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.создатьПаруToolStripMenuItem.Text = "Создать пару";
            this.создатьПаруToolStripMenuItem.Click += new System.EventHandler(this.создатьПаруToolStripMenuItem_Click);
            // 
            // сохранитьПаруToolStripMenuItem
            // 
            this.сохранитьПаруToolStripMenuItem.Name = "сохранитьПаруToolStripMenuItem";
            this.сохранитьПаруToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.сохранитьПаруToolStripMenuItem.Text = "Сохранить пару";
            this.сохранитьПаруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПаруToolStripMenuItem_Click);
            // 
            // сохранитьОткрытыйToolStripMenuItem
            // 
            this.сохранитьОткрытыйToolStripMenuItem.Name = "сохранитьОткрытыйToolStripMenuItem";
            this.сохранитьОткрытыйToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.сохранитьОткрытыйToolStripMenuItem.Text = "Сохранить открытый";
            this.сохранитьОткрытыйToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОткрытыйToolStripMenuItem_Click);
            // 
            // подписьToolStripMenuItem
            // 
            this.подписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.подписатьToolStripMenuItem});
            this.подписьToolStripMenuItem.Name = "подписьToolStripMenuItem";
            this.подписьToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.подписьToolStripMenuItem.Text = "Подпись";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // подписатьToolStripMenuItem
            // 
            this.подписатьToolStripMenuItem.Name = "подписатьToolStripMenuItem";
            this.подписатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.подписатьToolStripMenuItem.Text = "Подписать";
            this.подписатьToolStripMenuItem.Click += new System.EventHandler(this.подписатьToolStripMenuItem_Click);
            // 
            // верификацияToolStripMenuItem
            // 
            this.верификацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem1,
            this.открытыйКлючToolStripMenuItem,
            this.верификацияПодписиToolStripMenuItem});
            this.верификацияToolStripMenuItem.Name = "верификацияToolStripMenuItem";
            this.верификацияToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.верификацияToolStripMenuItem.Text = "Верификация";
            // 
            // открытьФайлToolStripMenuItem1
            // 
            this.открытьФайлToolStripMenuItem1.Name = "открытьФайлToolStripMenuItem1";
            this.открытьФайлToolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.открытьФайлToolStripMenuItem1.Text = "Открыть файл";
            // 
            // открытыйКлючToolStripMenuItem
            // 
            this.открытыйКлючToolStripMenuItem.Name = "открытыйКлючToolStripMenuItem";
            this.открытыйКлючToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.открытыйКлючToolStripMenuItem.Text = "Открытый ключ";
            // 
            // верификацияПодписиToolStripMenuItem
            // 
            this.верификацияПодписиToolStripMenuItem.Name = "верификацияПодписиToolStripMenuItem";
            this.верификацияПодписиToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.верификацияПодписиToolStripMenuItem.Text = "Верификация подписи";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(247, 153);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RSA Signature";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ключиRSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПаруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьОткрытыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem верификацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытыйКлючToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem верификацияПодписиToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

