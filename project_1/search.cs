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
using System.Data.SQLite;


namespace project_1
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();

        }
        public static string dbpath = Path.Combine(Application.StartupPath, "main.db");


        public void search_Load(object sender, EventArgs e)
        {
           /* using (var con = new SQLiteConnection(@"Data Source=" + dbpath + ";New=False;Version=3"))
            {
                var cmd = new SQLiteCommand();
            }*/

            SQLiteConnection connect = new SQLiteConnection(@"Data Source=" + dbpath + ";New=False;Version=3");
            connect.Open();
            SQLiteDataAdapter query1 = new SQLiteDataAdapter("Select fullname, skypename From Contacts Group By fullname, skypename", connect);

            DataSet ds1 = new DataSet();
            query1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];

            SQLiteDataAdapter query2 = new SQLiteDataAdapter("Select friendlyname, posters, dialog_partner From Chats Group By friendlyname, dialog_partner", connect);

            DataSet ds2 = new DataSet();
            query2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];


            //вивід списку користувачів на лістбокс
            string connetionString = null;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            connetionString = "Data Source=" + dbpath + ";New=False;Version=3";
            sql = "Select id, fullname From Contacts Group By fullname";
            conn = new SQLiteConnection(connetionString);
            try
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                conn.Close();
                list_user.DataSource = ds.Tables[0];
                list_user.ValueMember = "id";
                list_user.DisplayMember = "fullname";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }

        }

        public void btn_filter_text_Click(object sender, EventArgs e)
        {
           
        }


        public SQLiteConnection conn { get; set; }

        private void futureButton1_Click(object sender, EventArgs e)
        {
            search.ActiveForm.Close();
        }
    }
}
