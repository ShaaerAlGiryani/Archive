namespace ArchiveSystem.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSetings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnOutter = new System.Windows.Forms.Button();
            this.btnInner = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLblDateTime,
            this.tssLblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(937, 27);
            this.statusStrip1.TabIndex = 51;
            this.statusStrip1.Text = "StatusStrip1";
            // 
            // tssLblDateTime
            // 
            this.tssLblDateTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblDateTime.ForeColor = System.Drawing.Color.Black;
            this.tssLblDateTime.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.tssLblDateTime.Name = "tssLblDateTime";
            this.tssLblDateTime.Size = new System.Drawing.Size(133, 22);
            this.tssLblDateTime.Text = "TssLblDateTime";
            // 
            // tssLblUser
            // 
            this.tssLblUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssLblUser.ForeColor = System.Drawing.Color.Black;
            this.tssLblUser.Margin = new System.Windows.Forms.Padding(700, 4, 0, 2);
            this.tssLblUser.Name = "tssLblUser";
            this.tssLblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tssLblUser.Size = new System.Drawing.Size(97, 21);
            this.tssLblUser.Text = "TssLblUser";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(336, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 52;
            this.label1.Text = "ارشفة البريد الصادر والوارد";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "document (3).png");
            this.imageList1.Images.SetKeyName(1, "file (1).png");
            this.imageList1.Images.SetKeyName(2, "document (2).png");
            this.imageList1.Images.SetKeyName(3, "file.png");
            this.imageList1.Images.SetKeyName(4, "document (1).png");
            this.imageList1.Images.SetKeyName(5, "document.png");
            this.imageList1.Images.SetKeyName(6, "files-and-folders.png");
            this.imageList1.Images.SetKeyName(7, "file-storage.png");
            this.imageList1.Images.SetKeyName(8, "mail (1).png");
            this.imageList1.Images.SetKeyName(9, "mail.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "تم اخذ النسخة الاحتياطية بنجاح";
            this.notifyIcon1.BalloonTipTitle = "النسخ الاحتياطي";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NotifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-74, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 1);
            this.panel1.TabIndex = 60;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePass.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePass.Location = new System.Drawing.Point(203, 293);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(151, 158);
            this.btnChangePass.TabIndex = 58;
            this.btnChangePass.Text = "تغيير كلمة المرور";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReports.Location = new System.Drawing.Point(203, 122);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(151, 158);
            this.btnReports.TabIndex = 57;
            this.btnReports.Text = "التقارير";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnSetings
            // 
            this.btnSetings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetings.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetings.ForeColor = System.Drawing.Color.Black;
            this.btnSetings.Image = ((System.Drawing.Image)(resources.GetObject("btnSetings.Image")));
            this.btnSetings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetings.Location = new System.Drawing.Point(387, 293);
            this.btnSetings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetings.Name = "btnSetings";
            this.btnSetings.Size = new System.Drawing.Size(151, 158);
            this.btnSetings.TabIndex = 56;
            this.btnSetings.Text = "إعدادت النظام";
            this.btnSetings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetings.UseVisualStyleBackColor = true;
            this.btnSetings.Click += new System.EventHandler(this.btnSetings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(574, 293);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(151, 158);
            this.btnUsers.TabIndex = 55;
            this.btnUsers.Text = "إدارة بيانات المستخدمين";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOutter
            // 
            this.btnOutter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOutter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutter.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutter.ForeColor = System.Drawing.Color.Black;
            this.btnOutter.Image = ((System.Drawing.Image)(resources.GetObject("btnOutter.Image")));
            this.btnOutter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutter.Location = new System.Drawing.Point(387, 122);
            this.btnOutter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOutter.Name = "btnOutter";
            this.btnOutter.Size = new System.Drawing.Size(151, 158);
            this.btnOutter.TabIndex = 54;
            this.btnOutter.Text = "ارشفة البريد الصادر";
            this.btnOutter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOutter.UseVisualStyleBackColor = true;
            this.btnOutter.Click += new System.EventHandler(this.btnOutter_Click);
            // 
            // btnInner
            // 
            this.btnInner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInner.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInner.ForeColor = System.Drawing.Color.Black;
            this.btnInner.Image = ((System.Drawing.Image)(resources.GetObject("btnInner.Image")));
            this.btnInner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInner.Location = new System.Drawing.Point(574, 122);
            this.btnInner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInner.Name = "btnInner";
            this.btnInner.Size = new System.Drawing.Size(151, 158);
            this.btnInner.TabIndex = 53;
            this.btnInner.Text = "ارشفة البريد الوارد";
            this.btnInner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInner.UseVisualStyleBackColor = true;
            this.btnInner.Click += new System.EventHandler(this.btnInner_Click);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(12, 6);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(106, 68);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 59;
            this.picUser.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 488);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnSetings);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnOutter);
            this.Controls.Add(this.btnInner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picUser);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel tssLblDateTime;
        internal System.Windows.Forms.ToolStripStatusLabel tssLblUser;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.Button btnChangePass;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.Button btnSetings;
        internal System.Windows.Forms.Button btnUsers;
        internal System.Windows.Forms.Button btnOutter;
        internal System.Windows.Forms.Button btnInner;
        internal System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox picUser;
    }
}