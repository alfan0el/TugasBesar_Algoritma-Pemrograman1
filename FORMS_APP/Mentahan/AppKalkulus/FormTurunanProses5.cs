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
    public partial class FormTurunanProses5 : Form
    {
        public FormTurunanProses5()
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
                int n1, p1, n2, p2, n3, p3, n4, p4, n5, p5;
                int jumlahn1, jumlahPangkat1, jumlahn2, jumlahPangkat2, jumlahn3, jumlahPangkat3, jumlahn4, jumlahPangkat4, jumlahn5, jumlahPangkat5;
                n1 = int.Parse(textBoxn1.Text);
                p1 = int.Parse(textBoxp1.Text);
                n2 = int.Parse(textBoxn2.Text);
                p2 = int.Parse(textBoxp2.Text);
                n3 = int.Parse(textBoxn3.Text);
                p3 = int.Parse(textBoxp3.Text);
                n4 = int.Parse(textBoxn4.Text);
                p4 = int.Parse(textBoxp4.Text);
                n5 = int.Parse(textBoxn5.Text);
                p5 = int.Parse(textBoxp5.Text);

                jumlahn1 = n1 * p1;
                jumlahPangkat1 = p1 - 1;

                jumlahn2 = n2 * p2;
                jumlahPangkat2 = p2 - 1;

                jumlahn3 = n3 * p3;
                jumlahPangkat3 = p3 - 1;

                jumlahn4 = n4 * p4;
                jumlahPangkat4 = p4 - 1;

                jumlahn5 = n5 * p5;
                jumlahPangkat5 = p5 - 1;

                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + n.X^p + n.X^p";
                this.textBoxNY1.Text = n1 + ".x^" + p1 + " + " + n2 + ".x^" + p2 + " + " + n3 + ".x^" + p3 + " + " + n4 + ".x^" + p4 + " + " + n5 + ".x^" + p5;
                this.textBoxNY2.Text = jumlahn1 + ".x^" + jumlahPangkat1 + " + " + jumlahn2 + ".x^" + jumlahPangkat2 + " + " + jumlahn3 + ".x^" + jumlahPangkat3 + " + " + jumlahn4 + ".x^" + jumlahPangkat4 + " + " + jumlahn5 + ".x^" + jumlahPangkat5;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxn1.Clear();
            textBoxp1.Clear();
            textBoxn2.Clear();
            textBoxp2.Clear();
            textBoxn3.Clear();
            textBoxp3.Clear();
            textBoxn4.Clear();
            textBoxp4.Clear();
            textBoxn5.Clear();
            textBoxp5.Clear();
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
