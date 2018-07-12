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

namespace WindowsFormsView.Disciplina
{
    public partial class frmListaDisciplinas : Form
    {
        public frmListaDisciplinas()
        {
            InitializeComponent();
        }

        private void frmListaDisciplinas_Load(object sender, EventArgs e)
        {
            DisciplinasController disciplinasController = new DisciplinasController();
            dgvDisciplinas.DataSource = disciplinasController.ListarTodos();
        }
    }
}
