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
    public partial class Form1 : Form
    {
        addToCart addtoCart = new addToCart();

        public Form1()
        {
            InitializeComponent();
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from CURRENCY";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              string  currencyDATAReader = reader.GetValue(2).ToString(); //Gets data from SQL Database(DB_Shop)
              placeHolder_Quanti.Text  = currencyDATAReader; //Assign the data that is taken to placeHolder_Quanti.Text
            }
              con.Close();

            con.Open(); // This updates the currency from the program to the sql database.
            int conversion = int.Parse(placeHolder_Quanti.Text) + 100; // Converts the string(from placeHolder_Quanti.Text) to int. This makes computation possible.
            SqlCommand cmdUpdate = new SqlCommand("update CURRENCY set currency_amount = ' "+ conversion + " ' ", con);
            cmdUpdate.ExecuteNonQuery();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weapon1.Visible = true;
            general1.Visible = false;
            armor1.Visible = false;
        }

        private void weapon_Click(object sender, EventArgs e)
        {
            weapon1.Visible = true;
            general1.Visible = false;
            armor1.Visible = false;
            MenuLabel.Text = "* WEAPONS *";
        }

        private void general_Click(object sender, EventArgs e)
        {
            weapon1.Visible = false;
            general1.Visible = true;
            armor1.Visible = false;
            MenuLabel.Text = "* GENERAL *";
        }

        private void armor_Click(object sender, EventArgs e)
        {
            weapon1.Visible = false;
            general1.Visible = false;
            armor1.Visible = true;
            MenuLabel.Text = "* ARMORS *";
        }

        private void cart_Click(object sender, EventArgs e)
        {
            addtoCart.Visible = true;
        }
    }
}
