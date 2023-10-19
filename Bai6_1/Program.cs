using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Bai6_1
{
    class KetNoi
    {
        String sqlConnect;
        public KetNoi()
        { sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString(); }
        public SqlConnection getConnect()
        { SqlConnection conn = new SqlConnection(sqlConnect); 
          return conn;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
