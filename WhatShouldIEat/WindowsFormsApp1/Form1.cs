using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;

        //sqlite_conn = new SQLiteConnection("Data Source = FoodPocket.db");
        //sqlite_conn.Open();

        public Form1()
        {
            InitializeComponent();

            TopLabel.Text = "又想不到要吃什麼了嗎?";
            TopLabel.BackColor = System.Drawing.Color.Transparent;

            Start.Text = "幫我想一家吧";
            Check.Text = "我的口袋名單";
            Add.Text = "新增口袋名單";
            pictureBox1.Image = Image.FromFile(@"Assets\back.jpg");
            //sqlite_conn = new SQLiteConnection("Data Source = FoodPocket.db");
            //sqlite_conn.Open();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            sqlite_conn = new SQLiteConnection("Data source=FoodPocket.db");
            //open
            sqlite_conn.Open();
            //下任何命令前, 先取得該連結的執行命令物件
            sqlite_cmd = sqlite_conn.CreateCommand();
            //sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "SELECT * FROM FoodPocket ORDER BY RANDOM() LIMIT 0,1";

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            string Rname = "";
            string tel = "";
            string typ = "";
            string wktime = "";

            while (sqlite_datareader.Read())
            {
                Rname = sqlite_datareader["Restaurant"].ToString();
                tel = sqlite_datareader["Tel"].ToString();
                typ = sqlite_datareader["Type"].ToString();
                wktime = sqlite_datareader["WorkTime"].ToString();

                //MessageBox.Show(s);
            }

            sqlite_conn.Close();

            //DataTable dt = new DataTable();
            //dt.Load(sqlite_datareader);

            TopLabel.Text = Rname + "\n" +
                            tel + "\n" +
                            typ + "\n" +
                            wktime;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }
    }
}