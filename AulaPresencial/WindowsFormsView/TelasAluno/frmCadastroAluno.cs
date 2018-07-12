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

namespace WindowsFormsView.TelasAluno
{
    public partial class FrmCadastroAluno : Form
    {
        public FrmCadastroAluno()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty; //""
            txtMatricula.Text = string.Empty;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno = new Aluno
            {
                Nome = txtNome.Text,
                Matricula = int.Parse(txtMatricula.Text)
            };

            AlunosController alunosController = new AlunosController();
            alunosController.Inserir(novoAluno);
        }
    }
}
