namespace AppKalkulus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTurunan frmTurunan = new FormTurunan();
            frmTurunan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormIntegral frmIntegral = new FormIntegral();
            frmIntegral.Show();
            this.Hide();
        }
    }
}