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
    public partial class FormIntegral : Form
    {
        public FormIntegral()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.textBoxY.Text = "n.X^p + Kdx";
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + Kdx";
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + Kdx";
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + n.X^p + Kdx";
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + n.X^p + n.X^p + Kdx";
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Form1 frmUtama = new Form1();
            frmUtama.Show();
            this.Hide();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FormIntegralProses frmIntegralProses = new FormIntegralProses();
                frmIntegralProses.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                FormIntegralProses2 frmIntegralProses2 = new FormIntegralProses2();
                frmIntegralProses2.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                FormIntegralProses3 frmIntegralProses3 = new FormIntegralProses3();
                frmIntegralProses3.Show();
                this.Hide();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                FormIntegralProses4 frmIntegralProses4 = new FormIntegralProses4();
                frmIntegralProses4.Show();
                this.Hide();
            }
        }
    }
}
