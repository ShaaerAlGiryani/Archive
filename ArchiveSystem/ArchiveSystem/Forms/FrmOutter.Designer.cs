namespace ArchiveSystem.Forms
{
    partial class FrmOutter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutter));
            this.tssLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvOutter = new System.Windows.Forms.DataGridView();
            this.column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSearchRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.btnFileCancel = new System.Windows.Forms.Button();
            this.btnFileShow = new System.Windows.Forms.Button();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSearchYear = new System.Windows.Forms.ComboBox();
            this.txtSearchNum = new System.Windows.Forms.TextBox();
            this.radSearchSubject = new System.Windows.Forms.RadioButton();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.radSearchNum = new System.Windows.Forms.RadioButton();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbContacts = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMsgDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picFileIcon = new System.Windows.Forms.PictureBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // tssLblDateTime
            // 
            this.tssLblDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblDateTime.ForeColor = System.Drawing.Color.Black;
            this.tssLblDateTime.Name = "tssLblDateTime";
            this.tssLblDateTime.Size = new System.Drawing.Size(133, 21);
            this.tssLblDateTime.Text = "TssLblDateTime";
            // 
            // dgvOutter
            // 
            this.dgvOutter.AllowDrop = true;
            this.dgvOutter.AllowUserToAddRows = false;
            this.dgvOutter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutter.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOutter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOutter.ColumnHeadersHeight = 33;
            this.dgvOutter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column7,
            this.dataGridViewTextBoxColumn1,
            this.column1,
            this.Subject,
            this.ContactName,
            this.SendDate,
            this.RegDate,
            this.column11,
            this.column6,
            this.UserName});
            this.dgvOutter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOutter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOutter.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOutter.EnableHeadersVisualStyles = false;
            this.dgvOutter.GridColor = System.Drawing.Color.Black;
            this.dgvOutter.Location = new System.Drawing.Point(0, 343);
            this.dgvOutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOutter.MultiSelect = false;
            this.dgvOutter.Name = "dgvOutter";
            this.dgvOutter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOutter.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOutter.RowHeadersVisible = false;
            this.dgvOutter.RowHeadersWidth = 51;
            this.dgvOutter.RowTemplate.DividerHeight = 2;
            this.dgvOutter.RowTemplate.Height = 30;
            this.dgvOutter.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutter.Size = new System.Drawing.Size(1073, 212);
            this.dgvOutter.TabIndex = 968;
            // 
            // column7
            // 
            this.column7.HeaderText = "ID";
            this.column7.MinimumWidth = 6;
            this.column7.Name = "column7";
            this.column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column7.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 35.53299F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ت";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column1
            // 
            this.column1.HeaderText = "الرقم الإشاري";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "الموضوع";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            // 
            // ContactName
            // 
            this.ContactName.HeaderText = "المرسل له";
            this.ContactName.MinimumWidth = 6;
            this.ContactName.Name = "ContactName";
            // 
            // SendDate
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.SendDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.SendDate.HeaderText = "تاريخ الرسالة";
            this.SendDate.MinimumWidth = 6;
            this.SendDate.Name = "SendDate";
            // 
            // RegDate
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.RegDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.RegDate.HeaderText = "تاريخ التسجيل";
            this.RegDate.MinimumWidth = 6;
            this.RegDate.Name = "RegDate";
            // 
            // column11
            // 
            this.column11.HeaderText = "إسم الملف";
            this.column11.MinimumWidth = 6;
            this.column11.Name = "column11";
            this.column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column6
            // 
            this.column6.HeaderText = "نوع الملف";
            this.column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.column6.MinimumWidth = 6;
            this.column6.Name = "column6";
            this.column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "إشعار";
            this.notifyIcon1.Visible = true;
            // 
            // btnSearchRefresh
            // 
            this.btnSearchRefresh.BackColor = System.Drawing.Color.White;
            this.btnSearchRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRefresh.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnSearchRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnSearchRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRefresh.Location = new System.Drawing.Point(22, 42);
            this.btnSearchRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchRefresh.Name = "btnSearchRefresh";
            this.btnSearchRefresh.Size = new System.Drawing.Size(68, 30);
            this.btnSearchRefresh.TabIndex = 971;
            this.btnSearchRefresh.Text = "تحديث";
            this.btnSearchRefresh.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFileExtension);
            this.groupBox1.Controls.Add(this.picFileIcon);
            this.groupBox1.Controls.Add(this.btnFileCancel);
            this.groupBox1.Controls.Add(this.btnFileShow);
            this.groupBox1.Controls.Add(this.btnFileSave);
            this.groupBox1.Controls.Add(this.btnFileBrowse);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(358, 154);
            this.groupBox1.TabIndex = 969;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إضافة الملف";
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(290, 70);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(47, 22);
            this.lblFileExtension.TabIndex = 939;
            this.lblFileExtension.Text = "label10";
            // 
            // btnFileCancel
            // 
            this.btnFileCancel.BackColor = System.Drawing.Color.White;
            this.btnFileCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileCancel.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnFileCancel.ForeColor = System.Drawing.Color.Black;
            this.btnFileCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileCancel.Location = new System.Drawing.Point(21, 106);
            this.btnFileCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileCancel.Name = "btnFileCancel";
            this.btnFileCancel.Size = new System.Drawing.Size(91, 33);
            this.btnFileCancel.TabIndex = 937;
            this.btnFileCancel.Text = "إلغاء";
            this.btnFileCancel.UseVisualStyleBackColor = false;
            // 
            // btnFileShow
            // 
            this.btnFileShow.BackColor = System.Drawing.Color.White;
            this.btnFileShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileShow.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnFileShow.ForeColor = System.Drawing.Color.Black;
            this.btnFileShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileShow.Location = new System.Drawing.Point(132, 106);
            this.btnFileShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileShow.Name = "btnFileShow";
            this.btnFileShow.Size = new System.Drawing.Size(91, 33);
            this.btnFileShow.TabIndex = 936;
            this.btnFileShow.Text = "عرض الملف";
            this.btnFileShow.UseVisualStyleBackColor = false;
            // 
            // btnFileSave
            // 
            this.btnFileSave.BackColor = System.Drawing.Color.White;
            this.btnFileSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileSave.Enabled = false;
            this.btnFileSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSave.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnFileSave.ForeColor = System.Drawing.Color.Black;
            this.btnFileSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileSave.Location = new System.Drawing.Point(242, 106);
            this.btnFileSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(91, 33);
            this.btnFileSave.TabIndex = 935;
            this.btnFileSave.Text = "حفظ الملف";
            this.btnFileSave.UseVisualStyleBackColor = false;
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.BackColor = System.Drawing.Color.White;
            this.btnFileBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileBrowse.FlatAppearance.BorderSize = 0;
            this.btnFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileBrowse.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnFileBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileBrowse.Location = new System.Drawing.Point(6, 33);
            this.btnFileBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(35, 29);
            this.btnFileBrowse.TabIndex = 934;
            this.btnFileBrowse.Text = "...";
            this.btnFileBrowse.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(252, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 933;
            this.label9.Text = "إسم الملف";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtFileName.Location = new System.Drawing.Point(40, 33);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(204, 29);
            this.txtFileName.TabIndex = 932;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 555);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1073, 26);
            this.statusStrip1.TabIndex = 964;
            this.statusStrip1.Text = "StatusStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(22, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 30);
            this.btnSearch.TabIndex = 967;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbSearchYear);
            this.groupBox3.Controls.Add(this.txtSearchNum);
            this.groupBox3.Controls.Add(this.radSearchSubject);
            this.groupBox3.Controls.Add(this.txtSearchSubject);
            this.groupBox3.Controls.Add(this.radSearchNum);
            this.groupBox3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(108, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(953, 64);
            this.groupBox3.TabIndex = 966;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بحث";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(690, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 35);
            this.label8.TabIndex = 944;
            this.label8.Text = "/";
            // 
            // cmbSearchYear
            // 
            this.cmbSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchYear.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cmbSearchYear.FormattingEnabled = true;
            this.cmbSearchYear.Location = new System.Drawing.Point(569, 23);
            this.cmbSearchYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSearchYear.MaxLength = 4;
            this.cmbSearchYear.Name = "cmbSearchYear";
            this.cmbSearchYear.Size = new System.Drawing.Size(119, 29);
            this.cmbSearchYear.TabIndex = 943;
            // 
            // txtSearchNum
            // 
            this.txtSearchNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNum.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSearchNum.Location = new System.Drawing.Point(716, 22);
            this.txtSearchNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchNum.Name = "txtSearchNum";
            this.txtSearchNum.Size = new System.Drawing.Size(119, 29);
            this.txtSearchNum.TabIndex = 941;
            // 
            // radSearchSubject
            // 
            this.radSearchSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radSearchSubject.AutoSize = true;
            this.radSearchSubject.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.radSearchSubject.Location = new System.Drawing.Point(394, 23);
            this.radSearchSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radSearchSubject.Name = "radSearchSubject";
            this.radSearchSubject.Size = new System.Drawing.Size(73, 29);
            this.radSearchSubject.TabIndex = 938;
            this.radSearchSubject.TabStop = true;
            this.radSearchSubject.Text = "الموضوع";
            this.radSearchSubject.UseVisualStyleBackColor = true;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSubject.Enabled = false;
            this.txtSearchSubject.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSearchSubject.Location = new System.Drawing.Point(15, 22);
            this.txtSearchSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(370, 29);
            this.txtSearchSubject.TabIndex = 939;
            // 
            // radSearchNum
            // 
            this.radSearchNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radSearchNum.AutoSize = true;
            this.radSearchNum.Checked = true;
            this.radSearchNum.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F);
            this.radSearchNum.ForeColor = System.Drawing.Color.Black;
            this.radSearchNum.Location = new System.Drawing.Point(836, 22);
            this.radSearchNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radSearchNum.Name = "radSearchNum";
            this.radSearchNum.Size = new System.Drawing.Size(103, 29);
            this.radSearchNum.TabIndex = 937;
            this.radSearchNum.TabStop = true;
            this.radSearchNum.Text = "الرقم الإشاري";
            this.radSearchNum.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.cmbYear);
            this.grpInfo.Controls.Add(this.cmbContacts);
            this.grpInfo.Controls.Add(this.txtNotes);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.dtpRegDate);
            this.grpInfo.Controls.Add(this.dtpMsgDate);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.picContact);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.txtSubject);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtNum);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.ForeColor = System.Drawing.Color.Black;
            this.grpInfo.Location = new System.Drawing.Point(368, 70);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpInfo.Size = new System.Drawing.Size(693, 253);
            this.grpInfo.TabIndex = 965;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "بيانات البريد الصادر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(389, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 35);
            this.label6.TabIndex = 962;
            this.label6.Text = "/";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(146, 25);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbYear.MaxLength = 4;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(241, 29);
            this.cmbYear.TabIndex = 961;
            // 
            // cmbContacts
            // 
            this.cmbContacts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbContacts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbContacts.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cmbContacts.FormattingEnabled = true;
            this.cmbContacts.Location = new System.Drawing.Point(58, 103);
            this.cmbContacts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbContacts.MaxLength = 100;
            this.cmbContacts.Name = "cmbContacts";
            this.cmbContacts.Size = new System.Drawing.Size(541, 29);
            this.cmbContacts.TabIndex = 960;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtNotes.Location = new System.Drawing.Point(14, 181);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(585, 60);
            this.txtNotes.TabIndex = 959;
            this.txtNotes.WordWrap = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(630, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 958;
            this.label7.Text = "ملاحظات";
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.CustomFormat = "yyyy-MM-dd";
            this.dtpRegDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpRegDate.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegDate.Location = new System.Drawing.Point(146, 142);
            this.dtpRegDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpRegDate.RightToLeftLayout = true;
            this.dtpRegDate.Size = new System.Drawing.Size(198, 29);
            this.dtpRegDate.TabIndex = 956;
            // 
            // dtpMsgDate
            // 
            this.dtpMsgDate.CustomFormat = "yyyy-MM-dd";
            this.dtpMsgDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpMsgDate.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.dtpMsgDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMsgDate.Location = new System.Drawing.Point(451, 142);
            this.dtpMsgDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpMsgDate.Name = "dtpMsgDate";
            this.dtpMsgDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpMsgDate.RightToLeftLayout = true;
            this.dtpMsgDate.Size = new System.Drawing.Size(148, 29);
            this.dtpMsgDate.TabIndex = 955;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(347, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 954;
            this.label5.Text = "تاريخ التسجيل";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(610, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 952;
            this.label4.Text = "تاريخ الرسالة";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(628, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 951;
            this.label3.Text = "صادر اليه";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSubject.Location = new System.Drawing.Point(14, 64);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(585, 29);
            this.txtSubject.TabIndex = 950;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(635, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 949;
            this.label2.Text = "الموضوع";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtNum.Location = new System.Drawing.Point(414, 25);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(185, 29);
            this.txtNum.TabIndex = 948;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(607, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 947;
            this.label1.Text = "الرقم الإشاري";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.picRefresh);
            this.panel1.Controls.Add(this.picDelete);
            this.panel1.Controls.Add(this.picAdd);
            this.panel1.Controls.Add(this.picUpdate);
            this.panel1.Location = new System.Drawing.Point(5, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 80);
            this.panel1.TabIndex = 970;
            // 
            // picFileIcon
            // 
            this.picFileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFileIcon.Location = new System.Drawing.Point(313, 29);
            this.picFileIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picFileIcon.Name = "picFileIcon";
            this.picFileIcon.Size = new System.Drawing.Size(34, 35);
            this.picFileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFileIcon.TabIndex = 938;
            this.picFileIcon.TabStop = false;
            // 
            // picContact
            // 
            this.picContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picContact.Image = ((System.Drawing.Image)(resources.GetObject("picContact.Image")));
            this.picContact.Location = new System.Drawing.Point(14, 103);
            this.picContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(36, 29);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picContact.TabIndex = 953;
            this.picContact.TabStop = false;
            this.toolTip1.SetToolTip(this.picContact, "الجهات");
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(21, 12);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(63, 60);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 950;
            this.picRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.picRefresh, "تحديث");
            // 
            // picDelete
            // 
            this.picDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(104, 12);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(63, 60);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDelete.TabIndex = 951;
            this.picDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picDelete, "حذف");
            // 
            // picAdd
            // 
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(270, 12);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(63, 60);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 952;
            this.picAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.picAdd, "اضافة");
            // 
            // picUpdate
            // 
            this.picUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUpdate.Image = ((System.Drawing.Image)(resources.GetObject("picUpdate.Image")));
            this.picUpdate.Location = new System.Drawing.Point(187, 12);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(63, 60);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUpdate.TabIndex = 949;
            this.picUpdate.TabStop = false;
            this.toolTip1.SetToolTip(this.picUpdate, "تعديل");
            // 
            // Outter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 581);
            this.Controls.Add(this.dgvOutter);
            this.Controls.Add(this.btnSearchRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Outter";
            this.Text = "Outter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripStatusLabel tssLblDateTime;
        internal System.Windows.Forms.PictureBox picRefresh;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.DataGridView dgvOutter;
        private System.Windows.Forms.DataGridViewTextBoxColumn column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn column11;
        private System.Windows.Forms.DataGridViewImageColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        internal System.Windows.Forms.PictureBox picDelete;
        internal System.Windows.Forms.PictureBox picAdd;
        internal System.Windows.Forms.PictureBox picContact;
        internal System.Windows.Forms.PictureBox picUpdate;
        internal System.Windows.Forms.OpenFileDialog ofd;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.SaveFileDialog sfd;
        internal System.Windows.Forms.Button btnSearchRefresh;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFileExtension;
        internal System.Windows.Forms.PictureBox picFileIcon;
        internal System.Windows.Forms.Button btnFileCancel;
        internal System.Windows.Forms.Button btnFileShow;
        internal System.Windows.Forms.Button btnFileSave;
        internal System.Windows.Forms.Button btnFileBrowse;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cmbSearchYear;
        internal System.Windows.Forms.TextBox txtSearchNum;
        internal System.Windows.Forms.RadioButton radSearchSubject;
        internal System.Windows.Forms.TextBox txtSearchSubject;
        internal System.Windows.Forms.RadioButton radSearchNum;
        internal System.Windows.Forms.GroupBox grpInfo;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cmbYear;
        internal System.Windows.Forms.ComboBox cmbContacts;
        internal System.Windows.Forms.TextBox txtNotes;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DateTimePicker dtpRegDate;
        internal System.Windows.Forms.DateTimePicker dtpMsgDate;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtNum;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panel1;
    }
}