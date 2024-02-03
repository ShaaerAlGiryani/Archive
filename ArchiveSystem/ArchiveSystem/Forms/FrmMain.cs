using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void btnOutter_Click(object sender, EventArgs e)
        {
            FrmOutter frmOutter = new FrmOutter();
            frmOutter.ShowDialog();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers(); 
            frmUsers.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }
    }
}
