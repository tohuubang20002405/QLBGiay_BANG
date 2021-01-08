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
    public partial class TKKH : Form
    {
        public TKKH()
        {
            InitializeComponent();
        }
        Conect co = new Conect();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TKKH_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang where MaKH = '" + textBox1.Text.Trim() + "'");
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang where TenKH = '" + textBox3.Text.Trim() + "'");
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang where Diachi = '" + textBox2.Text.Trim() + "'");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang where MaKH = '" + textBox1.Text.Trim() + "'");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang where TenKH = '" + textBox3.Text.Trim() + "'");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
