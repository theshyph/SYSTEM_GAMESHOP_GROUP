using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopSystem
{
    public partial class quantityPrompt : Form
    {
        public quantityPrompt()
        {
            InitializeComponent();
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
    }
}
