using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;

        public Form2()
        {
            InitializeComponent();

            sqlite_conn = new SQLiteConnection("Data source=FoodPocket.db");

            sqlite_conn.Open();

            sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM FoodPocket";

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            DataTable OpenFoodPocket = new DataTable();
            OpenFoodPocket.Load(sqlite_datareader);

            MyFoodPocketGrid.DataSource = OpenFoodPocket.DefaultView;
        }
    }
}