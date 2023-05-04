using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace RSASignatureWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
        }
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(3072);
        HashAlgorithm hash;
        byte[] raw_data;

        private void ОбновитьКлючиRSA_Click(object sender, EventArgs e)
        {
            RSA = new RSACryptoServiceProvider(512);
            MessageBox.Show("Ключи успешно обновлены", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сохранитьПаруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранение пары ключей RSA";
            sfd.DefaultExt = ".pem";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(sfd.FileName, RSA.ToXmlString(true));
        }

        private void сохранитьОткрытыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранение открытого ключа RSA";
            sfd.DefaultExt = ".pub";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(sfd.FileName, RSA.ToXmlString(false));
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            raw_data = File.ReadAllBytes(ofd.FileName);
            richTextBox1.Text = Encoding.UTF8.GetString(raw_data);
        }

        private void подписатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить подпись как ...";
            if (sfd.ShowDialog() != DialogResult.OK) return;
            byte[] signature;
            signature = RSA.SignData(raw_data, hash);
            File.WriteAllBytes(sfd.FileName, signature);
            MessageBox.Show("Подпись успешно сохранена", "Подпись RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    hash = HashAlgorithm.Create("MD5");
                    break;
                case 1:
                    hash = HashAlgorithm.Create("SHA-1");
                    break;
                case 2:
                    hash = HashAlgorithm.Create("SHA-256");
                    break;
                case 3:
                    hash = HashAlgorithm.Create("SHA-384");
                    break;
                case 4:
                    hash = HashAlgorithm.Create("SHA-512");
                    break;

            }


        }

        private void верификацияПодписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открытие исходного файла и чтение из него информации в переменную text
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            byte[] signature = File.ReadAllBytes(ofd.FileName);
            if (RSA.VerifyData(raw_data, hash, signature))
            {
                MessageBox.Show("Подпись верна", "Подпись RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Подпись не верна", "Подпись RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void открытьКлюч_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            try
            {
                RSA.FromXmlString(File.ReadAllText(ofd.FileName));
                MessageBox.Show("Ключ успешно загружен", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Security.XmlSyntaxException)
            {
                MessageBox.Show("Файл не является ключом", "Ключи RSA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
