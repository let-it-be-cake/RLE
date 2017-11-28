namespace RLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PackTab = new System.Windows.Forms.TabPage();
            this.PackButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PackChangeButton = new System.Windows.Forms.Button();
            this.PackedTextBox = new System.Windows.Forms.TextBox();
            this.ForPackTextBox = new System.Windows.Forms.TextBox();
            this.UnpackTab = new System.Windows.Forms.TabPage();
            this.UnpackButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UnpackedChangeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UnpackedTextBox = new System.Windows.Forms.TextBox();
            this.ForUnpackTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сжатиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьЗапакованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьСжатыйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.обзорТекстаДляСжатияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распаковкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьРаспакованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортироватьРаспакованныйТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.обзорТекстаДляРаспаковкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.PackTab.SuspendLayout();
            this.UnpackTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PackTab);
            this.tabControl1.Controls.Add(this.UnpackTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // PackTab
            // 
            this.PackTab.Controls.Add(this.PackButton);
            this.PackTab.Controls.Add(this.label2);
            this.PackTab.Controls.Add(this.label1);
            this.PackTab.Controls.Add(this.PackChangeButton);
            this.PackTab.Controls.Add(this.PackedTextBox);
            this.PackTab.Controls.Add(this.ForPackTextBox);
            this.PackTab.Location = new System.Drawing.Point(4, 22);
            this.PackTab.Name = "PackTab";
            this.PackTab.Padding = new System.Windows.Forms.Padding(3);
            this.PackTab.Size = new System.Drawing.Size(584, 385);
            this.PackTab.TabIndex = 0;
            this.PackTab.Text = "Сжать";
            this.PackTab.UseVisualStyleBackColor = true;
            // 
            // PackButton
            // 
            this.PackButton.Enabled = false;
            this.PackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PackButton.Location = new System.Drawing.Point(238, 24);
            this.PackButton.Name = "PackButton";
            this.PackButton.Size = new System.Drawing.Size(108, 32);
            this.PackButton.TabIndex = 5;
            this.PackButton.Text = "Сжать";
            this.PackButton.UseVisualStyleBackColor = true;
            this.PackButton.Click += new System.EventHandler(this.PackButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Запакованный текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите текст для сжатия";
            // 
            // PackChangeButton
            // 
            this.PackChangeButton.Location = new System.Drawing.Point(93, 31);
            this.PackChangeButton.Name = "PackChangeButton";
            this.PackChangeButton.Size = new System.Drawing.Size(75, 23);
            this.PackChangeButton.TabIndex = 2;
            this.PackChangeButton.Text = "Обзор";
            this.PackChangeButton.UseVisualStyleBackColor = true;
            this.PackChangeButton.Click += new System.EventHandler(this.PackChangeButton_Click);
            // 
            // PackedTextBox
            // 
            this.PackedTextBox.Location = new System.Drawing.Point(324, 60);
            this.PackedTextBox.Multiline = true;
            this.PackedTextBox.Name = "PackedTextBox";
            this.PackedTextBox.ReadOnly = true;
            this.PackedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PackedTextBox.Size = new System.Drawing.Size(254, 312);
            this.PackedTextBox.TabIndex = 1;
            // 
            // ForPackTextBox
            // 
            this.ForPackTextBox.Location = new System.Drawing.Point(7, 60);
            this.ForPackTextBox.MaxLength = 10000;
            this.ForPackTextBox.Multiline = true;
            this.ForPackTextBox.Name = "ForPackTextBox";
            this.ForPackTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ForPackTextBox.Size = new System.Drawing.Size(254, 312);
            this.ForPackTextBox.TabIndex = 0;
            // 
            // UnpackTab
            // 
            this.UnpackTab.Controls.Add(this.UnpackButton);
            this.UnpackTab.Controls.Add(this.label4);
            this.UnpackTab.Controls.Add(this.UnpackedChangeButton);
            this.UnpackTab.Controls.Add(this.label3);
            this.UnpackTab.Controls.Add(this.UnpackedTextBox);
            this.UnpackTab.Controls.Add(this.ForUnpackTextBox);
            this.UnpackTab.Location = new System.Drawing.Point(4, 22);
            this.UnpackTab.Name = "UnpackTab";
            this.UnpackTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnpackTab.Size = new System.Drawing.Size(584, 385);
            this.UnpackTab.TabIndex = 1;
            this.UnpackTab.Text = "Распаковать";
            this.UnpackTab.UseVisualStyleBackColor = true;
            // 
            // UnpackButton
            // 
            this.UnpackButton.Enabled = false;
            this.UnpackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.UnpackButton.Location = new System.Drawing.Point(218, 20);
            this.UnpackButton.Name = "UnpackButton";
            this.UnpackButton.Size = new System.Drawing.Size(145, 36);
            this.UnpackButton.TabIndex = 5;
            this.UnpackButton.Text = "Распаковать";
            this.UnpackButton.UseVisualStyleBackColor = true;
            this.UnpackButton.Click += new System.EventHandler(this.UnpackButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Распакованный текст";
            // 
            // UnpackedChangeButton
            // 
            this.UnpackedChangeButton.Location = new System.Drawing.Point(93, 31);
            this.UnpackedChangeButton.Name = "UnpackedChangeButton";
            this.UnpackedChangeButton.Size = new System.Drawing.Size(75, 23);
            this.UnpackedChangeButton.TabIndex = 3;
            this.UnpackedChangeButton.Text = "Обзор";
            this.UnpackedChangeButton.UseVisualStyleBackColor = true;
            this.UnpackedChangeButton.Click += new System.EventHandler(this.UnpackedChangeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите текст для распаковки";
            // 
            // UnpackedTextBox
            // 
            this.UnpackedTextBox.Location = new System.Drawing.Point(324, 60);
            this.UnpackedTextBox.Multiline = true;
            this.UnpackedTextBox.Name = "UnpackedTextBox";
            this.UnpackedTextBox.ReadOnly = true;
            this.UnpackedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnpackedTextBox.Size = new System.Drawing.Size(254, 312);
            this.UnpackedTextBox.TabIndex = 1;
            // 
            // ForUnpackTextBox
            // 
            this.ForUnpackTextBox.Location = new System.Drawing.Point(7, 60);
            this.ForUnpackTextBox.MaxLength = 10000;
            this.ForUnpackTextBox.Multiline = true;
            this.ForUnpackTextBox.Name = "ForUnpackTextBox";
            this.ForUnpackTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ForUnpackTextBox.Size = new System.Drawing.Size(254, 312);
            this.ForUnpackTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.программаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сжатиеToolStripMenuItem,
            this.распаковкаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сжатиеToolStripMenuItem
            // 
            this.сжатиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьЗапакованныйТекстToolStripMenuItem,
            this.экспортироватьСжатыйТекстToolStripMenuItem,
            this.toolStripSeparator1,
            this.обзорТекстаДляСжатияToolStripMenuItem});
            this.сжатиеToolStripMenuItem.Name = "сжатиеToolStripMenuItem";
            this.сжатиеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сжатиеToolStripMenuItem.Text = "Сжатие";
            // 
            // копироватьЗапакованныйТекстToolStripMenuItem
            // 
            this.копироватьЗапакованныйТекстToolStripMenuItem.Name = "копироватьЗапакованныйТекстToolStripMenuItem";
            this.копироватьЗапакованныйТекстToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.копироватьЗапакованныйТекстToolStripMenuItem.Text = "Копировать сжатый текст";
            this.копироватьЗапакованныйТекстToolStripMenuItem.Click += new System.EventHandler(this.копироватьЗапакованныйТекстToolStripMenuItem_Click);
            // 
            // экспортироватьСжатыйТекстToolStripMenuItem
            // 
            this.экспортироватьСжатыйТекстToolStripMenuItem.Name = "экспортироватьСжатыйТекстToolStripMenuItem";
            this.экспортироватьСжатыйТекстToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.экспортироватьСжатыйТекстToolStripMenuItem.Text = "Экспортировать сжатый текст";
            this.экспортироватьСжатыйТекстToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьСжатыйТекстToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // обзорТекстаДляСжатияToolStripMenuItem
            // 
            this.обзорТекстаДляСжатияToolStripMenuItem.Name = "обзорТекстаДляСжатияToolStripMenuItem";
            this.обзорТекстаДляСжатияToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.обзорТекстаДляСжатияToolStripMenuItem.Text = "Обзор текста для сжатия";
            this.обзорТекстаДляСжатияToolStripMenuItem.Click += new System.EventHandler(this.обзорТекстаДляСжатияToolStripMenuItem_Click);
            // 
            // распаковкаToolStripMenuItem
            // 
            this.распаковкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьРаспакованныйТекстToolStripMenuItem,
            this.экспортироватьРаспакованныйТекстToolStripMenuItem,
            this.toolStripSeparator2,
            this.обзорТекстаДляРаспаковкиToolStripMenuItem});
            this.распаковкаToolStripMenuItem.Name = "распаковкаToolStripMenuItem";
            this.распаковкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.распаковкаToolStripMenuItem.Text = "Распаковка";
            // 
            // копироватьРаспакованныйТекстToolStripMenuItem
            // 
            this.копироватьРаспакованныйТекстToolStripMenuItem.Name = "копироватьРаспакованныйТекстToolStripMenuItem";
            this.копироватьРаспакованныйТекстToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.копироватьРаспакованныйТекстToolStripMenuItem.Text = "Копировать распакованный текст";
            this.копироватьРаспакованныйТекстToolStripMenuItem.Click += new System.EventHandler(this.копироватьРаспакованныйТекстToolStripMenuItem_Click);
            // 
            // экспортироватьРаспакованныйТекстToolStripMenuItem
            // 
            this.экспортироватьРаспакованныйТекстToolStripMenuItem.Name = "экспортироватьРаспакованныйТекстToolStripMenuItem";
            this.экспортироватьРаспакованныйТекстToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.экспортироватьРаспакованныйТекстToolStripMenuItem.Text = "Экспортировать распакованный текст";
            this.экспортироватьРаспакованныйТекстToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьРаспакованныйТекстToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
            // 
            // обзорТекстаДляРаспаковкиToolStripMenuItem
            // 
            this.обзорТекстаДляРаспаковкиToolStripMenuItem.Name = "обзорТекстаДляРаспаковкиToolStripMenuItem";
            this.обзорТекстаДляРаспаковкиToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.обзорТекстаДляРаспаковкиToolStripMenuItem.Text = "Обзор текста для распаковки";
            this.обзорТекстаДляРаспаковкиToolStripMenuItem.Click += new System.EventHandler(this.обзорТекстаДляРаспаковкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 438);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RLE сжатие";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.PackTab.ResumeLayout(false);
            this.PackTab.PerformLayout();
            this.UnpackTab.ResumeLayout(false);
            this.UnpackTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PackTab;
        private System.Windows.Forms.TabPage UnpackTab;
        private System.Windows.Forms.Button PackButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PackChangeButton;
        private System.Windows.Forms.TextBox PackedTextBox;
        private System.Windows.Forms.TextBox ForPackTextBox;
        private System.Windows.Forms.Button UnpackButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UnpackedChangeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnpackedTextBox;
        private System.Windows.Forms.TextBox ForUnpackTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сжатиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распаковкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьЗапакованныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьСжатыйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem обзорТекстаДляСжатияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьРаспакованныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортироватьРаспакованныйТекстToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem обзорТекстаДляРаспаковкиToolStripMenuItem;
    }
}

