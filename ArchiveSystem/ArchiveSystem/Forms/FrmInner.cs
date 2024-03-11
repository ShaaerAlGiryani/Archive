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
    public partial class FrmInner : Form
    {
        public FrmInner()
        {
            InitializeComponent();
        }

        DataTable dtContacts = new DataTable(), dtInner = new DataTable(), dtNum = new DataTable();
        int cr = -1;
        int innerId;
        string oldfileName, oldfileExtension;
        byte[] fileData;
        long oldNum;
        int oldYear;
        Inner inner = new Inner();
        ResizeControls r = new ResizeControls();
        private void FrmMain_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmInner_Load(object sender, EventArgs e)
        {
            setFormSize();
            setPermissions();
            setCmbYear();

            getContacts();
            getNewNum();
            getData();

            txtSubject.Select();
            dgvInner.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);


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
                picDelete.Enabled = false;
                picUpdate.Enabled = false;
            }
            if (VariablesClass.insertPermission == false)
            {
                picAdd.Enabled = false;
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

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (innerId == 0 & dtNum.Rows.Count != 0) // حتى لا يتم استدعائه في الفورم لود مرتين
            {
                getNewNum();
                getData();
            }
        }

        private void dgvInner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInner.CurrentRow == null) return;
                if (dgvInner.CurrentRow.Index == dgvInner.Rows.Count
                    | dgvInner.Rows[dgvInner.CurrentRow.Index].Cells[0].Value == null
                    | dgvInner.Rows[dgvInner.CurrentRow.Index].Selected == false)
                    return;
            }
            catch
            {
                return;
            }

            cr = dgvInner.CurrentRow.Index;
            displayData();
        }
        private void displayData()
        {
            innerId = (int)dgvInner.Rows[cr].Cells[0].Value;
            getFileFromSQL();


            txtNum.Text = String.Format(dtInner.Rows[cr][1].ToString(), "0000");
            cmbYear.Text = dtInner.Rows[cr][2].ToString();
            txtRecivedNum.Text = dtInner.Rows[cr][3].ToString();
            txtSubject.Text = dtInner.Rows[cr][4].ToString();
            cmbContacts.SelectedValue = dtInner.Rows[cr][5];

            dtpMsgDate.Value = (DateTime)dtInner.Rows[cr][6];
            dtpRegDate.Value = (DateTime)dtInner.Rows[cr][7];
            txtNotes.Text = dtInner.Rows[cr][11].ToString();
            txtFileName.Text = dtInner.Rows[cr][8].ToString();
            lblFileExtension.Text = dtInner.Rows[cr][9].ToString();
            

            btnFileSave.Enabled = true;
            txtFileName.ReadOnly = false;

            //--------------------SaveOldFileInfo-----------------------------
            oldNum = (long)dtInner.Rows[cr][1];
            oldYear = (int)dtInner.Rows[cr][2];
            oldfileName = dtInner.Rows[cr][8].ToString();
            oldfileExtension = dtInner.Rows[cr][9].ToString();
            //---------------------------------------------------------------
            getFileFromDisk();
        }
        void getFileFromDisk()
        {
            try
            {
                string fullpath = Settings.Default.DiskArchivePath + @"\" + "البريد الصادر" + @"\" + oldYear + @"\" + "(" + oldNum + ") " + oldfileName + oldfileExtension;

                fileData = File.ReadAllBytes(fullpath);
            }

            catch (Exception)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = " لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك أو الملف غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }
        }
        void getFileFromSQL()
        {
            var dtFile = new DataTable();
            try
            {
                ConClass.sqlQuery = "SELECT * FROM TblInnerFiles WHERE InnerId=" + innerId;
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtFile);

                if (!(dtFile.Rows[0][1] is DBNull))  //  if (dtFile.Rows[0][1] is DBNull == false)
                    fileData = (byte[])dtFile.Rows[0][1];
            }
            catch (Exception ex)
            {
                btnFileCancel.PerformClick();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInner_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvInner.SortOrder.ToString() == "Ascending")
                dtInner.DefaultView.Sort = dgvInner.SortedColumn.Name + " ASC";
            else if (dgvInner.SortOrder.ToString() == "Descending")
                dtInner.DefaultView.Sort = dgvInner.SortedColumn.Name + " DESC";

            dtInner = dtInner.DefaultView.ToTable();
        }

        private void dgvInner_Sorted(object sender, EventArgs e)
        {
            clearData();
            getNewNum();
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

            dgvInner.ClearSelection();
            innerId = 0;
            cr = -1;

            dtpMsgDate.Value = DateTime.Now;
            dtpRegDate.Value = DateTime.Now;
            txtSubject.Focus();
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == "")
                return;

            sfd.FileName = txtFileName.Text.Trim();
            sfd.Filter = "FILE | *" + lblFileExtension.Text;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sfd.FileName, fileData);   //fileData = File.ReadAllBytes(OFD.fileName);

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


                //File.WriteAllBytes(fullName, fileData);  


                //Process.Start(fullName); 
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
                string fullpath = Settings.Default.DiskArchivePath + @"\" + "البريد الوارد" + @"\" + oldYear + @"\" + "(" + oldNum + ") " + oldfileName + oldfileExtension;

                //string yearPath = Settings.Default.DiskArchivePath + @"\" + "البريد الصادر" + @"\" + oldYear;
                //string fullpath = yearPath + @"\" + "(" + oldNum + ") " + oldFileName + oldFileExtension;

                Process.Start(fullpath);
            }

            catch (Exception)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.BalloonTipText = " لا يمكن عرض الملف، البرنامج المشغل للملف غير متوفر في جهازك أو الملف غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }
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

        private void btnFileCancel_Click(object sender, EventArgs e)
        {
            fileData = null;
            txtFileName.Text = "";
            lblFileExtension.Text = "";
            picFileIcon.Image = null;
            txtFileName.ReadOnly = true;
            btnFileSave.Enabled = false;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (innerId != 0)
            {
                MessageBox.Show("الرجاء الضفط على تحديث لإلغاء العناصر المحددة", "اضافة بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNum.Text == "" | cmbYear.Text == "" | txtSubject.Text == "" | txtRecivedNum.Text == "")
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
            inner.year = Convert.ToInt32(cmbYear.Text);
            inner.RecivedNum = Convert.ToInt32(txtRecivedNum.Text);
            inner.Subject = txtSubject.Text;
            inner.ContactId = Convert.ToInt32(cmbContacts.SelectedValue);
            inner.SendDate = dtpMsgDate.Value.Date;
            inner.RegisterDate = dtpMsgDate.Value.Date;
            inner.FileName= txtFileName.Text;
            inner.FileData = fileData;
            inner.FileExtension=lblFileExtension.Text;
            inner.Note=txtNotes.Text;
            inner.UserId = VariablesClass.userId;
            inner.insertInner();
            VariablesClass.saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;

            if (VariablesClass.saveState == 1)
            { 
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                notifyIcon1.ShowBalloonTip(1);
                picRefresh_Click(sender, e);
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


       

        private void btnSearchRefresh_Click(object sender, EventArgs e)
        {

        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            clearData();
            getContacts();
            getNewNum();
            getData();
        }

        private void picUpdate_Click(object sender, EventArgs e)
        {

            if (innerId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtNum.Text == "" | cmbYear.Text == "" | txtSubject.Text == "" | txtRecivedNum.Text == "")
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
            inner.InnerId = innerId;
            inner.Number = Convert.ToInt32(txtNum.Text);
            inner.year = Convert.ToInt32(cmbYear.Text);
            inner.RecivedNum = Convert.ToInt32(txtRecivedNum.Text);
            inner.Subject = txtSubject.Text;
            inner.ContactId = Convert.ToInt32(cmbContacts.SelectedValue);
            inner.SendDate = dtpMsgDate.Value.Date;
            inner.RegisterDate = dtpMsgDate.Value.Date;
            inner.FileName = txtFileName.Text;
            inner.FileData = fileData;
            inner.FileExtension = lblFileExtension.Text;
            inner.Note = txtNotes.Text;
            inner.UserId = VariablesClass.userId;
            inner.updateInner();
            VariablesClass.saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
                if (VariablesClass.saveState == 1)
                {
                    //-------------------------------------
                    deleteOldFileFromDisk();
                    //-------------------------------------
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipText = "تم الحفظ بنجاح";
                    notifyIcon1.ShowBalloonTip(1);

                    picRefresh_Click(sender, e);
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
        void deleteOldFileFromDisk()
        {
            try
            {
                string fullpath = Settings.Default.DiskArchivePath + @"\" + "البريد الوارد" + @"\" + oldYear + @"\" + "(" + oldNum.ToString() + ") " + oldfileName + oldfileExtension;
                File.Delete(fullpath);
            }
            catch (Exception)
            {

            }
        }

        private void picContact_Click(object sender, EventArgs e)
        {
            FrmContacts frmContacts = new FrmContacts();

            if (cmbContacts.SelectedValue == null)  // if (cmbContacts.SelectedValue == default)
                frmContacts.txtAddContact.Text = cmbContacts.Text;

            frmContacts.ShowDialog();
            getContacts();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (innerId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد تريد الحذف", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               inner.InnerId = innerId;
                inner.deleteInner();
                    if (ConClass.cmd.ExecuteNonQuery() > 0)
                    {
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipText = "تم الحذف بنجاح";
                        notifyIcon1.ShowBalloonTip(1);
                        picRefresh_Click(sender, e);
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

        private void radSearchNum_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearchNum.Checked == true)
            {
                txtSearchNum.Enabled = true;
                cmbSearchYear.Enabled = true;
                txtSearchRecivedNum.Enabled = false;
                txtSearchSubject.Enabled = false;
                txtSearchSubject.Text = "";
                txtSearchNum.Focus();
            }
            else if (radSearchSubject.Checked == true)
            {
                txtSearchNum.Enabled = false;
                cmbSearchYear.Enabled = false;
                txtSearchRecivedNum.Enabled = false;
                txtSearchNum.Text = "";
                cmbSearchYear.Text = "";
                txtSearchSubject.Enabled = true;
                txtSearchSubject.Text = "";
                txtSearchSubject.Focus();
            }
            else if (radSearchRecivedNum.Checked == true)
            {
                txtSearchNum.Enabled = false;
                cmbSearchYear.Enabled = false;
                txtSearchRecivedNum.Enabled = true;
                txtSearchRecivedNum.Text = "";
                txtSearchSubject.Enabled = false;
                txtSearchRecivedNum.Focus();
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
                for (int i = 0; i <= dtInner.Rows.Count - 1; i++)
                {
                    if (txtSearchNum.Text.Trim() == dtInner.Rows[i][1].ToString())
                    {
                        dgvInner.Rows[i].Selected = true;
                        dgvInner.FirstDisplayedScrollingRowIndex = i;
                        cr = i;
                        displayData();
                        return;
                    }
                }
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "البريد الوارد غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }
            else

                if (radSearchSubject.Checked == true)
            {
                if (txtSearchSubject.Text == "")
                {
                    MessageBox.Show("الرجاء إدخال موضوع الرسالة", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dtInner.Clear();
                ConClass.sqlQuery = "select TblInners.*,TblContacts.ContactName,UserName from TblInners,TblContacts,TblUsers  where TblContacts.Id=TblInners.ContactID and TblUsers.Id=TblInners.UserId and Subject like '%" + txtSearchSubject.Text.Trim() + "%' ORDER BY YEAR DESC,Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtInner);
                clearData();
                getNewNum();
                if (dtInner.Rows.Count > 0)
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


            else
            {
                if (txtSearchRecivedNum.Text.Trim() == "")
                {
                    MessageBox.Show("الرجاء إدخال اشاري المراسلة", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                getData();
                for (int i = 0; i <= dtInner.Rows.Count - 1; i++)
                {
                    if (txtSearchRecivedNum.Text.Trim() == dtInner.Rows[i][3].ToString())
                    {
                        dgvInner.Rows[i].Selected = true;
                        dgvInner.FirstDisplayedScrollingRowIndex = i;
                        cr = i;
                        displayData();
                        return;
                    }
                }
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "البريد الوارد غير موجود";
                notifyIcon1.ShowBalloonTip(1);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getNewNum()
        {
            try
            {
                dtNum.Clear();
                ConClass.sqlQuery = "DECLARE @Num int SELECT @Num=MAX(Num) + 1 FROM TblInners where [Year]=" + cmbYear.Text + " IF @Num IS NULL SET @Num=1 SELECT @Num";
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
                dtInner.Clear();

                ConClass.sqlQuery = "SELECT TblInners.*,TblContacts.ContactName,TblUsers.UserName from TblInners,TblContacts,TblUsers WHERE TblContacts.Id = TblInners.ContactId AND TblUsers.Id = TblInners.UserId AND[YEAR] = " + cmbYear.Text + " ORDER BY Num ASC";
                ConClass.da = new SqlDataAdapter(ConClass.sqlQuery, ConClass.con);
                ConClass.da.Fill(dtInner);
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
            dgvInner.Rows.Clear();
            for (int i = 0; i <= dtInner.Rows.Count - 1; i++)
            {
                dgvInner.Rows.Add();
                dgvInner.Rows[i].Cells[0].Value = dtInner.Rows[i][0];
                dgvInner.Rows[i].Cells[1].Value = i + 1;
                //dgvOutter.Rows[i].Cells[2].Value = string.Format(dtOutter.Rows[i][1].ToString(), "0000") + "/" + dtOutter.Rows[i][2];
                dgvInner.Rows[i].Cells[2].Value = dtInner.Rows[i][1].ToString() + "/" + dtInner.Rows[i][2];
                dgvInner.Rows[i].Cells[3].Value = dtInner.Rows[i][3];
                dgvInner.Rows[i].Cells[4].Value = dtInner.Rows[i][4];
                dgvInner.Rows[i].Cells[5].Value = dtInner.Rows[i][13];
                dgvInner.Rows[i].Cells[6].Value = dtInner.Rows[i][6];
                dgvInner.Rows[i].Cells[7].Value = dtInner.Rows[i][7];
                dgvInner.Rows[i].Cells[8].Value = dtInner.Rows[i][8].ToString();

                dgvInner.Rows[i].Cells[9].Value = dtInner.Rows[i][14];
            }
            dgvInner.ClearSelection();
        }
    }
}
