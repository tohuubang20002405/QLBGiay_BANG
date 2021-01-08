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
    public partial class TTKH : Form
    {
        public TTKH()
        {
            InitializeComponent();
        }
        Conect co = new Conect();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;


            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from KhachHang where MaKH = '" + textBox1.Text + "'";
                co.ThucThi(sqlxoa);
            }
            TTKH_Load(sender, e); 
        }
        public void LoadData()
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from KhachHang");
            co.NgatKetNoi();
        }

        private void TTKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox5.Clear();
            this.textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into KhachHang values ('" + textBox1.Text + "','" + textBox2.Text
             + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            co.ThucThi(sqlthem);
            TTKH_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlsua = "update KhachHang set MaKH='" + textBox1.Text + "',TenKH='" + textBox2.Text + "',GioiTinh = '" + textBox3.Text
              + "',DiaChi='" + textBox4.Text + "',sdt='" + textBox5.Text + "'where MaKH='" + textBox1.Text + "'";
            co.ThucThi(sqlsua);
            //LoadData();
            TTKH_Load(sender, e);
        }
    }
}
