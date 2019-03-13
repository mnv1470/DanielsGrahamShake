using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class SalesRecordForm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Victorio\documents\visual studio 2010\Projects\GrahamShakeSystem\GrahamShakeSystem\dbGrahamShake.accdb");
        public SalesRecordForm()
        {
            InitializeComponent();
        }

        private void SalesRecordForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbGrahamShakeDataSet.tblSalesRecord' table. You can move, or remove it, as needed.
            this.tblSalesRecordTableAdapter.Fill(this.dbGrahamShakeDataSet.tblSalesRecord);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Enabled = true;
            Hide();
            Close();
        }

        private void txtSearchSalesRecord_TextChanged(object sender, EventArgs e)
        {
                updateDataGridSalesRecord();
        }

        public void updateDataGridSalesRecord()
        {
            con.Open();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from tblSalesRecord";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewSalesRecord.DataSource = dt;
            con.Close();
        }

        private void btnSearchSalesRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSalesRecord.Text))
            {
                MessageBox.Show("Please fill in the search field to search through the sales record", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from tblSalesRecord where Date = '" + txtSearchSalesRecord.Text + "'";
                cmd1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
                da.Fill(dt);
                dataGridViewSalesRecord.DataSource = dt;
                con.Close();

            }
        }
    }
}
