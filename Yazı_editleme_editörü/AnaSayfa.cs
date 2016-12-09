using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Yazı_editleme_editörü
{
    public partial class AnaSayfa : MetroForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Editor edtr = new Editor();
            edtr.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            editor_avcisii adtravc = new editor_avcisii();
            adtravc.ShowDialog();
        }
    }
}
