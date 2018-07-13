using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView.TelasProfessor;
using WindowsFormsView.TelasAluno;
using WindowsFormsView.TelasDisciplina;

namespace WindowsFormsView
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno cadAluno = new FrmCadastroAluno();
            cadAluno.ShowDialog();
        }

        private void btnListarAluno_Click(object sender, EventArgs e)
        {
            frmListaAlunos listaAlunos = new frmListaAlunos();
            listaAlunos.ShowDialog();
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            FrmCadastroProfessor cadProfessor = new FrmCadastroProfessor();
            cadProfessor.ShowDialog();
        }

        private void btnListarProfessor_Click(object sender, EventArgs e)
        {
            FrmListaProfessores listProfessores = new FrmListaProfessores();
            listProfessores.ShowDialog();
        }

        private void btnCadastrarMateria_Click(object sender, EventArgs e)
        {
            FrmCadastroDisciplina cadDisciplina = new FrmCadastroDisciplina();
            cadDisciplina.ShowDialog();
        }

        private void btnListarMateria_Click(object sender, EventArgs e)
        {
            frmListaDisciplinas listDisciplinas = new frmListaDisciplinas();
            listDisciplinas.ShowDialog();
        }
    }
}
