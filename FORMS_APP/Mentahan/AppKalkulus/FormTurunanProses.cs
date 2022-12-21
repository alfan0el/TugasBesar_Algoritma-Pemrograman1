using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppKalkulus
{
    public partial class FormTurunanProses : Form
    {
        public FormTurunanProses()
        {
            InitializeComponent();
        }

        private void buttonMenuUtama_Click(object sender, EventArgs e)
        {
            Form1 frmUtama = new Form1();
            frmUtama.Show();
            this.Hide();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormTurunan frmTurunan = new FormTurunan();
            frmTurunan.Show();
            this.Hide();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxn1.Text) || string.IsNullOrEmpty(textBoxp1.Text))
            {
                MessageBox.Show("Harus di isi dulu bro!!");
            }
            else
            {
                int n1, p1, jumlahn1, jumlahPangkat1;
                n1 = int.Parse(textBoxn1.Text);
                p1 = int.Parse(textBoxp1.Text);

                jumlahn1 = n1 * p1;
                jumlahPangkat1 = p1 - 1;

                this.textBoxY.Text = "n.X^p";
                this.textBoxNY1.Text = n1 + ".x^" + p1;
                this.textBoxNY2.Text = jumlahn1 + ".x^" + jumlahPangkat1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxn1.Clear();
            textBoxp1.Clear();
            textBoxY.Clear();
            textBoxNY1.Clear();
            textBoxNY2.Clear();
        }
    }
}
