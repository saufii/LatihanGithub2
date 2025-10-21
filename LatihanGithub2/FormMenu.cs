using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGithub2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void SiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("loading...");
            FormSiswa f = new FormSiswa();
            f.ShowDialog();
            this.Hide();
        }

        private void JurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("loading...");
            FormJurusan f = new FormJurusan();
            f.ShowDialog();
            this.Hide();
        }
    }
}
