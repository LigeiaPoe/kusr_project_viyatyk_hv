using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_1
{
    public partial class start_page : Form
    {
        public start_page()
        {
            InitializeComponent();
            
        }
        
        //public static string login = txt_login.Text;
        //public static String database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Skype", "ligeia24", "main.db");
        //public static string debug = Path.Combine(Application.StartupPath, "main.db");

        private void btn_copy_Click(object sender, EventArgs e)
        {
            string login = txt_login.Text;
            String database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Skype", login, "main.db");
            string debug = Path.Combine(Application.StartupPath, "main.db");

            search Search = new search();
            if (File.Exists(debug))
            {
                File.Copy(database, debug, true);
                Search.ShowDialog();
               // start_page.ActiveForm.Close();
                Search.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                Search.ShowDialog();
             //   start_page.ActiveForm.Close();
                Search.StartPosition = FormStartPosition.CenterScreen;
            }   
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            help Help = new help();
            Help.ShowDialog();
          //  start_page.ActiveForm.Close();
            Help.StartPosition = FormStartPosition.CenterScreen;
        }

        private void start_page_Load(object sender, EventArgs e)
        {
        start_page St_Page = new start_page();
        St_Page.StartPosition = FormStartPosition.CenterScreen;
        }


        private void futureButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
