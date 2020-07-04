using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crystal_Analytics
{
    public partial class Form1 : Form
    {
        int actionUsed = 0;     // variable to store "action used" counts from DB
        int pickedItem = 0;     // variable to store "item picked" counts from DB
        int userPlayed = 0;     // variable to store "user played" counts from DB
        int heroDeath = 0;      // variable to store "hero death" counts from DB

        public Form1()
        {
            InitializeComponent();
            fillChart();       // method to fill the chart
        }

        //fillChart method  
        private void fillChart()
        {
            // Loading Database using SQLite
            DataTable table = new DataTable();
            string connectingString = "Data Source=../../../../Data/crystal.db";
            using (SQLiteConnection connection = new SQLiteConnection(connectingString))
            {
                connection.Open();
                //selecting the whole EnemyDeathposition
                string command = "SELECT * from Analytics";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection);
                adapter.Fill(table);
                connection.Close();
            }

            foreach (DataRow row in table.Rows)
            {
                // adding data to the resspective variables
                actionUsed += Convert.ToInt32(row[0]);
                pickedItem += Convert.ToInt32(row[1]);
                userPlayed += Convert.ToInt32(row[2]);
                heroDeath += Convert.ToInt32(row[3]);
            }

            //Marking the calculated data on the chart
            chart1.Series["Actions Used"].Points.AddY(actionUsed);
            chart1.Series["Item Picked"].Points.AddY(pickedItem);
            chart1.Series["User Played"].Points.AddY(userPlayed);
            chart1.Series["Hero Death"].Points.AddY(heroDeath);

            chart1.Titles.Add("Crystal Analytics");
        }
    }
}
