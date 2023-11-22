using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja_okenska_aplikacija_za_baze_podatkov
{
    public partial class Form1 : Form
    {
        string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "SELECT TerritoryDescription, RegionDescription FROM Territories, Region WHERE\r\nTerritories.RegionID=Region.RegionID";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            //izvedi ukaz
            p.Open();
            SqlDataReader r = u.ExecuteReader();
            while (r.Read())
            {
                string zaIzpis = r["TerritoryDescription"].ToString() + " " + r["RegionDescription"].ToString();
                listBox1.Items.Add(zaIzpis);
            }
            r.Close();
            p.Close();
        }
    }
}
