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
            this.ОбновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПаруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьОткрытыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытыйКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.верификацияПодписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.хешToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ключиRSAToolStripMenuItem,
            this.подписьToolStripMenuItem,
            this.верификацияToolStripMenuItem,
            this.toolStripComboBox1,
            this.хешToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(475, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ключиRSAToolStripMenuItem
            // 
            this.ключиRSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОбновитьToolStripMenuItem,
            this.сохранитьПаруToolStripMenuItem,
            this.сохранитьОткрытыйToolStripMenuItem});
            this.ключиRSAToolStripMenuItem.Name = "ключиRSAToolStripMenuItem";
            this.ключиRSAToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.ключиRSAToolStripMenuItem.Text = "Ключи RSA";
            // 
            // ОбновитьToolStripMenuItem
            // 
            this.ОбновитьToolStripMenuItem.Name = "ОбновитьToolStripMenuItem";
            this.ОбновитьToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.ОбновитьToolStripMenuItem.Text = "Обновить";
            this.ОбновитьToolStripMenuItem.Click += new System.EventHandler(this.ОбновитьКлючиRSA_Click);
            // 
            // сохранитьПаруToolStripMenuItem
            // 
            this.сохранитьПаруToolStripMenuItem.Name = "сохранитьПаруToolStripMenuItem";
            this.сохранитьПаруToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.сохранитьПаруToolStripMenuItem.Text = "Сохранить пару";
            this.сохранитьПаруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПаруToolStripMenuItem_Click);
            // 
            // сохранитьОткрытыйToolStripMenuItem
            // 
            this.сохранитьОткрытыйToolStripMenuItem.Name = "сохранитьОткрытыйToolStripMenuItem";
            this.сохранитьОткрытыйToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.сохранитьОткрытыйToolStripMenuItem.Text = "Сохранить открытый";
            this.сохранитьОткрытыйToolStripMenuItem.Click += new System.EventHandler(this.сохранитьОткрытыйToolStripMenuItem_Click);
            // 
            // подписьToolStripMenuItem
            // 
            this.подписьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.подписатьToolStripMenuItem});
            this.подписьToolStripMenuItem.Name = "подписьToolStripMenuItem";
            this.подписьToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.подписьToolStripMenuItem.Text = "Подпись";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.открытьФайлToolStripMenuItem.Text = "Открыть ключ";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьКлюч_Click);
            // 
            // подписатьToolStripMenuItem
            // 
            this.подписатьToolStripMenuItem.Name = "подписатьToolStripMenuItem";
            this.подписатьToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
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
            this.верификацияToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.верификацияToolStripMenuItem.Text = "Верификация";
            // 
            // открытьФайлToolStripMenuItem1
            // 
            this.открытьФайлToolStripMenuItem1.Name = "открытьФайлToolStripMenuItem1";
            this.открытьФайлToolStripMenuItem1.Size = new System.Drawing.Size(222, 24);
            this.открытьФайлToolStripMenuItem1.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem1.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // открытыйКлючToolStripMenuItem
            // 
            this.открытыйКлючToolStripMenuItem.Name = "открытыйКлючToolStripMenuItem";
            this.открытыйКлючToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.открытыйКлючToolStripMenuItem.Text = "Открыть ключ";
            this.открытыйКлючToolStripMenuItem.Click += new System.EventHandler(this.открытьКлюч_Click);
            // 
            // верификацияПодписиToolStripMenuItem
            // 
            this.верификацияПодписиToolStripMenuItem.Name = "верификацияПодписиToolStripMenuItem";
            this.верификацияПодписиToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.верификацияПодписиToolStripMenuItem.Text = "Верификация подписи";
            this.верификацияПодписиToolStripMenuItem.Click += new System.EventHandler(this.верификацияПодписиToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 27);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // хешToolStripMenuItem
            // 
            this.хешToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.хешToolStripMenuItem.Name = "хешToolStripMenuItem";
            this.хешToolStripMenuItem.Size = new System.Drawing.Size(47, 27);
            this.хешToolStripMenuItem.Text = "Хеш";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 106);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(333, 211);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Metropolis", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "RSA Checker";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(361, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(361, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Подписать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.подписатьToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(361, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Проверить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.верификацияПодписиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RSA Checker v1.0.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ключиRSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОбновитьToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem хешToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

