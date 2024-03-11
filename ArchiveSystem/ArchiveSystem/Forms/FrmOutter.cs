using ArchiveSystem.Classes;
using ArchiveSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem.Forms
{
    public partial class FrmOutter : Form
    {
        public FrmOutter()
        {
            InitializeComponent();
        }
        ResizeControls r = new ResizeControls();
        DataTable dtContacts = new DataTable(), dtNum = new DataTable(), dtOutter = new DataTable();
        int outterId;
        Outter outter = new Outter();
        byte[] fileData;
        int cr = -1;
        long oldNum;
        int oldYear;
        string oldFileName, oldFileExtension;

        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmOutter_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmOutter_Load(object sender, EventArgs e)
        {
            setFormSize();
            setPermissions();
            setCmbYear();

           getContacts();
           getNewNum();
            getData();

            txtSubject.Select();
            dgvOutter.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
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
        void setPermissions()
        {
            if (VariablesClass.updatePermission == false)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            if (VariablesClass.insertPermission == false)
            {
                btnAddd.Enabled = false;
            }
        }
        void setCmbYear()
        {
            cmbYear.Items.Clear();
            cmbSearchYear.Items.Clear();
            for (int i = DateTime.Now.Date.Year; i >= DateTime.Now.Date.Year - 10; i--)
            {
                cmbYear.Items.Add(i);
                cmbSearchYear.Items.Add(i);
            }
            cmbYear.SelectedIndex = 0;
        }
        private void getContacts()
        {
            try
            {
                dtContacts.Clear();
                ConClass.sqlQuery = "SELECT * FROM TblContacts ORDER BY ContactName ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtContacts);

                cmbContacts.DataSource = dtContacts;
                cmbContacts.DisplayMember = "ContactName";
                cmbContacts.ValueMember = "Id";
                cmbContacts.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void getNewNum()
        {
            try
            {
                dtNum.Clear();
                ConClass.sqlQuery = "DECLARE @Num int SELECT @Num=MAX(Num) + 1 FROM TblOutters where [Year]=" + cmbYear.Text + " IF @Num IS NULL SET @Num=1 SELECT @Num";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtNum);
                txtNum.Text = string.Format(dtNum.Rows[0][0].ToString(), "0000");
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }



        private void getData()
        {
            try
            {
                dtOutter.Clear();
                ConClass.sqlQuery = "SELECT TblOutters.*,TblContacts.ContactName,TblUsers.UserName from TblOutters,TblContacts,TblUsers WHERE TblContacts.Id=TblOutters.ContactId AND TblUsers.Id=TblOutters.UserId AND [YEAR]=" + cmbYear.Text + " ORDER BY Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtOutter);
                fillDgvOutter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void fillDgvOutter()
        {
            dgvOutter.Rows.Clear();
            for (int i = 0; i <= dtOutter.Rows.Count - 1; i++)
            {
                dgvOutter.Rows.Add();
                dgvOutter.Rows[i].Cells[0].Value = dtOutter.Rows[i][0];
                dgvOutter.Rows[i].Cells[1].Value = i + 1;
                dgvOutter.Rows[i].Cells[2].Value = dtOutter.Rows[i][1].ToString() + "/" + dtOutter.Rows[i][2];
                dgvOutter.Rows[i].Cells[3].Value = dtOutter.Rows[i][3];
                dgvOutter.Rows[i].Cells[4].Value = dtOutter.Rows[i][12];
                dgvOutter.Rows[i].Cells[5].Value = dtOutter.Rows[i][5];
                dgvOutter.Rows[i].Cells[6].Value = dtOutter.Rows[i][6];
                dgvOutter.Rows[i].Cells[7].Value = dtOutter.Rows[i][7].ToString() + dtOutter.Rows[i][8].ToString();

                

                dgvOutter.Rows[i].Cells[8].Value = dtOutter.Rows[i][12];
            }
            dgvOutter.ClearSelection();
        }

        private void picContact_Click(object sender, EventArgs e)
        {
            FrmContacts frmContacts = new FrmContacts();

            if (cmbContacts.SelectedValue == null) 
                frmContacts.txtAddContact.Text = cmbContacts.Text;

            frmContacts.ShowDialog();
            getContacts();
        }

        private void btnFileBrowse_Click(object sender, EventArgs e)
        {
            getFileInfo();
        }
        private void getFileInfo()
        {
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.ReadOnly = false;
                txtFileName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                lblFileExtension.Text = Path.GetExtension(ofd.FileName);
                picFileIcon.Image = Icon.ExtractAssociatedIcon(ofd.FileName).ToBitmap();
                fileData = File.ReadAllBytes(ofd.FileName);

            }
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == "")
                return;

            sfd.FileName = txtFileName.Text.Trim();
            sfd.Filter = "FILE | *" + lblFileExtension.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, fileData);

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void btnFileShow_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == "")
                return;
            try
            {
                var fullName = Path.GetTempPath() + @"\ArchiveSystemTempFile" + txtFileName.Text.Trim() + lblFileExtension.Text;

            }
            catch (Exception)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = "لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك";
                notifyIcon1.ShowBalloonTip(1);
            }
            showFromDisk();

        }
        void showFromDisk()
        {
            try
            {
                string fullpath = Settings.Default.DiskArchivePath + @"\" + "البريد الصادر" + @"\" + oldYear + @"\" + "(" + oldNum + ") " + oldFileName + oldFileExtension;
                Process.Start(fullpath);
            }

            catch (Exception)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = " لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك أو الملف غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void btnFileCancel_Click(object sender, EventArgs e)
        {
            fileData = null;
            txtFileName.Text = "";
            lblFileExtension.Text = "";
            picFileIcon.Image = null;
            txtFileName.ReadOnly = true;
            btnFileSave.Enabled = false;
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (outterId == 0 & dtNum.Rows.Count != 0) // حتى لا يتم استدعائه في الفورم لود مرتين
            {
                getNewNum();
                getData();
            }
        }

        private void dgvOutter_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOutter.CurrentRow == null) return;
                if (dgvOutter.CurrentRow.Index == dgvOutter.Rows.Count
                    | dgvOutter.Rows[dgvOutter.CurrentRow.Index].Cells[0].Value == null
                    | dgvOutter.Rows[dgvOutter.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            cr = dgvOutter.CurrentRow.Index;
            displayData();
        }
        private void displayData()
        {
            outterId = (int)dgvOutter.Rows[cr].Cells[0].Value;
            getFileFromSQL();


            txtNum.Text = String.Format(dtOutter.Rows[cr][1].ToString(), "0000");
            cmbYear.Text = dtOutter.Rows[cr][2].ToString();
            txtSubject.Text = dtOutter.Rows[cr][3].ToString();
            cmbContacts.SelectedValue = dtOutter.Rows[cr][4];

            dtpMsgDate.Value = (DateTime)dtOutter.Rows[cr][5];
            dtpRegDate.Value = (DateTime)dtOutter.Rows[cr][6];
            txtNotes.Text = dtOutter.Rows[cr][10].ToString();
            txtFileName.Text = dtOutter.Rows[cr][7].ToString();
            lblFileExtension.Text = dtOutter.Rows[cr][8].ToString();
            

            btnFileSave.Enabled = true;
            txtFileName.ReadOnly = false;

            //--------------------SaveOldFileInfo-----------------------------
            oldNum = (long)dtOutter.Rows[cr][1];
            oldYear = (int)dtOutter.Rows[cr][2];
            oldFileName = dtOutter.Rows[cr][7].ToString();
            oldFileExtension = dtOutter.Rows[cr][8].ToString();
            //---------------------------------------------------------------
        }

        private void dgvOutter_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvOutter.SortOrder.ToString() == "Ascending")
                dtOutter.DefaultView.Sort = dgvOutter.SortedColumn.Name + " ASC";
            else if (dgvOutter.SortOrder.ToString() == "Descending")
                dtOutter.DefaultView.Sort = dgvOutter.SortedColumn.Name + " DESC";

            dtOutter = dtOutter.DefaultView.ToTable();
        }

        private void dgvOutter_Sorted(object sender, EventArgs e)
        {
            clearData();
            getNewNum();
        }

        private void radSearchNum_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearchNum.Checked == true)
            {
                txtSearchNum.Enabled = true;
                cmbSearchYear.Enabled = true;
                txtSearchSubject.Enabled = false;
                txtSearchSubject.Text = "";
                txtSearchNum.Focus();
            }
            else
            {
                txtSearchNum.Enabled = false;
                cmbSearchYear.Enabled = false;
                txtSearchNum.Text = "";
                cmbSearchYear.Text = "";
                txtSearchSubject.Enabled = true;
                txtSearchSubject.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (radSearchNum.Checked == true)
            {
                if (txtSearchNum.Text.Trim() == "")
                {
                    MessageBox.Show("الرجاء إدخال الرقم الإشاري", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cmbSearchYear.Text.Trim() == "")
                {
                    MessageBox.Show("الرجاء اختيار السنة", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cmbYear.Text = cmbSearchYear.Text;
                getData();
                for (int i = 0; i <= dtOutter.Rows.Count - 1; i++)
                {
                    if (txtSearchNum.Text.Trim() == dtOutter.Rows[i][1].ToString())
                    {
                        dgvOutter.Rows[i].Selected = true;
                        dgvOutter.FirstDisplayedScrollingRowIndex = i;
                        cr = i;
                        displayData();
                        return;
                    }
                }
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "البريد الصادر غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }
            else
            {
                if (txtSearchSubject.Text == "")
                {
                    MessageBox.Show("الرجاء إدخال موضوع الرسالة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dtOutter.Clear();
                ConClass.sqlQuery = "select TblOutters.*,TblContacts.ContactName,UserName from TblOutters,TblContacts,TblUsers  where TblContacts.Id=TblOutters.ContactID and TblUsers.Id=TblOutters.UserId and Subject like '%" + txtSearchSubject.Text.Trim() + "%' ORDER BY YEAR DESC,Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtOutter);
                clearData();
                getNewNum();
                if (dtOutter.Rows.Count > 0)
                {
                    fillDgvOutter();
                }
                else
                {
                    getData();
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.BalloonTipText = "البريد الصادر غير موجود";
                    notifyIcon1.ShowBalloonTip(1);
                }

            }
        }

        private void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            txtSearchNum.Text = "";
            cmbSearchYear.SelectedIndex = -1;
            txtSearchSubject.Text = "";
            radSearchNum.Checked = true;

            btnRefresh_Click(sender, e);
        }

        private void txtSearchNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if (e.KeyChar == (int)Keys.Back)
                e.Handled = false;
        }

        private void cmbSearchYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if (e.KeyChar == (int)Keys.Back)
                e.Handled = false;
        }

        private void cmbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if (e.KeyChar == (int)Keys.Back)
                e.Handled = false;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false)
                e.Handled = true;

            if (e.KeyChar == (int)Keys.Back)
                e.Handled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (outterId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد تريد الحذف", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                outter.OutterId=outterId;
                outter.deleteOutter();
                if (ConClass.cmd.ExecuteNonQuery() > 0)
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "تم الحذف بنجاح";
                    notifyIcon1.ShowBalloonTip(1);
                    btnRefresh_Click(sender, e);
                }
                else
                {
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.BalloonTipText = "خطأ في الحذف";
                    notifyIcon1.ShowBalloonTip(1);
                }

                ConClass.con.Close();
            }
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            if (outterId != 0)
            {
                MessageBox.Show("الرجاء الضفط على تحديث لإلغاء العناصر المحددة", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNum.Text == "" | cmbYear.Text == "" | txtSubject.Text == "")
            {
                MessageBox.Show("الرجاء إدخال كافة البيانات ", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbContacts.SelectedValue == null)
            {
                MessageBox.Show("الرجاء إختيار المرسل اليه", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbContacts.Focus();
                return;
            }

            if (txtFileName.Text == "" & picFileIcon.Image == null)
            {
                MessageBox.Show("الرجاء إختيار الملف المراد أرشفته", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            else if (txtFileName.Text == "" & picFileIcon.Image != null)
            {
                MessageBox.Show("الرجاء إدخال اسم الملف", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            //.....................................................
            outter.year = Convert.ToInt32(cmbYear.Text);
            outter.Subject = txtSubject.Text.Trim();
            outter.ContactId = Convert.ToInt32(cmbContacts.SelectedValue);
            outter.SendDate = dtpMsgDate.Value.Date;
            outter.RegisterDate = dtpRegDate.Value.Date;
            outter.FileName = txtFileName.Text.Trim();
            outter.FileData = fileData;
            outter.FileExtension = lblFileExtension.Text;
            outter.Note = txtNotes.Text.Trim();
            outter.UserId = VariablesClass.userId;
            outter.SaveOutter();
            //..........................................................
            if (VariablesClass.saveState == 1)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);
                btnRefresh_Click(sender, e);
            }

            else if (VariablesClass.saveState == 2)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "البيانات موجودة مسبقاً";
                notifyIcon1.ShowBalloonTip(1);
            }
            else if (VariablesClass.saveState == 0)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "خطأ في تنفيذ العملية";
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (outterId != 0)
            {
                MessageBox.Show("الرجاء الضفط على تحديث لإلغاء العناصر المحددة", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNum.Text == "" | cmbYear.Text == "" | txtSubject.Text == "")
            {
                MessageBox.Show("الرجاء إدخال كافة البيانات ", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbContacts.SelectedValue == null)
            {
                MessageBox.Show("الرجاء إختيار المرسل اليه", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbContacts.Focus();
                return;
            }

            if (txtFileName.Text == "" & picFileIcon.Image == null)
            {
                MessageBox.Show("الرجاء إختيار الملف المراد أرشفته", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            else if (txtFileName.Text == "" & picFileIcon.Image != null)
            {
                MessageBox.Show("الرجاء إدخال اسم الملف", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            //.....................................................
            outter.year = Convert.ToInt32(cmbYear.Text);
            outter.Subject = txtSubject.Text.Trim();
            outter.ContactId = Convert.ToInt32(cmbContacts.SelectedValue);
            outter.SendDate = dtpMsgDate.Value.Date;
            outter.RegisterDate = dtpRegDate.Value.Date;
            outter.FileName = txtFileName.Text.Trim();
            outter.FileData = fileData;
            outter.FileExtension = lblFileExtension.Text;
            outter.Note = txtNotes.Text.Trim();
            outter.UserId = VariablesClass.userId;
            outter.SaveOutter();
            //..........................................................
            if (VariablesClass.saveState == 1)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);
                btnRefresh_Click(sender, e);
            }

            else if (VariablesClass.saveState == 2)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "البيانات موجودة مسبقاً";
                notifyIcon1.ShowBalloonTip(1);
            }
            else if (VariablesClass.saveState == 0)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "خطأ في تنفيذ العملية";
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (outterId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNum.Text == "" | cmbYear.Text == "" | txtSubject.Text == "")
            {
                MessageBox.Show("الرجاء إدخال كافة البيانات ", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbContacts.SelectedValue == null)
            {
                MessageBox.Show("الرجاء إختيار المرسل اليه", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbContacts.Focus();
                return;
            }
            if (txtFileName.Text.Trim() == "" & picFileIcon.Image == null == true)
            {
                MessageBox.Show("الرجاء إدخال اسم الملف المراد أرشفته", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            else if (txtFileName.Text.Trim() == "" & picFileIcon.Image == null == false)
            {
                MessageBox.Show("الرجاء إختيار اسم الملف", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFileName.Focus();
                return;
            }
            outter.OutterId = outterId;
            outter.Number = Convert.ToInt32(txtNum.Text);
            outter.year = Convert.ToInt32(cmbYear.Text);
            outter.Subject = txtSubject.Text.Trim();
            outter.ContactId = Convert.ToInt32(cmbContacts.SelectedValue);
            outter.SendDate = dtpMsgDate.Value.Date;
            outter.RegisterDate = dtpRegDate.Value.Date;
            outter.FileName = txtFileName.Text.Trim();
            outter.FileData = fileData;
            outter.FileExtension = lblFileExtension.Text;
            outter.Note = txtNotes.Text.Trim();
            outter.UserId = VariablesClass.userId;
            outter.updateOutter();
            VariablesClass.saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
            if (VariablesClass.saveState == 1)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);

                btnRefresh_Click(sender, e);
            }
            else if (VariablesClass.saveState == 2)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "البيانات موجودة مسبقاً";
                notifyIcon1.ShowBalloonTip(1);
            }
            else if (VariablesClass.saveState == 0)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipText = "لم يتم الحفظ" + Environment.NewLine + "خطأ في تنفيذ العملية";
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            getContacts();
            getNewNum();
            getData();
        }
        void getFileFromSQL()
        {
            var dtFile = new DataTable();
            try
            {
                ConClass.sqlQuery = "SELECT * FROM TblOutterFiles WHERE outterId=" + outterId;
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtFile);

                if (!(dtFile.Rows[0][1] is DBNull))  
                    fileData = (byte[])dtFile.Rows[0][1];
            }
            catch (Exception ex)
            {
                btnFileCancel.PerformClick();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearData()
        {
            ComboBox cmb = default;
            foreach (Control c in grpInfo.Controls)
            {
                if (c is TextBox)
                    c.Text = "";

                if (c is ComboBox)
                    if (c.Name != "cmbYear")
                    {
                        cmb = (ComboBox)c;
                        cmb.SelectedIndex = -1;
                    }
            }

            btnFileCancel.PerformClick();

            dgvOutter.ClearSelection();
            outterId = 0;
            cr = -1;

            dtpMsgDate.Value = DateTime.Now;
            dtpRegDate.Value = DateTime.Now;
            txtSubject.Focus();
        }

        
            
       
    }
}
