namespace OperationManagement
{
    partial class frmReports
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
            this.btnOperationsList = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnTotalOperationsValues = new System.Windows.Forms.Button();
            this.btnTotalTaxValues = new System.Windows.Forms.Button();
            this.lblFilterReport = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinalDate = new System.Windows.Forms.Label();
            this.lblInitialDate = new System.Windows.Forms.Label();
            this.lblNameReport = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lvwOperationsLlist = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOriginCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnColumnDestiny = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValueConverted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOperationsList = new System.Windows.Forms.Label();
            this.columnNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOperationsList
            // 
            this.btnOperationsList.AutoSize = true;
            this.btnOperationsList.Location = new System.Drawing.Point(451, 91);
            this.btnOperationsList.Name = "btnOperationsList";
            this.btnOperationsList.Size = new System.Drawing.Size(142, 27);
            this.btnOperationsList.TabIndex = 0;
            this.btnOperationsList.Text = "Lista de Operações";
            this.toolTip1.SetToolTip(this.btnOperationsList, "Lista de todas as operações registradas");
            this.btnOperationsList.UseVisualStyleBackColor = true;
            this.btnOperationsList.Click += new System.EventHandler(this.btnOperationsList_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Location = new System.Drawing.Point(269, 340);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(88, 31);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "&Voltar";
            this.toolTip1.SetToolTip(this.btnReturn, "Voltar para a tela inicial");
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnTotalOperationsValues
            // 
            this.btnTotalOperationsValues.AutoSize = true;
            this.btnTotalOperationsValues.Location = new System.Drawing.Point(405, 141);
            this.btnTotalOperationsValues.Name = "btnTotalOperationsValues";
            this.btnTotalOperationsValues.Size = new System.Drawing.Size(188, 27);
            this.btnTotalOperationsValues.TabIndex = 18;
            this.btnTotalOperationsValues.Text = "Valor Total das Operações";
            this.toolTip1.SetToolTip(this.btnTotalOperationsValues, "Valor total de todas as operações registradas");
            this.btnTotalOperationsValues.UseVisualStyleBackColor = true;
            this.btnTotalOperationsValues.Click += new System.EventHandler(this.btnTotalOperationsValues_Click);
            // 
            // btnTotalTaxValues
            // 
            this.btnTotalTaxValues.AutoSize = true;
            this.btnTotalTaxValues.Location = new System.Drawing.Point(372, 190);
            this.btnTotalTaxValues.Name = "btnTotalTaxValues";
            this.btnTotalTaxValues.Size = new System.Drawing.Size(221, 27);
            this.btnTotalTaxValues.TabIndex = 19;
            this.btnTotalTaxValues.Text = "Valor Total das Taxas Cobradas";
            this.toolTip1.SetToolTip(this.btnTotalTaxValues, "Valor total das taxas cobradas de todas as operações registradas");
            this.btnTotalTaxValues.UseVisualStyleBackColor = true;
            this.btnTotalTaxValues.Click += new System.EventHandler(this.btnTotalTaxValues_Click);
            // 
            // lblFilterReport
            // 
            this.lblFilterReport.AutoSize = true;
            this.lblFilterReport.Location = new System.Drawing.Point(146, 38);
            this.lblFilterReport.Name = "lblFilterReport";
            this.lblFilterReport.Size = new System.Drawing.Size(50, 17);
            this.lblFilterReport.TabIndex = 20;
            this.lblFilterReport.Text = "Filtros:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(49, 89);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(254, 22);
            this.txtClientName.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtClientName, "Digite o nome inteiro ou parcial para pesquisar (caso sensitivo)");
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.Enabled = false;
            this.dtpInitialDate.Location = new System.Drawing.Point(44, 171);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(254, 22);
            this.dtpInitialDate.TabIndex = 26;
            this.toolTip1.SetToolTip(this.dtpInitialDate, "Data inicial");
            // 
            // dtpFinalDate
            // 
            this.dtpFinalDate.Enabled = false;
            this.dtpFinalDate.Location = new System.Drawing.Point(44, 220);
            this.dtpFinalDate.Name = "dtpFinalDate";
            this.dtpFinalDate.Size = new System.Drawing.Size(254, 22);
            this.dtpFinalDate.TabIndex = 27;
            this.toolTip1.SetToolTip(this.dtpFinalDate, "Data final");
            this.dtpFinalDate.Value = new System.DateTime(2021, 5, 29, 0, 0, 0, 0);
            // 
            // lblFinalDate
            // 
            this.lblFinalDate.AutoSize = true;
            this.lblFinalDate.Location = new System.Drawing.Point(129, 200);
            this.lblFinalDate.Name = "lblFinalDate";
            this.lblFinalDate.Size = new System.Drawing.Size(76, 17);
            this.lblFinalDate.TabIndex = 25;
            this.lblFinalDate.Text = "Data Final:";
            // 
            // lblInitialDate
            // 
            this.lblInitialDate.AutoSize = true;
            this.lblInitialDate.Location = new System.Drawing.Point(129, 151);
            this.lblInitialDate.Name = "lblInitialDate";
            this.lblInitialDate.Size = new System.Drawing.Size(81, 17);
            this.lblInitialDate.TabIndex = 24;
            this.lblInitialDate.Text = "Data Inicial:";
            // 
            // lblNameReport
            // 
            this.lblNameReport.AutoSize = true;
            this.lblNameReport.Location = new System.Drawing.Point(120, 69);
            this.lblNameReport.Name = "lblNameReport";
            this.lblNameReport.Size = new System.Drawing.Size(114, 17);
            this.lblNameReport.TabIndex = 22;
            this.lblNameReport.Text = "Nome do cliente:";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(132, 127);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(64, 21);
            this.cbDate.TabIndex = 29;
            this.cbDate.Text = "Data:";
            this.toolTip1.SetToolTip(this.cbDate, "Marque esta opção para adicionar datas no filtro de pesquisa");
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // lvwOperationsLlist
            // 
            this.lvwOperationsLlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumber,
            this.columnName,
            this.columnOriginCurrency,
            this.columnColumnDestiny,
            this.columnDate,
            this.columnValue,
            this.columnValueConverted});
            this.lvwOperationsLlist.FullRowSelect = true;
            this.lvwOperationsLlist.HideSelection = false;
            this.lvwOperationsLlist.Location = new System.Drawing.Point(612, 48);
            this.lvwOperationsLlist.MultiSelect = false;
            this.lvwOperationsLlist.Name = "lvwOperationsLlist";
            this.lvwOperationsLlist.Size = new System.Drawing.Size(854, 368);
            this.lvwOperationsLlist.TabIndex = 30;
            this.lvwOperationsLlist.UseCompatibleStateImageBehavior = false;
            this.lvwOperationsLlist.View = System.Windows.Forms.View.Details;
            this.lvwOperationsLlist.SelectedIndexChanged += new System.EventHandler(this.lvwPerson_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Nome";
            this.columnName.Width = 161;
            // 
            // columnOriginCurrency
            // 
            this.columnOriginCurrency.Text = "Moeda de Origem";
            this.columnOriginCurrency.Width = 134;
            // 
            // columnColumnDestiny
            // 
            this.columnColumnDestiny.Text = "Moeda de Destino";
            this.columnColumnDestiny.Width = 140;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Data";
            this.columnDate.Width = 131;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Valor Original";
            this.columnValue.Width = 114;
            // 
            // columnValueConverted
            // 
            this.columnValueConverted.Text = "Valor Convertido";
            this.columnValueConverted.Width = 126;
            // 
            // lblOperationsList
            // 
            this.lblOperationsList.AutoSize = true;
            this.lblOperationsList.Location = new System.Drawing.Point(981, 19);
            this.lblOperationsList.Name = "lblOperationsList";
            this.lblOperationsList.Size = new System.Drawing.Size(132, 17);
            this.lblOperationsList.TabIndex = 31;
            this.lblOperationsList.Text = "Lista de Operações";
            // 
            // columnNumber
            // 
            this.columnNumber.Text = "#";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(1612, 450);
            this.Controls.Add(this.lblOperationsList);
            this.Controls.Add(this.lvwOperationsLlist);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.dtpFinalDate);
            this.Controls.Add(this.dtpInitialDate);
            this.Controls.Add(this.lblFinalDate);
            this.Controls.Add(this.lblInitialDate);
            this.Controls.Add(this.lblNameReport);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblFilterReport);
            this.Controls.Add(this.btnTotalTaxValues);
            this.Controls.Add(this.btnTotalOperationsValues);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnOperationsList);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperationsList;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnTotalOperationsValues;
        private System.Windows.Forms.Button btnTotalTaxValues;
        private System.Windows.Forms.Label lblFilterReport;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.DateTimePicker dtpFinalDate;
        private System.Windows.Forms.Label lblFinalDate;
        private System.Windows.Forms.Label lblInitialDate;
        private System.Windows.Forms.Label lblNameReport;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ListView lvwOperationsLlist;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnOriginCurrency;
        private System.Windows.Forms.ColumnHeader columnColumnDestiny;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.ColumnHeader columnValueConverted;
        private System.Windows.Forms.Label lblOperationsList;
        private System.Windows.Forms.ColumnHeader columnNumber;
    }
}