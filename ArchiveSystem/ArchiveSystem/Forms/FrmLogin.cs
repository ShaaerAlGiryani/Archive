using ArchiveSystem.Classes;
using ArchiveSystem.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace ArchiveSystem.Forms
{
    public partial class FrmLogin : Form
    {
        bool swClose;
        DataSet ds = new DataSet();
        int timerCount;
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SQLConClass sQLCon = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblUsers";
            ds = sQLCon.selectData(SQLConClass.sqlQuery, 0, default);
            if (ds.Tables.Count > 0)
            {
                cmbUserName.DataSource = ds.Tables[0];
                cmbUserName.DisplayMember = "userName";
                cmbUserName.ValueMember = "Id";

                cmbUserName.SelectedValue = Settings.Default.SelectedUser;
                cmbUserName_SelectionChangeCommitted(sender, e);
                txtPassword.Select();
            }
            else
            {
                FrmAdmin frmAdmin = new FrmAdmin();
                frmAdmin.ShowDialog();
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbUserName.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ادخال اسم المستخدم", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ادخال كلمة المرور", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }

            DataRow[] itemRows = ds.Tables[0].Select("userName='" + cmbUserName.Text + "'");
            if (itemRows.Length > 0)
            {
                if (txtPassword.Text == itemRows[0][2].ToString())
                {
                    if (txtPassword.Text == "0000")
                    {
                        MessageBox.Show("يرجى تغيير كلمة المرور الإفتراضية");
                        FrmChangePassword frmChangePassword = new FrmChangePassword();
                        frmChangePassword.ShowDialog();
                        if (VariablesClass.userPassword == "0000")
                        {
                            MessageBox.Show("لم يتم تغيير كلمة المرور الافتراضية، سيتم اغلاق النظام", "رفض الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.ShowDialog();
                    }

                    swClose = true;
                    Settings.Default.ErrorLoginCount = 0;
                    this.Close();
                }
                else
                {
                    Settings.Default.ErrorLoginCount++;
                    Settings.Default.Save();
                    if (Settings.Default.ErrorLoginCount < 3)
                    {
                        MessageBox.Show("كلمة المرور غير صحيحة لقد استنفذت " + Settings.Default.ErrorLoginCount + " من 3 محاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Clear();
                        txtPassword.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("لقد استنفذت جميع المحاولات", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        timerCount = 30;
                        lblTimerCount.Text = timerCount.ToString();
                        lblTimerCount.Visible = true;
                        this.Enabled = false;
                        timer2.Enabled = true;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("اسم المستخدم غير مسجل في المنظومة", "خطأ ادخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbUserName.SelectAll();
                cmbUserName.Focus();
            }
        }
        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }
        private void cmbUserName_TextChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedValue == null)
            {
                lblUser.Text = "";
                picUser.Image = null;
               // FrmMain.picUser.Image = null;
            }
        }
        private void cmbUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedValue == null)
            {
                lblUser.Text = "";
                return;
            }

            lblUser.Text = "رقم التسجيل >> " + cmbUserName.SelectedValue;
            Settings.Default.SelectedUser = Convert.ToInt32(cmbUserName.SelectedValue);
            Settings.Default.Save();


            DataRow[] itemRows = ds.Tables[0].Select("Id=" + cmbUserName.SelectedValue); // Dim itemRows() As DataRow = ds.Tables[0].Select("Id=" & cmbUserName.SelectedValue & " AND UserPIC IS NOT NULL")
            if (itemRows.Length > 0)
            {

                //if (!(itemRows[0][6] is DBNull))
                //{
                //    picUser.Image = FunctionsClass.byteToImage((byte[])itemRows[0][6]);
                //    frmMain.picUser.Image = FunctionsClass.byteToImage((byte[])itemRows[0][6]);
                //}
                //else
                //{
                //    picUser.Image = Resources.user;
                //    frmMain.picUser.Image = Resources.user;
                //}

                VariablesClass.userId = (int)itemRows[0][0];
                VariablesClass.userName = itemRows[0][1].ToString();
                VariablesClass.userPassword = itemRows[0][2].ToString();
                VariablesClass.userJob = itemRows[0][3].ToString();
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            cmbUserName_SelectionChangeCommitted(sender, e);
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (swClose == false)
                Environment.Exit(0);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerCount--;
            lblTimerCount.Text = timerCount.ToString();
            if (timerCount == 0)
            {
                lblTimerCount.Visible = false;
                this.Enabled = true;
                timer2.Enabled = false;
                txtPassword.Text = "";
                txtPassword.Focus();
                Settings.Default.ErrorLoginCount = 0;
                Settings.Default.Save();
            }
        }
    }
}
