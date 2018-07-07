using Controllers;
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
    public partial class frmListaAlunos : Form
    {
        public frmListaAlunos()
        {
            InitializeComponent();
        }
        

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            // Preencher lista ao carregar a tela (LOAD)
            AlunosController alunosController = new AlunosController();
            dgvAlunos.DataSource = alunosController.ListarTodos();
        }
    }
}
