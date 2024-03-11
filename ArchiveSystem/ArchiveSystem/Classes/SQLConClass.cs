using ArchiveSystem.Properties;
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
    internal class SQLConClass
    {
        public static string sqlQuery;
        SqlConnection con;
        public SQLConClass()
        {
            con = new SqlConnection("Data Source=" + Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";Integrated Security=False;User ID=" + Settings.Default.SQLLogin + ";Password=" + Settings.Default.SQLPassword + ";");
        }
        public DataSet selectData(string command, int type, SqlParameter[] parameters)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(command, con);
            if (!(parameters == null))
                cmd.Parameters.AddRange(parameters);
            if (type == 1)
                cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }
        public DataSet cmdExecuteData(string command, SqlParameter[] parameters)
        {
            SqlDataAdapter da;
            var ds = new DataSet();
            var cmd = new SqlCommand(command, con);
            VariablesClass.Save = -1;

            if (!(parameters == null))
            {
                foreach (SqlParameter p in parameters)
                    if (p.Value == null) p.Value = DBNull.Value;

                cmd.Parameters.AddRange(parameters);
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@saveState", SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                VariablesClass.Save = Convert.ToInt32(cmd.Parameters["@saveState"].Value.ToString());
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("فشل في الإتصال بقاعدة البيانات" + Environment.NewLine + ex.Message, "خطأ إتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return ds;

        }

    }
}