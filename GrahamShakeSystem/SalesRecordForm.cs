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
            //txt initial value
            txtSearchSalesRecord.Text = "Search by date";
            txtSearchSalesRecord.ForeColor = Color.FromArgb(145, 145, 145);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 frm1 = new Form1();
                frm1.Enabled = true;
                Hide();
                Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchSalesRecord_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchSalesRecord.Text))
                {
                    updateDataGridSalesRecord();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateDataGridSalesRecord()
        {
            try
            {
                con.Open();
                OleDbCommand cmd11 = con.CreateCommand();
                cmd11.CommandType = CommandType.Text;
                cmd11.CommandText = "select * from tblSalesRecord";
                cmd11.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd11);
                da1.Fill(dt1);
                dataGridViewSalesRecord.DataSource = dt1;
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchSalesRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchSalesRecord.Text))
                {
                    
                }
                else
                {

                    con.Open();
                    OleDbCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from tblSalesRecord where Date = @dateKo12";
                    cmd1.Parameters.Add("@dateKo12", OleDbType.Date).Value = txtSearchSalesRecord.Text;
                    cmd1.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
                    da.Fill(dt);
                    dataGridViewSalesRecord.DataSource = dt;
                    con.Close();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Invalid input", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void txtSearchSalesRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSalesRecord.Text == "Search by date")
                {
                    txtSearchSalesRecord.Clear();
                    txtSearchSalesRecord.ForeColor = Color.Black;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchSalesRecord_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchSalesRecord.Text))
                {
                    //txt initial value
                    txtSearchSalesRecord.Text = "Search by date";
                    txtSearchSalesRecord.ForeColor = Color.FromArgb(145, 145, 145);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
