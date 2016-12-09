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
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Yazı_editleme_editörü
{
    public partial class editor_avcisii : MetroForm
    {
        public editor_avcisii()
        {
            InitializeComponent();
        }
        StreamReader sr;
        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ebubekirbastama.com");
        }
        private void editor_avcisii_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                sr = File.OpenText(openFileDialog1.FileName.ToString());
                var s = sr.ReadToEnd();
                richTextBox1.Text = s;
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "www.ebubekirbastama.com");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Text = Regex.Matches(richTextBox1.Text, txt_search.Text, RegexOptions.Multiline).Count + "adet";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "www.ebubekirbastama.com");
            }
        }
    }
}
