using ArchiveSystem.Classes;
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

namespace ArchiveSystem.Forms
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        
        UserClass user = new UserClass();  
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = VariablesClass.userName;
            txtOldPass.Select();
            lblError.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == string.Empty)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();
                return;
            }
            if (txtNewPass.Text == string.Empty)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPass.Focus();
                return;
            }
            user.userPassword = txtNewPass.Text;
            user.changePass(user);
            this.Close();
        }
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void txtOldPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPass.Focus();
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtOldPass.Text != VariablesClass.userPassword)
            {
                txtOldPass.Text = "";
                txtOldPass.Focus();
                lblError.Visible = true;
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void pic1_MouseDown(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = false;

        }

        private void pic1_MouseUp(object sender, MouseEventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = true;
            chkShowPass.Checked = false;
        }

     

        private void pic2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;

        }

        private void pic2_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
            chkShowPass.Checked = false;
        }
    }
}
