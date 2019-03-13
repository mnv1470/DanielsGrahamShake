namespace WindowsFormsApplication1
{
    partial class SalesRecordForm
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
            this.dataGridViewSalesRecord = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.dbGrahamShakeDataSet = new WindowsFormsApplication1.dbGrahamShakeDataSet();
            this.tblSalesRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalesRecordTableAdapter = new WindowsFormsApplication1.dbGrahamShakeDataSetTableAdapters.tblSalesRecordTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosssalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossInvestmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchSalesRecord = new System.Windows.Forms.TextBox();
            this.btnSearchSalesRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrahamShakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalesRecord
            // 
            this.dataGridViewSalesRecord.AllowUserToAddRows = false;
            this.dataGridViewSalesRecord.AllowUserToDeleteRows = false;
            this.dataGridViewSalesRecord.AutoGenerateColumns = false;
            this.dataGridViewSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.grosssalesDataGridViewTextBoxColumn,
            this.grossInvestmentDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.dataGridViewSalesRecord.DataSource = this.tblSalesRecordBindingSource;
            this.dataGridViewSalesRecord.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewSalesRecord.Name = "dataGridViewSalesRecord";
            this.dataGridViewSalesRecord.ReadOnly = true;
            this.dataGridViewSalesRecord.Size = new System.Drawing.Size(457, 263);
            this.dataGridViewSalesRecord.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(403, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dbGrahamShakeDataSet
            // 
            this.dbGrahamShakeDataSet.DataSetName = "dbGrahamShakeDataSet";
            this.dbGrahamShakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSalesRecordBindingSource
            // 
            this.tblSalesRecordBindingSource.DataMember = "tblSalesRecord";
            this.tblSalesRecordBindingSource.DataSource = this.dbGrahamShakeDataSet;
            // 
            // tblSalesRecordTableAdapter
            // 
            this.tblSalesRecordTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grosssalesDataGridViewTextBoxColumn
            // 
            this.grosssalesDataGridViewTextBoxColumn.DataPropertyName = "Gross_sales";
            this.grosssalesDataGridViewTextBoxColumn.HeaderText = "Gross_sales";
            this.grosssalesDataGridViewTextBoxColumn.Name = "grosssalesDataGridViewTextBoxColumn";
            this.grosssalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossInvestmentDataGridViewTextBoxColumn
            // 
            this.grossInvestmentDataGridViewTextBoxColumn.DataPropertyName = "Gross_Investment";
            this.grossInvestmentDataGridViewTextBoxColumn.HeaderText = "Gross_Investment";
            this.grossInvestmentDataGridViewTextBoxColumn.Name = "grossInvestmentDataGridViewTextBoxColumn";
            this.grossInvestmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            this.profitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtSearchSalesRecord
            // 
            this.txtSearchSalesRecord.Location = new System.Drawing.Point(291, 23);
            this.txtSearchSalesRecord.Name = "txtSearchSalesRecord";
            this.txtSearchSalesRecord.Size = new System.Drawing.Size(115, 20);
            this.txtSearchSalesRecord.TabIndex = 6;
            this.txtSearchSalesRecord.TextChanged += new System.EventHandler(this.txtSearchSalesRecord_TextChanged);
            // 
            // btnSearchSalesRecord
            // 
            this.btnSearchSalesRecord.Location = new System.Drawing.Point(412, 21);
            this.btnSearchSalesRecord.Name = "btnSearchSalesRecord";
            this.btnSearchSalesRecord.Size = new System.Drawing.Size(57, 23);
            this.btnSearchSalesRecord.TabIndex = 5;
            this.btnSearchSalesRecord.Text = "Search";
            this.btnSearchSalesRecord.UseVisualStyleBackColor = true;
            this.btnSearchSalesRecord.Click += new System.EventHandler(this.btnSearchSalesRecord_Click);
            // 
            // SalesRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 347);
            this.Controls.Add(this.txtSearchSalesRecord);
            this.Controls.Add(this.btnSearchSalesRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewSalesRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesRecordForm";
            this.Text = "SalesRecordForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SalesRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrahamShakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalesRecord;
        private System.Windows.Forms.Button btnClose;
        private dbGrahamShakeDataSet dbGrahamShakeDataSet;
        private System.Windows.Forms.BindingSource tblSalesRecordBindingSource;
        private dbGrahamShakeDataSetTableAdapters.tblSalesRecordTableAdapter tblSalesRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grosssalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossInvestmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchSalesRecord;
        private System.Windows.Forms.Button btnSearchSalesRecord;
    }
}