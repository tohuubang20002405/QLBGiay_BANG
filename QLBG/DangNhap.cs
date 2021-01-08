using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBG
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if ((this.txtDN.Text == "admin") && (this.txtMK.Text == "1234"))
            {
                this.Hide();
                frmMenu frm = new frmMenu();
                frm.Show();



            }
            else
            {
                MessageBox.Show("không đúng tên người dùng / mật khẩu!!!", "Thông báo");
                this.txtDN.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

