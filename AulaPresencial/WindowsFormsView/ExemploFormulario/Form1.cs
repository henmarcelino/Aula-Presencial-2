using System;
using System.Windows.Forms;

namespace WindowsFormsView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCancelar.Text = "Abrir Form2";
            btnConfirmar.Text = "Confirmar";

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //f2.Show();
            // this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
        }
    }
}
