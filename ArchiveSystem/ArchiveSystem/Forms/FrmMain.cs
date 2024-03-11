using ArchiveSystem.Classes;
using ArchiveSystem.Properties;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();

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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //    if (VariablesClass.usersPermission == false)
            //    {
            //        btnUsers.Visible = false;
            //    }
            //    if (VariablesClass.settingsPermission == false)
            //    {
            //        btnSetings.Visible = false;
            //    }
            //    try
            //    {
            //        ConClass.sqlQuery = "SELECT * FROM TblUsers";
            //        ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
            //        dt = new DataTable();
            //        ConClass.da.Fill(dt);

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("فشل في الإتصال بقاعدة البيانات" +
            //            Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    for (int i = 0; i <= dt.Rows.Count - 1; i++)
            //    {
            //        if (dt.Rows[i][4] is DBNull == false)
            //        {
            //            byte[] img = (byte[])dt.Rows[i][4];
            //            var ms = new MemoryStream(img);
            //            picUser.Image = Image.FromStream(ms);

            //        }
            //        else
            //            picUser.Image = Resources.user;
            //    }

            //    tssLblDateTime.Text = Convert.ToString(DateTime.Now.Date) + " - " + DateTime.Now.TimeOfDay.ToString();
            //    tssLblUser.Text = " المستخدم  : " + VariablesClass.userName + " - " + VariablesClass.userJob;
            //    tssLblUser.Margin = new Padding(this.Width - (tssLblUser.Width + tssLblDateTime.Width + 50), 5, 0, 5);
            //}

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        
    }
}
