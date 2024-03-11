using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem.Classes
{
    class UserClass
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userJob { get; set; }
        public bool updateP { get; set; }
        public bool insertP { get; set; }
        public bool userP { get; set; }
        public bool printP { get; set; }
        public bool settingsP { get; set; }
        // public byte picUser { get; set; }
        DataSet ds = new DataSet();
        DataSet dsChangePass = new DataSet();
        //insert user
       
        public void insertUser(UserClass user)
        {
                var sqlCon = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] {

                    new SqlParameter("@UserName", userName),
                    new SqlParameter("@UserPass",userPassword),
                    new SqlParameter("@UserJob",userJob ),
                    new SqlParameter("@UPDATEP",updateP),
                    new SqlParameter("@INSERTP",insertP),
                    new SqlParameter("@PRINTP",printP),
                    new SqlParameter("@USERSP", userP),
                    new SqlParameter("@SettingsP", settingsP) };
                // new SqlParameter("@UserPic", Properties.Resources.user )   };
                ds = sqlCon.cmdExecuteData("InsertUser", param);
                if (VariablesClass.Save == 0)
                {
                    MessageBox.Show(" لم يتم حفظ المستخدم" + Environment.NewLine + MessageBoxButtons.OK + MessageBoxIcon.Error);

                }
                else if (VariablesClass.Save == 1)
                {
                    MessageBox.Show("تم حفظ المستخدم بنجاح" + Environment.NewLine + MessageBoxButtons.OK + MessageBoxIcon.Error);

                }
        }
        //Update user data
        public void updatetUser(UserClass user)
        {
            var sqlCon = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("Id",userId),
                new SqlParameter("@UserName", userName),
                new SqlParameter("@UserPass",userPassword),
                new SqlParameter("@UserJob",userJob ),
                new SqlParameter("@UPDATEP",updateP),
                new SqlParameter("@INSERTP",insertP),
                new SqlParameter("@PRINTP",printP),
                new SqlParameter("@USERSP", userP),
                new SqlParameter("@SettingsP", settingsP) };
            // new SqlParameter("@UserPic", Properties.Resources.user )   };
            ds = sqlCon.cmdExecuteData("UpdateUser", param);
            if (VariablesClass.Save == 0)
            {
                MessageBox.Show(" لم يتم حفظ التعديل" + Environment.NewLine + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
            else if (VariablesClass.Save == 1)
            {
                MessageBox.Show("تم تعديل بيانات المستخدم بنجاح" + Environment.NewLine + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
        }
        //Delete user
        public void deleteUser(UserClass user)
        {
            var sqlCon = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("Id",userId) };
            ds = sqlCon.cmdExecuteData("DeleteUser", param);
            if (VariablesClass.Save == 1)
            {
                MessageBox.Show(" تم حذف المستخدم بنجاح" + Environment.NewLine + MessageBoxButtons.OK + MessageBoxIcon.Error);

            }
            else if (VariablesClass.Save == 2)
            {
                MessageBox.Show( "لا يمكن حذف المستخدم" + Environment.NewLine + "يوجد عمليات أرشفة قام بها");                
            }
            else if (VariablesClass.Save == 0)
            {
                MessageBox.Show(" لم يتم الحفظ، خطأ في تنفيذ العملية", "خطأ في الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //change password for user
        public void changePass(UserClass user)
        {
            SQLConClass sqlcon = new SQLConClass();
            ConClass.sqlQuery = "UPDATE TblUsers SET UserPassword='" + user.userPassword + "' WHERE Id=" + VariablesClass.userId;
            dsChangePass = sqlcon.selectData(ConClass.sqlQuery, 0, default);

            MessageBox.Show("تم تغير كلمة المرور بنجاح", "تغير كلمة المرور", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VariablesClass.userPassword = user.userPassword;
        }
    }
}
