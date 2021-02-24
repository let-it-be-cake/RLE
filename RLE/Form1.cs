using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Стеганография; // Просто любопытно, почему на русском? Почему не Shorthand?

namespace RLE
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            ForPackTextBox.TextChanged += ForPackTextBox_TextChanged;
            ForUnpackTextBox.TextChanged += ForUnpackTextBox_TextChanged;
        }

        private void ForPackTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ForPackTextBox.Text))
                PackButton.Enabled = false;
            else
                PackButton.Enabled = true;
        }

        private void ForUnpackTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ForUnpackTextBox.Text))
                UnpackButton.Enabled = false;
            else
                UnpackButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // exitToolStripMenuItem_Click
        {
            this.Close();
        }

        private void PackChangeButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            string fileText = reader.ReadToEnd(); 
            ForPackTextBox.Text = fileText;
            reader.Close();
        }

        private void UnpackedChangeButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            string fileText = reader.ReadToEnd();
            ForUnpackTextBox.Text = fileText;
            reader.Close();
        }

        private void обзорТекстаДляСжатияToolStripMenuItem_Click(object sender, EventArgs e) // OverviewOfTextForCompressionToolStripMenuItem_Click
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            string fileText = reader.ReadToEnd();
            ForPackTextBox.Text = fileText;
            reader.Close();
        }

        private void обзорТекстаДляРаспаковкиToolStripMenuItem_Click(object sender, EventArgs e) // OverviewOfTextForDecompressionToolStripMenuItem_Click
        {
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
            string fileText = reader.ReadToEnd();
            ForUnpackTextBox.Text = fileText;
            reader.Close();
        }

        private void экспортироватьСжатыйТекстToolStripMenuItem_Click(object sender, EventArgs e) // ExportCompressedTextToolStripMenuItem_Click
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Выберите файл";
            saveFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, PackedTextBox.Text);
            MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void экспортироватьРаспакованныйТекстToolStripMenuItem_Click(object sender, EventArgs e) // ExportUnpacketTextToolStripMenuItem_Click
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Выберите файл";
            saveFileDialog1.Filter = "Текстовые файлы|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, UnpackedTextBox.Text);
            MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author authors = new Author();
            authors.Show();
        }

        private void копироватьЗапакованныйТекстToolStripMenuItem_Click(object sender, EventArgs e) //CopyPackedTextToolStripMenuItem_Click
        {
            if (PackedTextBox.Text.Length > 0)
            {
                MessageBox.Show("Текст скопирован в буфер обмена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clipboard.SetText(PackedTextBox.Text);
            }
            else
            {
                MessageBox.Show("Вы пытаетесь скопировать пустое поле", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void копироватьРаспакованныйТекстToolStripMenuItem_Click(object sender, EventArgs e) //CopyUnpackedTextToolStripMenuItem_Click
        {
            if (UnpackedTextBox.Text.Length > 0)
            {
                MessageBox.Show("Текст скопирован в буфер обмена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clipboard.SetText(UnpackedTextBox.Text);
            }
            else
            {
                MessageBox.Show("Вы пытаетесь скопировать пустое поле", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static string delete(string source)
        {
            StringBuilder dest = new StringBuilder();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == '#' || (source[i] >= '1' && source[i] <= '9'))
                {
                    source.Remove(i);
                }
                else
                {
                    dest.Append(source[i]);
                }
            }
            return dest.ToString();
        }

        public static string encode(string source)
        {
            string resultForPack = delete(source);
            StringBuilder dest = new StringBuilder();
            for (int i = 0; i < resultForPack.Length; i++)
            {
                int runLength = 1;
                while (i + 1 < resultForPack.Length && resultForPack[i] == resultForPack[i + 1])
                {
                    runLength++;
                    i++;
                }
                if (runLength >= 3 && resultForPack[i]!=' ')
                {
                    dest.Append('#');
                    dest.Append(runLength);
                    dest.Append(resultForPack[i]);
                }
                else if(runLength==2 && resultForPack[i] != ' ')
                {
                    dest.Append(resultForPack[i]);
                    dest.Append(resultForPack[i]);
                }
                else
                {
                    dest.Append(resultForPack[i]);
                }
            }
            return dest.ToString();
        }

        public static bool isdigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        public static int atoi(char [] s)
        {
            int i, n;

            for (i = 0, n = 0; s[i] >= '0' && s[i] <= '9'; i++)
                n = n * 10 + (s[i] - '0');
            return n;
        }

        public static string decode(string source)
        {
            StringBuilder dest = new StringBuilder();

            int j;
            int res = 0;
            int count = 0;
            char ch = '\0';
            string strcount="";

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == '#' && i+1!=source.Length)
                {
                    if (!isdigit(source[i+1]))
                    {
                        dest.Append(source[i]);
                        dest.Append(source[i+1]);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("i="+i);
                        while(isdigit(source[i+1+res]))
                        {
                            strcount+= source[i+1+res];
                            res++;
                            Console.WriteLine(strcount);
                        }
                        count = Convert.ToInt32(strcount);
                        ch = source[i+1+res];
                        for (j = 0; j < count; j++)
                            dest.Append(ch);
                        i = i + 1 + res;
                        strcount = "";
                        res = 0;
                    }
                }
                else
                {
                    dest.Append(source[i]);
                }
            }
            return dest.ToString();
        }

        private void PackButton_Click(object sender, EventArgs e)
        {
            PackedTextBox.Text = encode(ForPackTextBox.Text);
        }

        private void UnpackButton_Click(object sender, EventArgs e)
        {
            UnpackedTextBox.Text = decode(ForUnpackTextBox.Text);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e) // HelpToolStripMenuItem_Click
        {
            WebBrowser webBrowser1 = new WebBrowser();
            var helper = Properties.Resources.helper;
            var fileName = Path.ChangeExtension(Path.GetTempFileName(), ".html");
            var fs = File.CreateText(fileName);
            fs.Write(helper);
            fs.Flush();
            fs.Close();
            Process.Start(fileName);
        }
    }
}
