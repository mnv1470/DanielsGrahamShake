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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSalesRecord = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grosssalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossInvestmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSalesRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbGrahamShakeDataSet = new WindowsFormsApplication1.dbGrahamShakeDataSet();
            this.txtSearchSalesRecord = new System.Windows.Forms.TextBox();
            this.tblSalesRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalesRecordTableAdapter = new WindowsFormsApplication1.dbGrahamShakeDataSetTableAdapters.tblSalesRecordTableAdapter();
            this.btnSearchSalesRecord = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrahamShakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalesRecord
            // 
            this.dataGridViewSalesRecord.AllowUserToAddRows = false;
            this.dataGridViewSalesRecord.AllowUserToDeleteRows = false;
            this.dataGridViewSalesRecord.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalesRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.grosssalesDataGridViewTextBoxColumn,
            this.grossInvestmentDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn});
            this.dataGridViewSalesRecord.DataSource = this.tblSalesRecordBindingSource1;
            this.dataGridViewSalesRecord.Location = new System.Drawing.Point(18, 57);
            this.dataGridViewSalesRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSalesRecord.Name = "dataGridViewSalesRecord";
            this.dataGridViewSalesRecord.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalesRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewSalesRecord.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSalesRecord.Size = new System.Drawing.Size(533, 292);
            this.dataGridViewSalesRecord.TabIndex = 0;
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
            // tblSalesRecordBindingSource1
            // 
            this.tblSalesRecordBindingSource1.DataMember = "tblSalesRecord";
            this.tblSalesRecordBindingSource1.DataSource = this.dbGrahamShakeDataSet;
            // 
            // dbGrahamShakeDataSet
            // 
            this.dbGrahamShakeDataSet.DataSetName = "dbGrahamShakeDataSet";
            this.dbGrahamShakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearchSalesRecord
            // 
            this.txtSearchSalesRecord.Location = new System.Drawing.Point(387, 21);
            this.txtSearchSalesRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchSalesRecord.Name = "txtSearchSalesRecord";
            this.txtSearchSalesRecord.Size = new System.Drawing.Size(133, 26);
            this.txtSearchSalesRecord.TabIndex = 6;
            this.txtSearchSalesRecord.Click += new System.EventHandler(this.txtSearchSalesRecord_Click);
            this.txtSearchSalesRecord.TextChanged += new System.EventHandler(this.txtSearchSalesRecord_TextChanged);
            this.txtSearchSalesRecord.Leave += new System.EventHandler(this.txtSearchSalesRecord_Leave);
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
            // btnSearchSalesRecord
            // 
            this.btnSearchSalesRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btnSearchSalesRecord.FlatAppearance.BorderSize = 0;
            this.btnSearchSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSalesRecord.Image = global::WindowsFormsApplication1.Properties.Resources._106236_16;
            this.btnSearchSalesRecord.Location = new System.Drawing.Point(526, 21);
            this.btnSearchSalesRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchSalesRecord.Name = "btnSearchSalesRecord";
            this.btnSearchSalesRecord.Size = new System.Drawing.Size(25, 26);
            this.btnSearchSalesRecord.TabIndex = 5;
            this.btnSearchSalesRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchSalesRecord.UseVisualStyleBackColor = false;
            this.btnSearchSalesRecord.Click += new System.EventHandler(this.btnSearchSalesRecord_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WindowsFormsApplication1.Properties.Resources._211651_20;
            this.btnClose.Location = new System.Drawing.Point(474, 353);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "  Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SalesRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(23)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(563, 388);
            this.Controls.Add(this.txtSearchSalesRecord);
            this.Controls.Add(this.btnSearchSalesRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewSalesRecord);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesRecordForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SalesRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrahamShakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewSalesRecord;
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
        private System.Windows.Forms.BindingSource tblSalesRecordBindingSource1;
    }
}