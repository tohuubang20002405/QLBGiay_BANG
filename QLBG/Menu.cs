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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void quảnLýThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLTT frm = new QLTT();
            frm.Show();
            this.Hide();
        }

        

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTHDNhap frm = new TTHDNhap();
            frm.Show();
            this.Hide();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTHDXuat frm = new TTHDXuat();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKH frm = new TTKH();
            frm.Show();
            this.Hide();
        }

        private void quayLaijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

      

     

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



       
        private void thôngTinNhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKNCC frm = new TKNCC();
            frm.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TKKH frm = new TKKH();
            frm.Show();
            this.Hide();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
