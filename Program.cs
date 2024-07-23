using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KCorrespondence
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Authorization());
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Просим извенения, но в данный момент сервер не работает! Вы можете зайти позже!");
            }
            
        }
    }
}
