/* Projeto: Desafio Programação – Jornada Labs HAVAN - Parte 2
 * Autor: Natan Colavite Dellagiustina
 * Data: 22/05/2021
 * Tela: frmRegister.cs
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
using System.Data.SqlClient;
using System.Globalization;

namespace OperationManagement
{
    public partial class Register : Form
    {
        //ALTERAR AQUI O FILENAME PARA A POSTA O LOCAL DO ARQUIVO EM SEU COMPUTADOR
        string fileName = @"C:\Users\natan\Desktop\operationManagement\OperationManagement\Database1.mdf";

        // CONSTANTES DE CONVERSÃO
        // valores obtidos em 16/05/2021. fonte: www.google.com (googlefinance - https://www.google.com/intl/en/googlefinance/disclaimer/)
        // valor base: 1 dólar americano

        const double americanDollarValue = 1.00;
        const double canadianDollarValue = 1.21;
        const double euroValue = 0.82;
        const double swissFrancValue = 0.9;
        const double yenValue = 109.30;
        const double poundSterlingValue = 0.71;
        const double pesoArgentinoValue = 93.93;
        const double realValue = 5.27;

        // ORDEM do Combo Box
        //US$ (Dólar Americano)
        //CA$ (Dolar Canadense)
        //€ (Euro)
        //CHF(Franco Suíco)
        //¥ (Iene)
        //£ (Libra Esterlina)
        //AR$ (Peso Argentino)
        //R$ (Real)

        double[] currencyValue = new double[] { americanDollarValue, canadianDollarValue, euroValue, swissFrancValue, yenValue, poundSterlingValue, pesoArgentinoValue, realValue };

        public Register()
        {
            InitializeComponent();
            this.ActiveControl = txtFullName;
            cbOriginCurrency.SelectedIndex = 1;
            cbDestinyCurrency.SelectedIndex = 7;
            btnSave.Enabled = true;
        }
        /// <summary>
        /// Evento do aplicativo para limpar os campos digitados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //limpa todos os campos variáveis (textbox, listview e label), questionando antes de confirmar
            const string message = "Você realmente deseja limpar todas as informações desta tela? Não será possível recupera-las!";
            var result = MessageBox.Show(message, "Deseja limpar?",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearFields();
            }
        }

        /// <summary>
        /// Método para limpar todos os campos variáveis
        /// </summary>
        private void ClearFields()
        {
            txtFullName.Text = "";
            cbOriginCurrency.SelectedIndex = 1;
            cbDestinyCurrency.SelectedIndex = 7;
            dtpDate.Text = "";
            txtOriginalValue.Text = "";
            txtConvertedValue.Text = "";
            btnConvert.Enabled = false;
            btnSave.Enabled = true;
            txtFullName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento para salvar os dados na database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            validateInput();                        
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Validação dos dados para serem inseridos na database
        /// </summary>
        public void validateInput()
        {
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("O nome deve ser preenchido!");
                txtFullName.Focus();
            }
            else if (cbOriginCurrency.SelectedItem == null)
            {
                MessageBox.Show("A moeda de origem deve ser selecionada!");
                cbOriginCurrency.Focus();
            }
            else if (cbDestinyCurrency.SelectedItem == null)
            {
                MessageBox.Show("A moeda de destino deve ser selecionada!");
                cbDestinyCurrency.Focus();
            }
            else if (cbOriginCurrency.SelectedItem == cbDestinyCurrency.SelectedItem)
            {
                MessageBox.Show("As moedas selecionadas são as mesmas! Selecione duas diferentes para prosseguir");
                cbDestinyCurrency.Focus();
            }
            else if (dtpDate.Text == string.Empty)
            {
                MessageBox.Show("A data deve ser selecionada");
                dtpDate.Focus();
            }
            else if (txtOriginalValue.Text == string.Empty)
            {
                MessageBox.Show("O valor original deve ser digitado");
                txtOriginalValue.Focus();
            }
            else
            {
                insertIntoDB();
            }
        }

        /// <summary>
        /// Salva os dados na database
        /// </summary>
        private void insertIntoDB()
        {
            // variáveis para inserir na database
            string fullName = txtFullName.Text;
            string originCurrency = cbOriginCurrency.SelectedItem.ToString();
            string destinyCurrency = cbDestinyCurrency.SelectedItem.ToString();
            string date = dtpDate.Value.ToString("MM/dd/yyyy");
            string originalValue = txtOriginalValue.Text;
            string convertedValue = txtConvertedValue.Text;

            #region insere os dados na tabela
            //conexão com db no VS            
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + ";Integrated Security=True";
            SqlConnection dbConnection = new SqlConnection(con);

            //query para inserir os dados
            SqlCommand command = new SqlCommand("INSERT INTO Operations VALUES('" + fullName + "', '" + originCurrency + "', '" + destinyCurrency + "', '" +
                date + "', " + originalValue + ", " + convertedValue + ")", dbConnection);
            //tenta inserir os dados conectando na database
            try
            {
                dbConnection.Open();
                int resultado = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataException("Algo deu errado... ", ex);
            }
            finally
            {
                dbConnection.Close();
                MessageBox.Show("Dados salvos com sucesso!");
            }
            #endregion

            ClearFields();
        }
        /// <summary>
        /// Valida o input para ver se é decimal
        /// Adaptado de: https://stackoverflow.com/questions/2108616/validation-textboxes-allowing-only-decimals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void txtValidateValue(object sender, KeyPressEventArgs e)
        {
            if (!isNumber(e.KeyChar, txtOriginalValue.Text))
                e.Handled = true;
        }
        /// <summary>
        /// Método para validar o número
        /// </summary>
        /// <param name="ch"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool isNumber(char ch, string text)
        {
            bool res = true;
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            //check if it´s a decimal separator and if doesn´t already have one in the text string
            if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
            {
                res = false;
                return res;
            }

            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
                res = false;

            return res;
        }
        /// <summary>
        /// Converte o valor de destino de acordo com os valores de origem e destino selecionados e o valor original
        /// Além disso, habilita o botão de salvar novamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            int origem = cbOriginCurrency.SelectedIndex;
            int destino = cbDestinyCurrency.SelectedIndex;
            double originalValue;
            if (txtOriginalValue.Text == "")
            {
                originalValue = 0;
            }
            else
            {
                originalValue = Convert.ToDouble(txtOriginalValue.Text);
            }
            double inputCurrency = americanDollarValue / currencyValue[origem];
            double outputCurrency = currencyValue[destino];
            txtConvertedValue.Text = (originalValue * inputCurrency * outputCurrency).ToString("0.##");
            btnSave.Enabled = true;
        }
        /// <summary>
        /// Evento para desabilitar o botão de salvar caso haja alguma alteração que vá alterar o valor convertido, habilitando o botão de conversão novamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertAgain(object sender, EventArgs e)
        {
            btnConvert.Enabled = true;
            btnSave.Enabled = false;
        }
    }
}
