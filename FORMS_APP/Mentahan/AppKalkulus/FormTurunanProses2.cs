using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKalkulus
{
    public partial class FormTurunanProses2 : Form
    {
        public FormTurunanProses2()
        {
            InitializeComponent();
        }
        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxn1.Text) || string.IsNullOrEmpty(textBoxp1.Text))
            {
                MessageBox.Show("Harus di isi dulu bro!!");
            }
            else
            {
                int n1, p1, n2, p2, jumlahn1, jumlahn2, jumlahPangkat1, jumlahPangkat2;
                n1 = int.Parse(textBoxn1.Text);
                p1 = int.Parse(textBoxp1.Text);
                n2 = int.Parse(textBoxn2.Text);
                p2 = int.Parse(textBoxp2.Text);

                jumlahn1 = n1 * p1;
                jumlahPangkat1 = p1 - 1;

                jumlahn2 = n2 * p2;
                jumlahPangkat2 = p2 - 1;

                this.textBoxY.Text = "n.X^p + n.X^p";
                this.textBoxNY1.Text = n1 + ".x^" + p1 + " + " + n2 + ".x^" + p2;
                this.textBoxNY2.Text = jumlahn1 + ".x^" + jumlahPangkat1 + " + " + jumlahn2 + ".x^" + jumlahPangkat2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxn1.Clear();
            textBoxp1.Clear();
            textBoxn2.Clear();
            textBoxp2.Clear();
            textBoxY.Clear();
            textBoxNY1.Clear();
            textBoxNY2.Clear();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormTurunan frmTurunan = new FormTurunan();
            frmTurunan.Show();
            this.Hide();
        }

        private void buttonMenuUtama_Click(object sender, EventArgs e)
        {
            Form1 frmUtama = new Form1();
            frmUtama.Show();
            this.Hide();
        }
    }
}
