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
    public partial class armor : UserControl {
        public armor() {
            InitializeComponent();
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from ARMOR";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string armorDATAReader = reader.GetValue(1).ToString();
                armor_1_name.Text = armorDATAReader;
                armorDATAReader = "Price: " + reader.GetValue(2).ToString();
                armor_1_price.Text = armorDATAReader;
                armorDATAReader = "Description: " + reader.GetValue(4).ToString();
                armor_1_desc.Text = armorDATAReader;
            }
            con.Close();
        }
    }
}
