using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urltxt.Enabled = false;
            urlchkbtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {/**
            string connectionString = dbtext.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-11GU0EI;Initial Catalog=demourl;Integrated Security=True");
            SqlDataAdapter sqldata = new SqlDataAdapter("insert into urls (url,CreatedOn,ModifyOn,IsActive,IsDelete) values('"+dbtext.Text+"',GETDATE(),GETDATE(),1,0)", con);
            DataTable table = new DataTable();
            sqldata.Fill(table);
            foreach(DataRow row in table.Rows)
            {
                status.Text = row["url"].ToString();
            }
            //status.Text = dt.ToString();
       */
            try {
                string connectionstring = dbtext.Text;
                con = new SqlConnection(@"" + connectionstring);
                SqlDataAdapter sqldata = new SqlDataAdapter("select url from urls", con);
                DataTable table = new DataTable();
                sqldata.Fill(table);
                urltxt.Enabled = true;
                urlchkbtn.Enabled = true;
                dbtext.Enabled = false;
                status.Text = "Connection Stablished";
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                status.Text = "Check Your Connection String";
            }

        }

        private void urlchkbtn_Click(object sender, EventArgs e)
        {
            string url = urltxt.Text;
            bool valid = IsUrlValid(url);
            if (valid == true)
            {
                if (chktable(url) == true)
                {
                    status.Text = "Status: Already in Database";
                }
                else {
                    SqlDataAdapter sqldata = new SqlDataAdapter("insert into urls (url,CreatedOn,ModifyOn,IsActive,IsDelete) values('" + url + "',GETDATE(),GETDATE(),1,0)", con);
                    DataTable table = new DataTable();
                    sqldata.Fill(table);
                    status.Text = "Status: Valid Url And Add in Database";
                }
            }
            else
            {
                status.Text = "Status: Invalid Valid Url";
            }
        }
        public bool IsUrlValid(string webUrl)
        {
            if (webUrl == null || webUrl == "") return false;
            return Regex.IsMatch(webUrl, @"(http|https)://(([www\.])?|([\da-z-\.]+))\.([a-z\.]{2,3})$*");
        }

       public bool chktable(string data)
        {
            SqlDataAdapter sqldata = new SqlDataAdapter("select url from urls where url='"+ data + "'", con);
            DataTable table = new DataTable();
            sqldata.Fill(table);
            if (table != null) return true;
            else return false;
        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
