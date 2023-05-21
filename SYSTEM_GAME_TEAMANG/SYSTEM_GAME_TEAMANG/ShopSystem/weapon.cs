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

namespace ShopSystem {
    public partial class weapon : UserControl {

        quantityPrompt quantityprompt = new quantityPrompt();
        public weapon() {
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
                string weaponDATAReader =  reader.GetValue(1).ToString();
                weapon_1_name.Text = weaponDATAReader;
                weaponDATAReader = "Price: "+reader.GetValue(2).ToString();
                weapon_1_price.Text = weaponDATAReader;
                weaponDATAReader = "Description: "+reader.GetValue(4).ToString();
                weapon_1_desc.Text = weaponDATAReader;
            }
            con.Close();

        }

        private void weapon_1_Btn_Click(object sender, EventArgs e)
        {
            quantityprompt.Show();
        }
    }
}
