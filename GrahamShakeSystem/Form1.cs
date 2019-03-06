﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        

        int crushedIceBawasan, mangoBawasan, avocadoBawasan, condensedMilkBawasan, grahamPowderBawasan, marshmallowBawasan, caramelBawasan, lecheFlanBawasan, whippedCreamBawasan, blackPearlBawasan , domeLidBawasan, cups12Bawasan, cups16Bawasan, cups22Bawasan, strawBawasan, sugarBawasan;  
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Victorio\documents\visual studio 2010\Projects\GrahamShakeSystem\GrahamShakeSystem\dbGrahamShake.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void chkCPCrushedIce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCrushedIce.Checked == true)
            {
                txtCPCrushedIce.Enabled = true;
            }
            else
            {
                txtCPCrushedIce.Enabled = false;
                txtCPCrushedIce.Clear();
            }
            
        }

        private void chkCPMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPMango.Checked == true)
            {
                txtCPMango.Enabled = true;
            }
            else
            {
                txtCPMango.Enabled = false;
                txtCPMango.Clear();
            }
            
        }

        private void chkCPAvocado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPAvocado.Checked == true)
            {
                txtCPAvocado.Enabled = true;
            }
            else
            {
                txtCPAvocado.Enabled = false;
                txtCPAvocado.Clear();
            }
            
        }

        private void chkCPCondensedMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCondensedMilk.Checked == true)
            {
                txtCPCondensedMilk.Enabled = true;
            }
            else
            {
                txtCPCondensedMilk.Enabled = false;
                txtCPCondensedMilk.Clear();
            }
            
        }

        private void chkCPGrahamPowder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPGrahamPowder.Checked == true)
            {
                txtCPGrahamPowder.Enabled = true;
            }
            else
            {
                txtCPGrahamPowder.Enabled = false;
                txtCPGrahamPowder.Clear();
            }
            
        }

        private void chkCPMarshmallows_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPMarshmallows.Checked == true)
            {
                txtCPMarshmallows.Enabled = true;
            }
            else
            {
                txtCPMarshmallows.Enabled = false;
                txtCPMarshmallows.Clear();
            }
            
        }

        private void chkCPCaramel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCaramel.Checked == true)
            {
                txtCPCaramel.Enabled = true;
            }
            else
            {
                txtCPCaramel.Enabled = false;
                txtCPCaramel.Clear();
            }
        }

        private void chkCPLecheFlan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPLecheFlan.Checked == true)
            {
                txtCPLecheFlan.Enabled = true;
            }
            else
            {
                txtCPLecheFlan.Enabled = false;
                txtCPLecheFlan.Clear();
            }
            
        }

        private void chkCPWhippedCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPWhippedCream.Checked == true)
            {
                txtCPWhippedCream.Enabled = true;
            }
            else
            {
                txtCPWhippedCream.Enabled = false;
                txtCPWhippedCream.Clear();
            }
            
        }

        private void chkCPBlackPearl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPBlackPearl.Checked == true)
            {
                txtCPBlackPearl.Enabled = true;
            }
            else
            {
                txtCPBlackPearl.Enabled = false;
                txtCPBlackPearl.Clear();
            }
        }

        private void chkCPDomeLid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPDomeLid.Checked == true)
            {
                txtCPDomeLid.Enabled = true;
            }
            else
            {
                txtCPDomeLid.Enabled = false;
                txtCPDomeLid.Clear();
            }
        }

        private void chkCPCups12_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCups12.Checked == true)
            {
                txtCPCups12.Enabled = true;
            }
            else
            {
                txtCPCups12.Enabled = false;
                txtCPCups12.Clear();
            }
        }

        private void chkCPCups16_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCups16.Checked == true)
            {
                txtCPCups16.Enabled = true;
            }
            else
            {
                txtCPCups16.Enabled = false;
                txtCPCups16.Clear();
            }
        }

        private void chkCPCups22_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPCups22.Checked == true)
            {
                txtCPCups22.Enabled = true;
            }
            else
            {
                txtCPCups22.Enabled = false;
                txtCPCups22.Clear();
            }
        }

        private void chkCPStraw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPStraw.Checked == true)
            {
                txtCPStraw.Enabled = true;
            }
            else
            {
                txtCPStraw.Enabled = false;
                txtCPStraw.Clear();
            }
        }

        private void chkCPSugar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCPSugar.Checked == true)
            {
                txtCPSugar.Enabled = true;
            }
            else
            {
                txtCPSugar.Enabled = false;
                txtCPSugar.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbGrahamShakeDataSet.tblIngredientStocks' table. You can move, or remove it, as needed.
            this.tblIngredientStocksTableAdapter.Fill(this.dbGrahamShakeDataSet.tblIngredientStocks);   

            setToDefault(); //Disable and clear everything

            updateDataGridInventoryModify();//Display to datagrid update inventory
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtGrossSale.Text)) || ((string.IsNullOrEmpty(txtCPAvocado.Text)) && (chkCPAvocado.Checked == true))
                || ((string.IsNullOrEmpty(txtCPCaramel.Text)) && (chkCPCaramel.Checked == true)) || ((string.IsNullOrEmpty(txtCPCaramel.Text)) && (chkCPCaramel.Checked == true))
                || ((string.IsNullOrEmpty(txtCPCrushedIce.Text)) && (chkCPCrushedIce.Checked == true))
                || ((string.IsNullOrEmpty(txtCPGrahamPowder.Text)) && (chkCPGrahamPowder.Checked == true))
                || ((string.IsNullOrEmpty(txtCPLecheFlan.Text)) && (chkCPLecheFlan.Checked == true))
                || ((string.IsNullOrEmpty(txtCPMango.Text)) && (chkCPMango.Checked == true))
                || ((string.IsNullOrEmpty(txtCPMarshmallows.Text)) && (chkCPMarshmallows.Checked == true))
                || ((string.IsNullOrEmpty(txtCPWhippedCream.Text)) && (chkCPWhippedCream.Checked == true))
                || ((string.IsNullOrEmpty(txtCPBlackPearl.Text)) && (chkCPBlackPearl.Checked == true))
                || ((string.IsNullOrEmpty(txtCPDomeLid.Text)) && (chkCPDomeLid.Checked == true))
                || ((string.IsNullOrEmpty(txtCPCups12.Text)) && (chkCPCups12.Checked == true))
                || ((string.IsNullOrEmpty(txtCPCups16.Text)) && (chkCPCups16.Checked == true))
                || ((string.IsNullOrEmpty(txtCPCups22.Text)) && (chkCPCups22.Checked == true))
                || ((string.IsNullOrEmpty(txtCPStraw.Text)) && (chkCPStraw.Checked == true))
                || ((string.IsNullOrEmpty(txtCPSugar.Text)) && (chkCPSugar.Checked == true)))
            {
                MessageBox.Show("Please fill in all of the fields before computing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Enable add record button
                btnRecord.Enabled = true;

                //Compute with default price
                int avocadoGastos = Convert.ToInt32(numAvocado.Value * 110);
                int caramelGastos = Convert.ToInt32(numCaramel.Value * 115);
                int condensedMilkGastos = Convert.ToInt32(numCondensedMilk.Value * 74);
                int crushedIceGastos = Convert.ToInt32(numCrushedIce.Value * 125);
                int grahamPowderGastos = Convert.ToInt32(numGrahamPowder.Value * 170);
                int lecheFlanGastos = Convert.ToInt32(numLecheFlan.Value * 50);
                int mangoGastos = Convert.ToInt32(numMango.Value * 1200);
                int marshmallowsGastos = Convert.ToInt32(numMarshmallow.Value * 95);
                int whippedCreamGastos = Convert.ToInt32(numWhippedCream.Value * 205);
                int blackPearlGastos = Convert.ToInt32(numBlackPearl.Value * 63);
                int domeLidGastos = Convert.ToInt32(numDomeLid.Value * 120);
                int cups12Gastos = Convert.ToInt32(numCups12.Value * 30);
                int cups16Gastos = Convert.ToInt32(numCups16.Value * 280);
                int cups22Gastos = Convert.ToInt32(numCups22.Value * 350);
                int strawGastos = Convert.ToInt32(numStraw.Value * 120);
                int sugarGastos = Convert.ToInt32(numSugar.Value * 46);
                int grossInvestment = avocadoGastos + caramelGastos + condensedMilkGastos + crushedIceGastos + grahamPowderGastos + lecheFlanGastos + mangoGastos + marshmallowsGastos + whippedCreamGastos + blackPearlGastos + cups12Gastos + cups16Gastos + cups22Gastos + domeLidGastos + sugarGastos + strawGastos;
                int grossSales = Convert.ToInt32(txtGrossSale.Text);
                int profit = grossSales - grossInvestment;
                

                //Compute with customized price
                if (chkCPAvocado.Checked == true)
                {
                    avocadoGastos = Convert.ToInt32(numAvocado.Value * Convert.ToInt32(txtCPAvocado.Text));
                }
                if (chkCPCaramel.Checked == true)
                {
                    caramelGastos = Convert.ToInt32(numCaramel.Value * Convert.ToInt32(txtCPCaramel.Text));
                }
                if (chkCPCondensedMilk.Checked == true)
                {
                    condensedMilkGastos = Convert.ToInt32(numCondensedMilk.Value * Convert.ToInt32(txtCPCondensedMilk.Text));
                }
                if (chkCPCrushedIce.Checked == true)
                {
                    crushedIceGastos = Convert.ToInt32(numCrushedIce.Value * Convert.ToInt32(txtCPCrushedIce.Text));
                }
                if (chkCPGrahamPowder.Checked == true)
                {
                    grahamPowderGastos = Convert.ToInt32(numGrahamPowder.Value * Convert.ToInt32(txtCPGrahamPowder.Text));
                }
                if (chkCPLecheFlan.Checked == true)
                {
                    lecheFlanGastos = Convert.ToInt32(numLecheFlan.Value * Convert.ToInt32(txtCPLecheFlan.Text));
                }
                if (chkCPMango.Checked == true)
                {
                    mangoGastos = Convert.ToInt32(numMango.Value * Convert.ToInt32(txtCPMango.Text));
                }
                if (chkCPMarshmallows.Checked == true)
                {
                    marshmallowsGastos = Convert.ToInt32(numMarshmallow.Value * Convert.ToInt32(txtCPMarshmallows.Text));
                }
                if (chkCPWhippedCream.Checked == true)
                {
                    whippedCreamGastos = Convert.ToInt32(numWhippedCream.Value * Convert.ToInt32(txtCPWhippedCream.Text));
                }
                if (chkCPBlackPearl.Checked == true)
                {
                    blackPearlGastos = Convert.ToInt32(numBlackPearl.Value * Convert.ToInt32(txtCPBlackPearl.Text));
                }
                if (chkCPDomeLid.Checked == true)
                {
                    domeLidGastos = Convert.ToInt32(numDomeLid.Value * Convert.ToInt32(txtCPDomeLid.Text));
                }
                if (chkCPCups12.Checked == true)
                {
                    cups12Gastos = Convert.ToInt32(numCups12.Value * Convert.ToInt32(txtCPCups12.Text));
                }
                if (chkCPCups16.Checked == true)
                {
                    cups16Gastos = Convert.ToInt32(numCups16.Value * Convert.ToInt32(txtCPCups16.Text));
                }
                if (chkCPCups22.Checked == true)
                {
                    cups22Gastos = Convert.ToInt32(numCups22.Value * Convert.ToInt32(txtCPCups22.Text));
                }
                if (chkCPStraw.Checked == true)
                {
                    strawGastos = Convert.ToInt32(numStraw.Value * Convert.ToInt32(txtCPStraw.Text));
                }
                if (chkCPSugar.Checked == true)
                {
                    sugarGastos = Convert.ToInt32(numSugar.Value * Convert.ToInt32(txtCPSugar.Text));
                }

                //Display computations through labels
                lblProfit.Text = Convert.ToString(profit);
                lblGrossInvestmentTotal.Text = Convert.ToString(grossInvestment);
                
            }

            


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //Insert record to sales record
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblSalesRecord values('" + DateTime.Now + "','" + Convert.ToInt32(txtGrossSale.Text) + "','" + Convert.ToInt32(lblGrossInvestmentTotal.Text) + "','" + Convert.ToInt32(lblProfit.Text) + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            //Retrieve value from inventory table
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblIngredientStocks order by Date_updated asc";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                crushedIceBawasan = Convert.ToInt32(dr["Crushed_ice"]);   
                mangoBawasan = Convert.ToInt32(dr["Mango"]);
                avocadoBawasan = Convert.ToInt32(dr["Avocado"]);
                condensedMilkBawasan = Convert.ToInt32(dr["Condensed_milk"]);
                grahamPowderBawasan = Convert.ToInt32(dr["Graham_powder"]);
                marshmallowBawasan = Convert.ToInt32(dr["Marshmallow"]);
                caramelBawasan = Convert.ToInt32(dr["Caramel"]);
                lecheFlanBawasan = Convert.ToInt32(dr["Leche_flan"]);
                whippedCreamBawasan = Convert.ToInt32(dr["Whipped_cream"]);
                blackPearlBawasan = Convert.ToInt32(dr["Black_pearl"]);
                domeLidBawasan = Convert.ToInt32(dr["Dome_lid"]);
                cups12Bawasan = Convert.ToInt32(dr["Cups_12oz"]);
                cups16Bawasan = Convert.ToInt32(dr["Cups_16oz"]);
                cups22Bawasan = Convert.ToInt32(dr["Cups_22oz"]);
                strawBawasan = Convert.ToInt32(dr["Straw"]);
                sugarBawasan = Convert.ToInt32(dr["Sugar"]);
            }

            con.Close();


            //Bawas sa latest row: compute and insert
            int crushedIceUpdated = crushedIceBawasan- Convert.ToInt32(numCrushedIce.Value);
            int mangoUpdated = mangoBawasan - Convert.ToInt32(numMango.Value);
            int avocadoUpdated = avocadoBawasan - Convert.ToInt32(numAvocado.Value);
            int condensedMilkUpdated = condensedMilkBawasan - Convert.ToInt32(numCondensedMilk.Value);
            int grahamPowderUpdated = grahamPowderBawasan - Convert.ToInt32(numGrahamPowder.Value);
            int marshmallowUpdated = marshmallowBawasan - Convert.ToInt32(numMarshmallow.Value);
            int caramelUpdated = caramelBawasan - Convert.ToInt32(numCaramel.Value);
            int lecheFlanUpdated = lecheFlanBawasan - Convert.ToInt32(numLecheFlan.Value);
            int whippedCreamUpdated = whippedCreamBawasan - Convert.ToInt32(numWhippedCream.Value);
            int domeLidUpdated = domeLidBawasan - Convert.ToInt32(numDomeLid.Value);
            int cups12Updated = cups12Bawasan - Convert.ToInt32(numCups12.Value);
            int cups16Updated = cups16Bawasan - Convert.ToInt32(numCups16.Value);
            int cups22Updated = cups22Bawasan - Convert.ToInt32(numCups22.Value);
            int strawUpdated = strawBawasan - Convert.ToInt32(numStraw.Value);
            int sugarUpdated = sugarBawasan - Convert.ToInt32(numSugar.Value);
            int blackPearlUpdated = blackPearlBawasan - Convert.ToInt32(numBlackPearl.Value);

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblIngredientStocks values('" + DateTime.Now + "','" + blackPearlUpdated + "','" + mangoUpdated + "','" + avocadoUpdated + "','" + condensedMilkUpdated + "','" + grahamPowderUpdated + "','" + marshmallowUpdated + "','" + caramelUpdated + "','" + lecheFlanUpdated + "','" + whippedCreamUpdated + "','" + domeLidUpdated + "','" + cups12Bawasan + "','" + cups16Bawasan + "','" + cups22Bawasan + "','" + strawUpdated + "','" + sugarUpdated + "')";
            cmd.ExecuteNonQuery();
            con.Close();


            //Set to default and notify
            updateDataGridInventoryModify();    
            MessageBox.Show("Successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            setToDefault();
        }

        private void setToDefault()
        {
            //ADD 
            //Disabling txtCP
            txtCPAvocado.Enabled = false;
            txtCPCaramel.Enabled = false;
            txtCPCondensedMilk.Enabled = false;
            txtCPCrushedIce.Enabled = false;
            txtCPGrahamPowder.Enabled = false;
            txtCPLecheFlan.Enabled = false;
            txtCPMango.Enabled = false;
            txtCPMarshmallows.Enabled = false;
            txtCPWhippedCream.Enabled = false;
            txtCPBlackPearl.Enabled = false;
            txtCPDomeLid.Enabled = false;
            txtCPCups12.Enabled = false;
            txtCPCups16.Enabled = false;
            txtCPCups22.Enabled = false;
            txtCPStraw.Enabled = false;
            txtCPSugar.Enabled = false;

            //Disabling buttons
            btnRecord.Enabled = false;

            //Disabling check box
            chkCPAvocado.Checked = false;
            chkCPBlackPearl.Checked = false;
            chkCPCaramel.Checked = false;
            chkCPCondensedMilk.Checked = false;
            chkCPCrushedIce.Checked = false;
            chkCPCups12.Checked = false;
            chkCPCups16.Checked = false;
            chkCPCups22.Checked = false;
            chkCPDomeLid.Checked = false;
            chkCPGrahamPowder.Checked = false;
            chkCPLecheFlan.Checked = false;
            chkCPMango.Checked = false;
            chkCPMarshmallows.Checked = false;
            chkCPStraw.Checked = false;
            chkCPSugar.Checked = false;
            chkCPWhippedCream.Checked = false;
            
            //Setting nums to 0
            numAvocado.Value = 0;
            numBlackPearl.Value = 0;
            numCaramel.Value = 0;
            numCondensedMilk.Value = 0;
            numCrushedIce.Value = 0;
            numCups12.Value = 0;
            numCups16.Value = 0;
            numCups22.Value = 0;
            numDomeLid.Value = 0;
            numGrahamPowder.Value = 0;
            numLecheFlan.Value = 0;
            numMango.Value = 0;
            numMarshmallow.Value = 0;
            numStraw.Value = 0;
            numSugar.Value = 0;
            numWhippedCream.Value = 0;

            //Setting lbltotals and txtTotal to 0
            lblGrossInvestmentTotal.Text = "PHP 00";
            lblProfit.Text = "PHP 00";
            txtGrossSale.Clear();


            //UPDATE INVENTORY

            //Setting numMods to 0
            numModAvocado.Value = 0;
            numModCaramel.Value = 0;
            numModCondensedMilk.Value = 0;
            numModCrushedIce.Value = 0;
            numModCups12.Value = 0;
            numModCups16.Value = 0;
            numModCups22.Value = 0;
            numModDomeLid.Value = 0;
            numModGrahamPowder.Value = 0;
            numModLecheFlan.Value = 0;
            numModMango.Value = 0;
            numModMarshmallows.Value = 0;
            numModStraw.Value = 0;
            numModSugar.Value = 0;
            numModWhippedCream.Value = 0;
            numModBlackPearl.Value = 0;
            
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update inventory
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblIngredientStocks values('" + DateTime.Now + "','" + numModCrushedIce.Value + "','" + numModMango.Value + "','" + numModAvocado.Value + "','" + numModCondensedMilk.Value + "','" + numModGrahamPowder.Value + "','" + numModMarshmallows.Value + "','" + numModCaramel.Value + "','" + numModLecheFlan.Value + "','" + numModWhippedCream.Value + "','" + numModBlackPearl.Value + "','" + numModDomeLid.Value + "','" + numModCups12.Value + "','" + numModCups16.Value + "','" + numModCups22.Value + "','" + numModStraw.Value + "','" + numModSugar.Value + "')";
            cmd.ExecuteNonQuery();
            con.Close(); //NAKALIMUTAN MO YUNG CRUSHED ICE AYUSIN MO DB AND ALL CODES DOUBLE CHECK KUNG NAINCLUDE CRUSHED ICE

            updateDataGridInventoryModify();//Display to datagrid update inventory

            //set to default and notify
            setToDefault();
            MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void updateDataGridInventoryModify()
        {
            con.Open();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from tblIngredientStocks";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewModifyInventory.DataSource = dt;
            con.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveValueFromTblIngredientStocks(); //EWAN KO LANG KUNG MAKUKUHA NYA YUNG MGA VALUE D2 NG BAWASAN VARIABLES FROM DB
            if ((sender as TabControl).SelectedIndex == 2)
            {
                updateDataGridInventoryModify();
                latestStockReportChart();
            }

            if((sender as TabControl).SelectedIndex == 1)
            {
                string itemsOutOfSupply = "";
                if (crushedIceBawasan == 0)
                {
                    numCrushedIce.Enabled = false;
                    itemsOutOfSupply += "CRUSHED ICE, ";
                }
                else
                {
                    numCrushedIce.Enabled = true;
                }
                if (mangoBawasan == 0)
                {
                    numMango.Enabled = false;
                    itemsOutOfSupply += "MANGO, ";
                }
                else
                {
                    numMango.Enabled = true;
                }
                if (avocadoBawasan == 0)
                {
                    numAvocado.Enabled = false;
                    itemsOutOfSupply += "AVOCADO, ";
                }
                else
                {
                    numAvocado.Enabled = true;
                }
                if (condensedMilkBawasan == 0)
                {
                    numCondensedMilk.Enabled = false;
                    itemsOutOfSupply += "CONDENSED MILK, ";
                }
                else
                {
                    numCondensedMilk.Enabled = true;
                }
                if (grahamPowderBawasan == 0)
                {
                    numGrahamPowder.Enabled = false;
                    itemsOutOfSupply += "GRAHAM POWDER, ";
                }
                else
                {
                    numGrahamPowder.Enabled = true;
                }
                if (marshmallowBawasan == 0)
                {
                    numMarshmallow.Enabled = false;
                    itemsOutOfSupply += "MARSHMALLOW, ";
                }
                else
                {
                    numMarshmallow.Enabled = true;
                }
                if (caramelBawasan == 0)
                {
                    numCaramel.Enabled = false;
                    itemsOutOfSupply += "CARAMEL, ";
                }
                else
                {
                    numCaramel.Enabled = true;
                }
                if (lecheFlanBawasan == 0)
                {
                    numLecheFlan.Enabled = false;
                    itemsOutOfSupply += "LECHE FLAN, ";
                }
                else
                {
                    numLecheFlan.Enabled = true;
                }
                if (whippedCreamBawasan == 0)
                {
                    numWhippedCream.Enabled = false;
                    itemsOutOfSupply += "WHIPPED CREAM, ";
                }
                else
                {
                    numWhippedCream.Enabled = true;
                }
                if (blackPearlBawasan == 0)
                {
                    numBlackPearl.Enabled = false;
                    itemsOutOfSupply += "BLACK PEARL, ";
                }
                else
                {
                    numBlackPearl.Enabled = true;
                }
                if (sugarBawasan == 0)
                {
                    numSugar.Enabled = false;
                    itemsOutOfSupply += "SUGAR, ";
                }
                else
                {
                    numSugar.Enabled = true;
                }
                if (domeLidBawasan == 0)
                {
                    numDomeLid.Enabled = false;
                    itemsOutOfSupply += "DOME LID, ";
                }
                else
                {
                    numDomeLid.Enabled = true;
                }
                if (cups12Bawasan == 0)
                {
                    numCups12.Enabled = false;
                    itemsOutOfSupply += "CUPS 12OZ, ";
                }
                else
                {
                    numCups12.Enabled = true;
                }
                if (cups16Bawasan == 0)
                {
                    numCups16.Enabled = false;
                    itemsOutOfSupply += "CUPS 16OZ, ";
                }
                else
                {
                    numCups16.Enabled = true;
                }
                if (cups22Bawasan == 0)
                {
                    numCups22.Enabled = false;
                    itemsOutOfSupply += "CUPS 22OZ, ";
                }
                else
                {
                    numCups22.Enabled = true;
                }
                if (strawBawasan == 0)
                {
                    numStraw.Enabled = false;
                    itemsOutOfSupply += "STRAW, ";
                }
                else
                {
                    numStraw.Enabled = true;
                }
                if ((crushedIceBawasan == 0) || (mangoBawasan == 0) || (avocadoBawasan == 0) || (condensedMilkBawasan == 0)
                    || (grahamPowderBawasan == 0) || (marshmallowBawasan == 0) || (caramelBawasan == 0) || (lecheFlanBawasan == 0)
                    || (whippedCreamBawasan == 0) || (blackPearlBawasan == 0) || (sugarBawasan == 0) || (domeLidBawasan == 0)
                    || (cups12Bawasan == 0) || (cups16Bawasan == 0) || (cups22Bawasan == 0) || (strawBawasan == 0)) //KUNG MERONG 0 NA STOCK
                {
                    MessageBox.Show("You don't have any stocks for the following: "+itemsOutOfSupply+"\n\nPlease update your inventory if you already have stocks for the said ingredients/materials.","Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void DisableNum(NumericUpDown numToDisable)
        {
            numToDisable.Enabled = false;
        }

        public void RetrieveValueFromTblIngredientStocks()
        {
            //Retrieve value from inventory table
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblIngredientStocks order by Date_updated asc";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                crushedIceBawasan = Convert.ToInt32(dr["Crushed_ice"]);   
                mangoBawasan = Convert.ToInt32(dr["Mango"]);
                avocadoBawasan = Convert.ToInt32(dr["Avocado"]);
                condensedMilkBawasan = Convert.ToInt32(dr["Condensed_milk"]);
                grahamPowderBawasan = Convert.ToInt32(dr["Graham_powder"]);
                marshmallowBawasan = Convert.ToInt32(dr["Marshmallow"]);
                caramelBawasan = Convert.ToInt32(dr["Caramel"]);
                lecheFlanBawasan = Convert.ToInt32(dr["Leche_flan"]);
                whippedCreamBawasan = Convert.ToInt32(dr["Whipped_cream"]);
                blackPearlBawasan = Convert.ToInt32(dr["Black_pearl"]); 
                domeLidBawasan = Convert.ToInt32(dr["Dome_lid"]);
                cups12Bawasan = Convert.ToInt32(dr["Cups_12oz"]);
                cups16Bawasan = Convert.ToInt32(dr["Cups_16oz"]);
                cups22Bawasan = Convert.ToInt32(dr["Cups_22oz"]);
                strawBawasan = Convert.ToInt32(dr["Straw"]);
                sugarBawasan = Convert.ToInt32(dr["Sugar"]);
            }

            con.Close();
        }

        public void latestStockReportChart()
        {
            List<int> listOfStockAmountForStock = new List<int>();
            List<string> listOfStockNameForStock = new List<string>();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblIngredientStocks order by Date_updated asc";
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Retrieve value from inventory table
                crushedIceBawasan = Convert.ToInt32(dr["Crushed_ice"]);
                mangoBawasan = Convert.ToInt32(dr["Mango"]);
                avocadoBawasan = Convert.ToInt32(dr["Avocado"]);
                condensedMilkBawasan = Convert.ToInt32(dr["Condensed_milk"]);
                grahamPowderBawasan = Convert.ToInt32(dr["Graham_powder"]);
                marshmallowBawasan = Convert.ToInt32(dr["Marshmallow"]);
                caramelBawasan = Convert.ToInt32(dr["Caramel"]);
                lecheFlanBawasan = Convert.ToInt32(dr["Leche_flan"]);
                whippedCreamBawasan = Convert.ToInt32(dr["Whipped_cream"]);
                blackPearlBawasan = Convert.ToInt32(dr["Black_pearl"]);
                domeLidBawasan = Convert.ToInt32(dr["Dome_lid"]);
                cups12Bawasan = Convert.ToInt32(dr["Cups_12oz"]);
                cups16Bawasan = Convert.ToInt32(dr["Cups_16oz"]);
                cups22Bawasan = Convert.ToInt32(dr["Cups_22oz"]);
                strawBawasan = Convert.ToInt32(dr["Straw"]);
                sugarBawasan = Convert.ToInt32(dr["Sugar"]);


                
            }

            con.Close();

           
                //Lagay sa listOfStockAmountForStock yung retrieved data
                listOfStockAmountForStock.Add(crushedIceBawasan);
                listOfStockAmountForStock.Add(mangoBawasan);
                listOfStockAmountForStock.Add(avocadoBawasan);
                listOfStockAmountForStock.Add(condensedMilkBawasan);
                listOfStockAmountForStock.Add(grahamPowderBawasan);
                listOfStockAmountForStock.Add(marshmallowBawasan);
                listOfStockAmountForStock.Add(caramelBawasan);
                listOfStockAmountForStock.Add(lecheFlanBawasan);
                listOfStockAmountForStock.Add(whippedCreamBawasan);
                listOfStockAmountForStock.Add(blackPearlBawasan);
                listOfStockAmountForStock.Add(domeLidBawasan);
                listOfStockAmountForStock.Add(cups12Bawasan);
                listOfStockAmountForStock.Add(cups16Bawasan);
                listOfStockAmountForStock.Add(cups22Bawasan);
                listOfStockAmountForStock.Add(strawBawasan);
                listOfStockAmountForStock.Add(sugarBawasan);
                //Lagay sa listOfStockNameForStock yung retrieved data
                listOfStockNameForStock.Add("Crushed Ice");
                listOfStockNameForStock.Add("Mango");
                listOfStockNameForStock.Add("Avocado");
                listOfStockNameForStock.Add("Condensed Milk");
                listOfStockNameForStock.Add("Graham Powder");
                listOfStockNameForStock.Add("Marshmallow");
                listOfStockNameForStock.Add("Caramel");
                listOfStockNameForStock.Add("Leche Flan");
                listOfStockNameForStock.Add("Whipped Cream");
                listOfStockNameForStock.Add("Black Pearl");
                listOfStockNameForStock.Add("Dome Lid");
                listOfStockNameForStock.Add("Cups 12oz");
                listOfStockNameForStock.Add("Cups 16oz");
                listOfStockNameForStock.Add("Cups 22oz");
                listOfStockNameForStock.Add("Straw");
                listOfStockNameForStock.Add("Sugar");

            //Pie chart summary
            pieChartLatestInventory.Titles.Add("Latest Stock Report");
            pieChartLatestInventory.Series.Add("s1");
            pieChartLatestInventory.Series["s1"].ChartType = SeriesChartType.Bar;
            pieChartLatestInventory.Palette = ChartColorPalette.BrightPastel;
            pieChartLatestInventory.Series["s1"].Color = Color.FromArgb(5, 100, 146);
            //pieChartLatestInventory.Series["s1"].Font = new System.Drawing.Font("Microsoft Sans Serif", 8f);
            int i;
            for (i = 0; i < listOfStockNameForStock.Count; i++ )
            {
                pieChartLatestInventory.Series["s1"].Points.AddXY(listOfStockNameForStock[i], listOfStockAmountForStock[i]);
                pieChartLatestInventory.Series["s1"].IsValueShownAsLabel = true;
                pieChartLatestInventory.Series["s1"].LabelBackColor = Color.FromArgb(255, 255, 255);
                pieChartLatestInventory.Series["s1"].Points[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8f); //FIX CHART FONT TOO BIG WONT FIT TO GUI!!
            }


            
        }

       

    }
}