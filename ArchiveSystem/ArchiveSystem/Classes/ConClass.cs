using ArchiveSystem.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ArchiveSystem.Classes
{
    internal class ConClass
    {
        public static string sqlQuery;
        public static SqlConnection con = new SqlConnection("Data Source=" + Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";Integrated Security=False;User Id=" + Settings.Default.SQLLogin + ";Password=" + Settings.Default.SQLPassword + ";");
    }
}
