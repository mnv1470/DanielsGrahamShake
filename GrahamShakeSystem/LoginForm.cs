using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (txtUsername.Text == "DanielFTW" && txtPassword.Text== "daniel2001")
            {

                Form1 frm1 = new Form1();
                Cursor = Cursors.Arrow;
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                frm1.ShowDialog();
                this.Close();


            }

            else
            {
                Cursor = Cursors.Arrow;
                MessageBox.Show("Login failed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ActiveControl = btnLogin;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;

                if (txtUsername.Text == "DanielFTW" && txtPassword.Text == "daniel2001")
                {

                    Form1 frm1 = new Form1();
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    frm1.ShowDialog();
                    this.Close();


                }

                else
                {
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Login failed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;

                if (txtUsername.Text == "DanielFTW" && txtPassword.Text == "daniel2001")
                {

                    Form1 frm1 = new Form1();
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    frm1.ShowDialog();
                    this.Close();


                }

                else
                {
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Login failed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtUsername.ForeColor = Color.FromArgb(255, 255, 255);

            pnlUsername.BackColor = Color.FromArgb(255, 195, 14);
            pnlPassword.BackColor = Color.FromArgb(255, 255, 255);
            pictureBoxUsername.Image = Properties.Resources._2203549_20_YELLOW;
            pictureBoxPassword.Image = Properties.Resources._1564520_20;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
            if ((txtPassword.Text == "Password") || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.ForeColor = Color.FromArgb(178, 178, 178);
            }
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
            if (!(txtPassword.Text == "Password") && !(string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = Color.FromArgb(255, 255, 255);

            pnlPassword.BackColor = Color.FromArgb(255, 195, 14);
            pnlUsername.BackColor = Color.FromArgb(255, 255, 255);
            pictureBoxUsername.Image = Properties.Resources._2203549_20;
            pictureBoxPassword.Image = Properties.Resources._1564520_20_YELLOW;

            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            if ((txtUsername.Text == "Username") || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.ForeColor = Color.FromArgb(178, 178, 178);
            }
            if (txtPassword.Text == "Password")
            {

                txtPassword.Clear();

            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            txtUsername.ForeColor = Color.FromArgb(255, 255, 255);

            pnlUsername.BackColor = Color.FromArgb(255, 195, 14);
            pnlPassword.BackColor = Color.FromArgb(255, 255, 255);
            pictureBoxUsername.Image = Properties.Resources._2203549_20_YELLOW;
            pictureBoxPassword.Image = Properties.Resources._1564520_20;
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
            if ((txtPassword.Text == "Password") || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.ForeColor = Color.FromArgb(178, 178, 178);
            }
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
            if (!(txtPassword.Text == "Password") && !(string.IsNullOrWhiteSpace(txtPassword.Text)))
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = Color.FromArgb(255, 255, 255);

            pnlPassword.BackColor = Color.FromArgb(255, 195, 14);
            pnlUsername.BackColor = Color.FromArgb(255, 255, 255);
            pictureBoxUsername.Image = Properties.Resources._2203549_20;
            pictureBoxPassword.Image = Properties.Resources._1564520_20_YELLOW;

            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            if ((txtUsername.Text == "Username") || string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.ForeColor = Color.FromArgb(178, 178, 178);
            }
            if (txtPassword.Text == "Password")
            {

                txtPassword.Clear();

            }
        }

  

       
    }
}
