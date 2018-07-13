using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView.TelasProfessor
{
    public partial class FrmCadastroProfessor : Form
    {
        public FrmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty; //""
            txtCadastro.Text = string.Empty;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Professor novoProfessor = new Professor();
            
            novoProfessor.Nome = txtNome.Text;
            novoProfessor.Cadastro = int.Parse(txtCadastro.Text);
            

            ProfessoresController professoresController = new ProfessoresController();
            professoresController.Inserir(novoProfessor);
        }
    }
}
