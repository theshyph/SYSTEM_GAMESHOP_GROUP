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
    public partial class Form1 : Form {
        public  Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e) {
            weapon1.Visible = true;
            general1.Visible = false;
            armor1.Visible = false;
        }

        private void weapon_Click(object sender,EventArgs e) {
            weapon1.Visible = true;
            general1.Visible = false;
            armor1.Visible = false;
        }

        private void general_Click(object sender,EventArgs e) {
             weapon1.Visible = false;
            general1.Visible = true;
            armor1.Visible = false;
        }

        private void armor_Click(object sender,EventArgs e) {
             weapon1.Visible =false;
            general1.Visible = false;
            armor1.Visible = true;
        }
    }
}
