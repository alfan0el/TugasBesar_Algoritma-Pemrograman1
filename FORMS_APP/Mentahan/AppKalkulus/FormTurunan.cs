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
    public partial class FormTurunan : Form
    {
        public FormTurunan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.textBoxY.Text = "n.X^p";
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                this.textBoxY.Text = "n.X^p + n.X^p";
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p";
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + n.X^p";
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                this.textBoxY.Text = "n.X^p + n.X^p + n.X^p + n.X^p + n.X^p";
            }
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                FormTurunanProses frmTurunanProses = new FormTurunanProses();
                frmTurunanProses.Show();
                this.Hide();
            }
            
            else if (comboBox1.SelectedIndex == 1)
            {
                FormTurunanProses2 frmTurunanProses2 = new FormTurunanProses2();
                frmTurunanProses2.Show();
                this.Hide();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                FormTurunanProses3 frmTurunanProses3 = new FormTurunanProses3();
                frmTurunanProses3.Show();
                this.Hide();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                FormTurunanProses4 frmTurunanProses4 = new FormTurunanProses4();
                frmTurunanProses4.Show();
                this.Hide();
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                FormTurunanProses5 frmTurunanProses5 = new FormTurunanProses5();
                frmTurunanProses5.Show();
                this.Hide();
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Form1 frmUtama = new Form1();
            frmUtama.Show();
            this.Hide();
        }
    }
}
