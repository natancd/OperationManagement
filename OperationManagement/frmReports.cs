/* Projeto: Desafio Programação – Jornada Labs HAVAN - Parte 2
 * Autor: Natan Colavite Dellagiustina
 * Data: 22/05/2021
 * Tela: frmReports.cs
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationManagement
{
    public partial class frmReports : Form
    {

        // variáveis para inserir na database
        string fullName;
        bool dateSelected = true;
        string initialDate = "";
        string finalDate = "";
        const double taxValue = 10.00; //%

        //ALTERAR AQUI O FILENAME PARA A POSTA O LOCAL DO ARQUIVO EM SEU COMPUTADOR
        const string fileName = @"C:\Users\natan\Desktop\operationManagement\OperationManagement\Database1.mdf";

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Método para verificar os valores do filtro
        /// </summary>
        protected void validateFilters()
        {
            if (txtClientName.Text == null || txtClientName.Text == string.Empty)
            {
                fullName = "";
            }
            else
            {
                fullName = txtClientName.Text;
            }

            if (cbDate.Checked)
            {
                dateSelected = true;
                initialDate = dtpInitialDate.Value.ToString("MM/dd/yyyy");
                finalDate = dtpFinalDate.Value.ToString("MM/dd/yyyy");
            }
            else
            {
                dateSelected = false;
            }
        }
        /// <summary>
        /// Método para calcular e disponibilizar a Lista de Operações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperationsList_Click(object sender, EventArgs e)
        {
            lvwOperationsLlist.Items.Clear();
            validateFilters();

            #region seleciona os dados da tabela
            //conexão com db no VS            
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + ";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(con);

            //query para selecionar os dados            
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Operations ");
            if (fullName != "")
            {
                sb.Append("WHERE FullName like '%" + fullName + "%' ");
                if (cbDate.Checked)
                {
                    sb.Append("AND Date BETWEEN '" + initialDate + "' AND '" + finalDate + "' ");                    
                }
                sb.Append("ORDER BY FullName ASC");
            }
            else if (cbDate.Checked)
            {
                sb.Append("WHERE Date BETWEEN '" + initialDate + "' AND '" + finalDate + "'");
            }

            SqlCommand command = new SqlCommand(sb.ToString(), dbConnection);
            //tenta inserir os dados conectando na database
            try
            {
                dbConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // lista todos os itens da query no list view da tela
                        ListViewItem list = new ListViewItem();
                        list.Text = reader.GetValue(0).ToString();
                        list.SubItems.Add(reader.GetValue(1).ToString());
                        list.SubItems.Add(reader.GetValue(2).ToString());
                        list.SubItems.Add(reader.GetValue(3).ToString());
                        list.SubItems.Add(reader.GetValue(4).ToString());
                        list.SubItems.Add(reader.GetValue(5).ToString());
                        list.SubItems.Add(reader.GetValue(6).ToString());
                        lvwOperationsLlist.Items.Add(list);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Algo deu errado... ", ex);
            }
            finally
            {
                dbConnection.Close();
            }
            #endregion
        }
        /// <summary>
        /// Desabilita ou habilita o campo para filtro da data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDate.Checked)
            {
                dtpInitialDate.Enabled = true;
                dtpFinalDate.Enabled = true;
            }
            else
            {
                dtpInitialDate.Enabled = false;
                dtpFinalDate.Enabled = false;
            }
        }

        private void lvwPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Método para calcular e mostrar o Valor Total das Operações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotalOperationsValues_Click(object sender, EventArgs e)
        {
            validateFilters();
            double totalConvertedValues;

            #region seleciona os dados da tabela
            //conexão com db no VS            
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + ";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(con);            

            //query para selecionar os dados            
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT SUM(OriginalValue) FROM Operations ");
            if (fullName != "")
            {
                sb.Append("WHERE FullName like '%" + fullName + "%' ");
                if (cbDate.Checked)
                {
                    sb.Append("AND Date BETWEEN '" + initialDate + "' AND '" + finalDate + "' ");
                }
            }
            else if (cbDate.Checked)
            {
                sb.Append("WHERE Date BETWEEN '" + initialDate + "' AND '" + finalDate + "'");
            }
            SqlCommand command = new SqlCommand(sb.ToString(), dbConnection);            

            //tenta inserir os dados conectando na database
            try
            {
                dbConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalConvertedValues = Convert.ToDouble(reader.GetValue(0));
                        MessageBox.Show("Total das taxas operações: " + totalConvertedValues.ToString("0.##"));
                    }
                }                
            }
            catch (Exception ex)
            {
                throw new DataException("Algo deu errado... ", ex);
            }
            finally
            {            
                dbConnection.Close();
            }
            #endregion
        }
        /// <summary>
        /// Método para calcular e mostrar o Valor Total das Taxas das Operações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotalTaxValues_Click(object sender, EventArgs e)
        {
            validateFilters();
            double totalConvertedValues;

            #region seleciona os dados da tabela
            //conexão com db no VS            
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + ";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(con);            

            //query para selecionar os dados            
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT SUM(OriginalValue) FROM Operations ");
            if (fullName != "")
            {
                sb.Append("WHERE FullName like '%" + fullName + "%' ");
                if (cbDate.Checked)
                {
                    sb.Append("AND Date BETWEEN '" + initialDate + "' AND '" + finalDate + "' ");
                }
            }
            else if (cbDate.Checked)
            {
                sb.Append("WHERE Date BETWEEN '" + initialDate + "' AND '" + finalDate + "'");
            }
            SqlCommand command = new SqlCommand(sb.ToString(), dbConnection);            

            //tenta inserir os dados conectando na database
            try
            {
                dbConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        totalConvertedValues = Convert.ToDouble(reader.GetValue(0));
                        double totalTaxValues = taxValue/100 * totalConvertedValues;
                        MessageBox.Show("Total das taxas operações: " + totalTaxValues.ToString("0.##") + " (" + taxValue + "% de " + totalConvertedValues + " - valores originais)");
                    }
                }                
            }
            catch (Exception ex)
            {
                throw new DataException("Algo deu errado... ", ex);
            }
            finally
            {            
                dbConnection.Close();
            }
            #endregion
        }
    }
}
