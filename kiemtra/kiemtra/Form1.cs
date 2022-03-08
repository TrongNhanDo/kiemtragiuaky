using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btblogin_Click(object sender, EventArgs e)
        {
            if(textboxusername.Text.Equals("admin") && textboxmatkhau.Text.Equals("admin")){
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }
    }
}
