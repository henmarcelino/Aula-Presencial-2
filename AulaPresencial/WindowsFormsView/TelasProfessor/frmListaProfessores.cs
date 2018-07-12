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

namespace WindowsFormsView.TelasProfessor
{
    public partial class FrmListaProfessores : Form
    {
        public FrmListaProfessores()
        {
            InitializeComponent();
        }

        private void FrmListaProfessores_Load(object sender, EventArgs e)
        {
            ProfessoresController professoresController = new ProfessoresController();
            dgvProfessores.DataSource = professoresController.ListarTodos();
        }
    }
}
