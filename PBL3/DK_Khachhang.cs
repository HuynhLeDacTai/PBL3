using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class DK_Khachhang : Form
    {
        public DK_Khachhang()
        {
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_login.Text = "NEW CUSTOMER REGISTRATION";
            lb_phoneNumber.Text = "Phone number";
            lb_firstLastName.Text = "First & Last Name";
            btn_save.Text = "Save";
            lb_login.Font = new Font("Microsoft Sans Serif", 16);
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_login.Text = "ĐĂNG KÝ KHÁCH HÀNG MỚI";
            lb_phoneNumber.Text = "Số điện thoại";
            lb_firstLastName.Text = "Họ và tên";
            btn_save.Text = "Lưu";
            lb_login.Font = new Font("Microsoft Sans Serif", 18);
        }
    }
}
