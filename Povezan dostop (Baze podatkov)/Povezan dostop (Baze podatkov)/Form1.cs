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

namespace Povezan_dostop__Baze_podatkov_
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
            lstPodatki.Items.Clear();
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "SELECT * FROM EMPLOYEES";
            SqlCommand u =new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType=CommandType.Text;
            //izvedi ukaz
            p.Open();
            SqlDataReader r=u.ExecuteReader();
            while (r.Read())
            {
                string zaIzpis = r["FirstName"].ToString()+" "+ r[1].ToString() + ", " + r["City"].ToString();//0 = FirstName, 1=LastName
                lstPodatki.Items.Add(zaIzpis);
            }
            r.Close();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "SELECT * FROM EMPLOYEES WHERE City=@City";//brez predsledkov
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            //namesto grdega zapisa
            SqlParameter par=new SqlParameter("@City", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;
            //izvedi ukaz
            p.Open();
            SqlDataReader r = u.ExecuteReader();
            while (r.Read())
            {
                string zaIzpis = r["FirstName"].ToString() + " " + r[1].ToString() + ", " + r["City"].ToString();//0 = FirstName, 1=LastName
                lstPodatki.Items.Add(zaIzpis);
            }
            r.Close();
            p.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "SELECT COUNT(*)FROM EMPLOYEES";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            //izvedi ukaz
            p.Open();
            int število = (int)u.ExecuteScalar();
            lstPodatki.Items.Add("Število zaposlenih je " + število);
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstPodatki.Items.Clear();
            //povezava
            SqlConnection p = new SqlConnection(povezava);
            //ukaz
            string ukaz = "UPDATE EMPLOYEES SET City='Nova Gorica' WHERE City='Tacoma'";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            //izvedi ukaz
            p.Open();
            int število = u.ExecuteNonQuery();
            lstPodatki.Items.Add("Število posodobljenih je " + število);
            p.Close();
        }
    }
}
