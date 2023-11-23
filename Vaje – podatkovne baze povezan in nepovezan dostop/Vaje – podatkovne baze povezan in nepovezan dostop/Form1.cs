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
//naloga: https://ucilnice.scng.si/pluginfile.php/7168/mod_resource/content/1/vaje_baze.pdf
namespace Vaje___podatkovne_baze_povezan_in_nepovezan_dostop
{
    public partial class Form1 : Form
    {
        string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Pro2\ŠtudentNet.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "SELECT * FROM EMPLOYEES";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "SELECT * FROM PREDMET";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            //izvedi ukaz
            p.Open();
            SqlDataReader r = u.ExecuteReader();
            while (r.Read())
            {
                string zaIzpis = "\n" + r["ImePredmeta"].ToString();
                labRezultati.Text += zaIzpis;
            }
            r.Close();
            p.Close();
        }
    }
}
