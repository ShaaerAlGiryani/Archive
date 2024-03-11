using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveSystem.Classes
{
    class MailClass
    {
        public int Number { set; get; }
        public int year { set; get; }
        public string Subject { set; get; }
        public int ContactId { set; get; }
        public DateTime SendDate { set; get; }
        public DateTime RegisterDate { set; get; }
        public string FileName { set; get; }
        public string FileExtension { set; get; }
        public byte[] FileData { set; get; }
        public string Note { set; get; }
        public int UserId { set; get; }


    }
    class Outter : MailClass
    {
        public int OutterId { set; get; }
        public void SaveOutter()
        {
            try
            {
                ConClass.cmd = new SqlCommand("InsertOutterMail", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                var param = new SqlParameter[10];
                param[0] = new SqlParameter("@Year", Convert.ToInt32(year));
                param[1] = new SqlParameter("@Subject", Subject.Trim());
                param[2] = new SqlParameter("@ContactID", ContactId);
                param[3] = new SqlParameter("@SendDate", SendDate);
                param[4] = new SqlParameter("@RegDate", RegisterDate);
                param[5] = new SqlParameter("@fileName", FileName.Trim());
                param[6] = new SqlParameter("@fileData", FileData);
                param[7] = new SqlParameter("@fileExtension", FileExtension);
                param[8] = new SqlParameter("@Note", Note.Trim());
                param[9] = new SqlParameter("@UserID", VariablesClass.userId);

                ConClass.cmd.Parameters.AddRange(param);

                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                ConClass.cmd.Parameters.Add("@Num", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

                VariablesClass.saveState = (int)ConClass.cmd.Parameters["@saveState"].Value;
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateOutter()
        {
            try
            {
                ConClass.cmd = new SqlCommand("UpdateOutterMail", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                var param = new SqlParameter[12];
                param[0] = new SqlParameter("@Id", OutterId);
                param[1] = new SqlParameter("@Num", Number);
                param[2] = new SqlParameter("@Year", year);
                param[3] = new SqlParameter("@Subject", Subject.Trim());
                param[4] = new SqlParameter("@ContactID", ContactId);
                param[5] = new SqlParameter("@SendDate", SendDate);
                param[6] = new SqlParameter("@RegDate", RegisterDate);
                param[7] = new SqlParameter("@fileName", FileName.Trim());
                param[8] = new SqlParameter("@fileData", FileData);
                param[9] = new SqlParameter("@fileExtension", FileExtension);
                param[10] = new SqlParameter("@Note", Note.Trim());
                param[11] = new SqlParameter("@UserID", VariablesClass.userId);

                ConClass.cmd.Parameters.AddRange(param);

                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteOutter()
        {
            try
            {
                ConClass.sqlQuery = "DELETE FROM TblOutters  WHERE Id =" + OutterId;
                ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);

                ConClass.con.Open();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Inner : MailClass
    {
        public int InnerId { set; get; }
        public int RecivedNum { set; get; } //اشاري المراسلة
        public void insertInner()
        {
            VariablesClass.saveState = 0;
            try
            {
                ConClass.cmd = new SqlCommand("InsertInnerMail", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                var param = new SqlParameter[11];
                param[0] = new SqlParameter("@Year", year);
                param[1] = new SqlParameter("@RecivedNum", RecivedNum);
                param[2] = new SqlParameter("@Subject", Subject.Trim());
                param[3] = new SqlParameter("@ContactID", ContactId);
                param[4] = new SqlParameter("@SendDate", SendDate);
                param[5] = new SqlParameter("@RegDate", RegisterDate);
                param[6] = new SqlParameter("@fileName", FileName.Trim());
                param[7] = new SqlParameter("@fileData", FileData);
                param[8] = new SqlParameter("@fileExtension", FileExtension);
                param[9] = new SqlParameter("@Note", Note.Trim());
                param[10] = new SqlParameter("@UserID", UserId);

                ConClass.cmd.Parameters.AddRange(param);

                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                ConClass.cmd.Parameters.Add("@Num", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void updateInner()
        {
            VariablesClass.saveState = 0;
            try
            {
                ConClass.cmd = new SqlCommand("UpdateInnerMail", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                var param = new SqlParameter[13];
                param[0] = new SqlParameter("@Id", InnerId);
                param[1] = new SqlParameter("@Num", Number);
                param[2] = new SqlParameter("@Year", year);
                param[3] = new SqlParameter("@RecivedNum", RecivedNum);
                param[4] = new SqlParameter("@Subject", Subject.Trim());
                param[5] = new SqlParameter("@ContactID", ContactId);
                param[6] = new SqlParameter("@SendDate", SendDate);
                param[7] = new SqlParameter("@RegDate", RegisterDate);
                param[8] = new SqlParameter("@fileName", FileName.Trim());
                param[9] = new SqlParameter("@fileData", FileData);
                param[10] = new SqlParameter("@fileExtension", FileExtension);
                param[11] = new SqlParameter("@Note", Note.Trim());
                param[12] = new SqlParameter("@UserID", UserId);

                ConClass.cmd.Parameters.AddRange(param);

                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteInner()
        {
            VariablesClass.saveState = 0;
            try
            {
                ConClass.sqlQuery = "DELETE FROM TblInners  WHERE Id =" + InnerId;
                ConClass.cmd = new SqlCommand(ConClass.sqlQuery, ConClass.con);

                ConClass.con.Open();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
