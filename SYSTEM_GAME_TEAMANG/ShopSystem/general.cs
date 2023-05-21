using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class general : UserControl {
        public general() {
            InitializeComponent();
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-53PSDHE\SQLEXPRESS;Initial Catalog=DB_Shop;Integrated Security=true";
            con = new SqlConnection(connetionString);

            con.Open();
            string sql = "select * from ITEM";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string generalDATAReader = reader.GetValue(1).ToString();
                general_1_name.Text = generalDATAReader;
                generalDATAReader = "Price: " + reader.GetValue(2).ToString();
                general_1_price.Text = generalDATAReader;
                generalDATAReader = "Description: " + reader.GetValue(3).ToString();
                general_1_desc.Text = generalDATAReader;
            }
            con.Close();
        }
    }
}
