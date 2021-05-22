/* Projeto: Desafio Programação – Jornada Labs HAVAN - Parte 2
 * Autor: Natan Colavite Dellagiustina
 * Data: 22/05/2021
 * Tela: frmOperationManagement.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationManagement
{
    public partial class OperationManagementForm : Form
    {
        public OperationManagementForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // sai do programa, qustionando antes de confirmar
            const string message = "Você realmente deseja sair do programa?";
            var result = MessageBox.Show(message, "Deseja sair?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.ShowDialog();
        }

        private void OperationManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
