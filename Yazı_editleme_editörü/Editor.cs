using System;
using System.Collections;
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
    public partial class Editor : MetroForm
    {
        public Editor()
        {
            InitializeComponent();
        }
        StreamReader sr;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex(txt_search.Text);
                richTextBox1.Text = regex.Replace(richTextBox1.Text, txt_edit.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"www.ebubekirbastama.com");
            }
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
        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ebubekirbastama.com");
        }
        private void Editor_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
    }
}
