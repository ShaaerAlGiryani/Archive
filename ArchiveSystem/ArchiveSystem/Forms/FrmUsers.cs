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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        int currentUserID = 0, cr = -1;
        DataTable dtUsers = new DataTable();
        UserClass user = new UserClass();


        ResizeControls r = new ResizeControls();
        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            fillDgvUsers();

            setFormSize();
        }
        void setFormSize()
        {
            FrmMain frmMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (frmMain != null)
            {
                this.Size = frmMain.Size - new Size(0, 60);
                this.Left = frmMain.Left;
                this.Top = frmMain.Top + 30;
            }
        }
        void fillDgvUsers()
        {
            dgvUsers.Rows.Clear();
            dtUsers.Clear();

            try
            {
                ConClass.sqlQuery = "SELECT * FROM TblUsers";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtUsers);
                //dgvUsers.DataSource = dtUsers;
                for (int i = 0; i <= dtUsers.Rows.Count - 1; i++)
                {
                    dgvUsers.Rows.Add();

                    dgvUsers.Rows[i].Cells[0].Value = dtUsers.Rows[i][0];

                    dgvUsers.Rows[i].Cells[1].Value = i + 1;
                    dgvUsers.Rows[i].Cells[2].Value = dtUsers.Rows[i][1];
                    dgvUsers.Rows[i].Cells[3].Value = "************"; // dtUsers.Rows[i][2];
                    dgvUsers.Rows[i].Cells[4].Value = dtUsers.Rows[i][3];
                    dgvUsers.Rows[i].Cells[5].Value = dtUsers.Rows[i][0];

                    dgvUsers.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                    if ((bool)dtUsers.Rows[i][5] == true & (bool)dtUsers.Rows[i][6] == true & (bool)dtUsers.Rows[i][7] == true & (bool)dtUsers.Rows[i][8] == true & (bool)dtUsers.Rows[i][9] == true)
                    {
                        dgvUsers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    }

                    if (dtUsers.Rows[i][4] is DBNull == false)
                    {
                        byte[] img = (byte[])dtUsers.Rows[i][4];     // تخزين الصورة في مصفوفة من البايتات
                        var ms = new MemoryStream(img);                // حجز مساحة في الذاكرة لتركيب الصورة من مصفوفة البايتات 'Imports System.IO
                        dgvUsers.Rows[i].Cells[6].Value = Image.FromStream(ms);
                    }
                }
                dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.CurrentRow == null) return;
                if (dgvUsers.CurrentRow.Index == dgvUsers.Rows.Count
                    | dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == null
                    | dgvUsers.Rows[dgvUsers.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            if ((int)dgvUsers.Rows[dgvUsers.CurrentRow.Index].Cells[0].Value == 1 & VariablesClass.userId != 1)
            {
                clearText();
                return;
            }

            cr = dgvUsers.CurrentRow.Index;

            currentUserID = (int)dgvUsers.Rows[cr].Cells[0].Value;
            txtUserName.Text = dgvUsers.Rows[cr].Cells[2].Value.ToString();
            txtUserPassword.Text = dgvUsers.Rows[cr].Cells[3].Value.ToString();
            txtUserJob.Text = dgvUsers.Rows[cr].Cells[4].Value.ToString();
            picUser.Image = (Image)dgvUsers.Rows[cr].Cells[6].Value;

            if (picUser.Image != null)
                picUser.ContextMenuStrip = contextMenuStrip1;
            else
                picUser.ContextMenuStrip = null;

            if (chkAdmin.Checked == true)
                chkAdmin.Checked = false;
            else
                chkAdmin_CheckedChanged(sender, e);

            chkUpdate.Checked = (bool)dtUsers.Rows[cr][5];
            chkInsert.Checked = (bool)dtUsers.Rows[cr][6];
            chkPrint.Checked = (bool)dtUsers.Rows[cr][7];
            chkUsers.Checked = (bool)dtUsers.Rows[cr][8];
            chkSettings.Checked = (bool)dtUsers.Rows[cr][9];
        }

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            txtUserPassword.Text = "0000";
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked == true)
            {
                foreach (CheckBox c in pnlPermissions.Controls)
                {
                    if (c.Name != "chkAdmin")
                    {
                        c.Checked = true;
                        c.Enabled = false;
                    }
                }
            }
            else if (chkAdmin.Checked == false)
            {
                foreach (CheckBox c in pnlPermissions.Controls)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }
        }

        private void chkInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUpdate.Checked == true & chkInsert.Checked == true & chkPrint.Checked == true & chkUsers.Checked == true & chkSettings.Checked == true)
                chkAdmin.Checked = true;
        }

        private void picUser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picUser.Image = Image.FromFile(openFileDialog1.FileName);
                    picUser.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void cmsDeletePicture_Click(object sender, EventArgs e)
        {
            picUser.Image = null;
            picUser.ContextMenuStrip = null;
        }

        public void picRefresh_Click(object sender, EventArgs e)
        {
            
            clearText();
            fillDgvUsers();
        }
        void clearText()
        {
            picUser.Image = null;

            foreach (Control c in grpUserInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }

            foreach (CheckBox c in pnlPermissions.Controls)
            {
                if (c is CheckBox)
                {
                    c.Checked = false;
                    c.Enabled = true;
                }
            }

            currentUserID = 0;
            cr = -1;
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsers.SortOrder.ToString() == "Ascending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " ASC";
            else if (dgvUsers.SortOrder.ToString() == "Descending")
                dtUsers.DefaultView.Sort = dgvUsers.SortedColumn.Name + " DESC";

            dtUsers = dtUsers.DefaultView.ToTable();
        }

        private void dgvUsers_Sorted(object sender, EventArgs e)
        {
            clearText();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
                return;

            if (currentUserID == VariablesClass.userId)
            {
                MessageBox.Show("لا يمكنك حذف نفسك", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show(" هل تريد بالتأكيد حذف " + txtUserName.Text, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.userId = currentUserID;
                user.deleteUser(user);
                picRefresh_Click(sender, e);         
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (currentUserID != 0)
                return;

            if (txtUserName.Text.Trim() == "" | txtUserPassword.Text == "" | txtUserJob.Text == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentUserID != 0)
                return;

            if (txtUserName.Text.Trim() == "" | txtUserPassword.Text == "" | txtUserJob.Text == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user.userName = txtUserName.Text;
            user.userPassword = txtUserPassword.Text;
            user.userJob = txtUserJob.Text;
            user.updateP = chkUpdate.Checked;
            user.insertP = chkInsert.Checked;
            user.printP = chkPrint.Checked;
            user.settingsP = chkSettings.Checked;
            user.userP = chkUsers.Checked;
            //if (picUser.Image == null)
            //{

            //}
            //else
            //{
            //    // --------------------------------------------------
            //    var ms = new MemoryStream();
            //    picUser.Image.Save(ms, picUser.Image.RawFormat);
            //    byte[] img = ms.ToArray();
            //    user.picUser = img[0];
            //}
            user.insertUser(user);
            picRefresh_Click(sender, e);
        }


        private void picUpdate_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
                return;

            if (txtUserName.Text.Trim() == "" | txtUserPassword.Text == "" | txtUserJob.Text.Trim() == "")
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            user.userId = currentUserID;
            user.userName = txtUserName.Text;
            user.userPassword = txtUserPassword.Text;
            user.userJob = txtUserJob.Text;
            user.updateP = chkUpdate.Checked;
            user.insertP = chkInsert.Checked;
            user.printP = chkPrint.Checked;
            user.settingsP = chkSettings.Checked;
            user.userP = chkUsers.Checked;
            user.updatetUser(user);
            picRefresh_Click(sender, e);
        }
    }
}
