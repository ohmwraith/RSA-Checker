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

namespace RSASignatureWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(512);
        byte[] raw_data;

        private void создатьПаруToolStripMenuItem_Click(object sender, EventArgs e)
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
            signature = RSA.SignData(raw_data, new MD5CryptoServiceProvider());
            File.WriteAllBytes(sfd.FileName, signature);
            MessageBox.Show("Подпись успешно сохранена", "Подпись RSA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
