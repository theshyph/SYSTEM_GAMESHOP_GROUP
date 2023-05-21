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

namespace ShopSystem
{
    public partial class quantityPrompt_RustySword : Form
    {
        addToCart addtoCart = new addToCart();
        public quantityPrompt_RustySword()
        {
            InitializeComponent();
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from WEAPONS";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string weaponDATAReader = reader.GetValue(1).ToString();
                weapon_1_name.Text = "[Item: " + weaponDATAReader + "]";
                weaponDATAReader = "Price: " + reader.GetValue(2).ToString();
                weapon_1_price.Text = weaponDATAReader;
                weaponDATAReader = "Description: " + reader.GetValue(4).ToString();
                weapon_1_desc.Text = weaponDATAReader;
            }
            con.Close();
        }
        private  int a = 0;
        private void add_Btn_Click(object sender, EventArgs e)
        {
            a++;
            quantity_TXTBox.Text = a.ToString();
        }

        private void subtract_Btn_Click(object sender, EventArgs e)
        {
            a--;
            quantity_TXTBox.Text = a.ToString();
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
          Visible = false;
            a = 0;
            quantity_TXTBox.Text=a.ToString();
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "insert into ADDCART (item_Name, item_Quantity, item_Price) values ('Rusty SwordTest', '1', '100')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully added to cart");
        }
    }
}
