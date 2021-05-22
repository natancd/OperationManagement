namespace OperationManagement
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblOriginCurrency = new System.Windows.Forms.Label();
            this.lblDestinyCurrency = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOriginalValue = new System.Windows.Forms.Label();
            this.lblConvertedValue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtOriginalValue = new System.Windows.Forms.TextBox();
            this.txtConvertedValue = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.cbOriginCurrency = new System.Windows.Forms.ComboBox();
            this.cbDestinyCurrency = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnConvert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(75, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(112, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Nome Completo:";
            // 
            // lblOriginCurrency
            // 
            this.lblOriginCurrency.AutoSize = true;
            this.lblOriginCurrency.Location = new System.Drawing.Point(62, 78);
            this.lblOriginCurrency.Name = "lblOriginCurrency";
            this.lblOriginCurrency.Size = new System.Drawing.Size(125, 17);
            this.lblOriginCurrency.TabIndex = 2;
            this.lblOriginCurrency.Text = "Moeda de Origem:";
            // 
            // lblDestinyCurrency
            // 
            this.lblDestinyCurrency.AutoSize = true;
            this.lblDestinyCurrency.Location = new System.Drawing.Point(60, 108);
            this.lblDestinyCurrency.Name = "lblDestinyCurrency";
            this.lblDestinyCurrency.Size = new System.Drawing.Size(127, 17);
            this.lblDestinyCurrency.TabIndex = 4;
            this.lblDestinyCurrency.Text = "Moeda de Destino:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(58, 135);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Data da Operação:";
            // 
            // lblOriginalValue
            // 
            this.lblOriginalValue.AutoSize = true;
            this.lblOriginalValue.Location = new System.Drawing.Point(89, 163);
            this.lblOriginalValue.Name = "lblOriginalValue";
            this.lblOriginalValue.Size = new System.Drawing.Size(98, 17);
            this.lblOriginalValue.TabIndex = 8;
            this.lblOriginalValue.Text = "Valor Original:";
            // 
            // lblConvertedValue
            // 
            this.lblConvertedValue.AutoSize = true;
            this.lblConvertedValue.Location = new System.Drawing.Point(70, 191);
            this.lblConvertedValue.Name = "lblConvertedValue";
            this.lblConvertedValue.Size = new System.Drawing.Size(117, 17);
            this.lblConvertedValue.TabIndex = 10;
            this.lblConvertedValue.Text = "Valor Convertido:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(86, 219);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(101, 17);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Taxa Cobrada:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Salvar";
            this.toolTip1.SetToolTip(this.btnSave, "Salvar as informações no banco de dados");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(282, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 31);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "&Limpar";
            this.toolTip1.SetToolTip(this.btnReset, "Limpar todas as informações digitadas");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(459, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "&Cancelar";
            this.toolTip1.SetToolTip(this.btnCancel, "Voltar para a tela inicial");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(193, 44);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(324, 22);
            this.txtFullName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFullName, "Digite o nome do completo");
            // 
            // txtOriginalValue
            // 
            this.txtOriginalValue.Location = new System.Drawing.Point(193, 163);
            this.txtOriginalValue.Name = "txtOriginalValue";
            this.txtOriginalValue.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalValue.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtOriginalValue, "Digite o valor a ser convertido");
            this.txtOriginalValue.TextChanged += new System.EventHandler(this.convertAgain);
            this.txtOriginalValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidateValue);
            // 
            // txtConvertedValue
            // 
            this.txtConvertedValue.Enabled = false;
            this.txtConvertedValue.Location = new System.Drawing.Point(193, 191);
            this.txtConvertedValue.Name = "txtConvertedValue";
            this.txtConvertedValue.Size = new System.Drawing.Size(100, 22);
            this.txtConvertedValue.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtConvertedValue, "Valor convertido");
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(193, 219);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(70, 22);
            this.txtTax.TabIndex = 13;
            this.txtTax.Text = "10%";
            this.toolTip1.SetToolTip(this.txtTax, "Taxa fixa de cobrança");
            // 
            // cbOriginCurrency
            // 
            this.cbOriginCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOriginCurrency.FormattingEnabled = true;
            this.cbOriginCurrency.Items.AddRange(new object[] {
            "US$ (Dólar Americano)",
            "CA$ (Dolar Canadense)",
            "€ (Euro)",
            "CHF (Franco Suíco)",
            "¥ (Iene)",
            "£ (Libra Esterlina)",
            "AR$ (Peso Argentino)",
            "R$ (Real)"});
            this.cbOriginCurrency.Location = new System.Drawing.Point(193, 75);
            this.cbOriginCurrency.Name = "cbOriginCurrency";
            this.cbOriginCurrency.Size = new System.Drawing.Size(177, 24);
            this.cbOriginCurrency.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cbOriginCurrency, "Selecione a moeda de origem");
            this.cbOriginCurrency.SelectedIndexChanged += new System.EventHandler(this.convertAgain);
            // 
            // cbDestinyCurrency
            // 
            this.cbDestinyCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinyCurrency.FormattingEnabled = true;
            this.cbDestinyCurrency.Items.AddRange(new object[] {
            "US$ (Dólar Americano)",
            "CA$ (Dolar Canadense)",
            "€ (Euro)",
            "CHF (Franco Suíco)",
            "¥ (Iene)",
            "£ (Libra Esterlina)",
            "AR$ (Peso Argentino)",
            "R$ (Real)"});
            this.cbDestinyCurrency.Location = new System.Drawing.Point(193, 105);
            this.cbDestinyCurrency.Name = "cbDestinyCurrency";
            this.cbDestinyCurrency.Size = new System.Drawing.Size(177, 24);
            this.cbDestinyCurrency.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbDestinyCurrency, "Selecione a moeda de destino");
            this.cbDestinyCurrency.SelectedIndexChanged += new System.EventHandler(this.convertAgain);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(194, 135);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(256, 22);
            this.dtpDate.TabIndex = 17;
            this.toolTip1.SetToolTip(this.dtpDate, "Selecione a data da operação");
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(322, 189);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(80, 27);
            this.btnConvert.TabIndex = 18;
            this.btnConvert.Text = "Converter";
            this.toolTip1.SetToolTip(this.btnConvert, "Clique para converter o valor original de acordo com as moedas selecionadas");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Register
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(673, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbDestinyCurrency);
            this.Controls.Add(this.cbOriginCurrency);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtConvertedValue);
            this.Controls.Add(this.txtOriginalValue);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblConvertedValue);
            this.Controls.Add(this.lblOriginalValue);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDestinyCurrency);
            this.Controls.Add(this.lblOriginCurrency);
            this.Controls.Add(this.lblFullName);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblOriginCurrency;
        private System.Windows.Forms.Label lblDestinyCurrency;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOriginalValue;
        private System.Windows.Forms.Label lblConvertedValue;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtOriginalValue;
        private System.Windows.Forms.TextBox txtConvertedValue;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.ComboBox cbOriginCurrency;
        private System.Windows.Forms.ComboBox cbDestinyCurrency;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}