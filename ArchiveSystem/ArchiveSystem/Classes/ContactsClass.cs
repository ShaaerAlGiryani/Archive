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
    class ContactsClass
    {
        public int  ContactId { set; get; }
        public string ContactName { set; get; }

        public void insertContacts()
        {
            VariablesClass.saveState = 0;
            try
            {
                // -------------------شحن الاوامر-----------------
                ConClass.cmd = new SqlCommand("InsertContact", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                // -----------------------اضافة الباراميترات-------------
                SqlParameter param;
                param = new SqlParameter("@ContactName", ContactName.Trim());
                ConClass.cmd.Parameters.Add(param);
                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                // ------------------------التنفيذ-------------
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteContacts()
        {
            VariablesClass.saveState = 0;
            try
            {
                // -----------------شحن الأوامر------------------
                ConClass.cmd = new SqlCommand("DeleteContact", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                // -----------------اضافة البارامترات-----------------
                SqlParameter param;
                param = new SqlParameter("@Id", ContactId);
                ConClass.cmd.Parameters.Add(param);
                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;
                // -----------------التنفيذ----------------
                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();
            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateContact()
        {
            VariablesClass.saveState = 0;

            try
            {
                ConClass.cmd = new SqlCommand("UpdateContact", ConClass.con);
                ConClass.cmd.CommandType = CommandType.StoredProcedure;

                var param = new SqlParameter[2];
                param[0] = new SqlParameter("@ID", ContactId);
                param[1] = new SqlParameter("@ContactName", ContactName.Trim());
                ConClass.cmd.Parameters.AddRange(param);
                ConClass.cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();

            }
            catch (Exception ex)
            {
                ConClass.con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
