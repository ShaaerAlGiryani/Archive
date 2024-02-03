using ArchiveSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem.Forms
{
    public partial class userform : Form
    {
        public userform()
        {
            InitializeComponent();
        }
        
        UserClass user = new UserClass();
        int currentUserID = 0, cr = -1;

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            txtUserPassword.Text = "0000";

        }

        private void picUpdate_Click(object sender, EventArgs e)
        {

        }

        private void picAdd_Click(object sender, EventArgs e)
        {
        }
    }
}
