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
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty; //""
            txtCadastro.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor novoProfessor = new Professor();

            novoProfessor.Nome = txtNome.Text;
            novoProfessor.Matricula = int.Parse(txtCadastro.Text);

            ProfessorController professoresController = new ProfessoresController();
            professorController.Inserir(novoProfessor);
        }
    }
}
