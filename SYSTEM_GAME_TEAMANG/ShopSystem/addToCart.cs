using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class addToCart : Form
    {
        public addToCart()
        {
            InitializeComponent();
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from ADDCART";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string addcartDATAReader = reader.GetValue(0).ToString(); //Gets data from SQL Database(DB_Shop)
                addtocart_checkedListBox1.Items.Add(addcartDATAReader);
                total_Placeholder.Text ="0";
            }
            con.Close();

        }

        private void when_Checkbox_checked(object sender, ItemCheckEventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from ADDCART";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string addcartDATAReader = reader.GetValue(2).ToString(); //Gets data from SQL Database(DB_Shop)
                total_Placeholder.Text = addcartDATAReader;
            }
            con.Close();
        }
    }
}
