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
    public partial class FormIntegralProses2 : Form
    {
        public FormIntegralProses2()
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
            FormIntegral frmIntegral = new FormIntegral();
            frmIntegral.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxn1.Clear();
            textBoxp1.Clear();
            textBoxn2.Clear();
            textBoxp2.Clear();
            textBoxK.Clear();

            textBoxY.Clear();
            textBoxNY1.Clear();
            textBoxNY2.Clear();
            textBoxNY3.Clear();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxn1.Text) || string.IsNullOrEmpty(textBoxp1.Text) || string.IsNullOrEmpty(textBoxK.Text))
            {
                MessageBox.Show("Harus di isi dulu bro!!");
            }
            else
            {
                int n1, p1, n2, p2;
                int jumlahPangkat1, jumlahPangkat2;
                int k;
                n1 = int.Parse(textBoxn1.Text);
                p1 = int.Parse(textBoxp1.Text);
                n2 = int.Parse(textBoxn2.Text);
                p2 = int.Parse(textBoxp2.Text);
                k = int.Parse(textBoxK.Text);

                jumlahPangkat1 = p1 + 1;
                jumlahPangkat2 = p2 + 1;

                this.textBoxY.Text = "n.X^p + n.X^p + Kdx";
                this.textBoxNY1.Text = n1 + ".x^" + p1 + " + " + n2 + ".x^" + p2 + " + " + k + "dx";
                this.textBoxNY2.Text = n1 + "/" + "(" + p1 + "+1" + ")" + ".x^" + "(" + p1 + "+1" + ")" + " + " + n2 + "/" + "(" + p2 + "+1" + ")" + ".x^" + "(" + p2 + "+1" + ")" + " + " + k + "x" + " + " + "C";
                this.textBoxNY3.Text = n1 + "/" + jumlahPangkat1 + ".x^" + jumlahPangkat1 + " + " + n2 + "/" + jumlahPangkat2 + ".x^" + jumlahPangkat2 + " + " + k + "x" + " + " + "C";
            }
        }
    }
}
