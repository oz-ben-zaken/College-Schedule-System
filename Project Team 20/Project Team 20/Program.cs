using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Team_20
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (SQL_DataBase.SQLConnection.InitConnection() == false)
                MessageBox.Show("Failed to connect to database.");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new LoginForm());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            SQL_DataBase.SQLConnection.GetSqlConnection().Close();
        }
    }
}
