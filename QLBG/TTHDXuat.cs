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
    public partial class TTHDXuat : Form
    {
        public TTHDXuat()
        {
            InitializeComponent();
        }
        Conect co = new Conect();
        public void LoadData()
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from Hoadonban");
            co.NgatKetNoi();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox8.Clear();
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox7.Clear();
            this.textBox6.Clear();

            this.textBox4.Clear();
        }

        private void TTHDXuat_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();
            comboBox2.DataSource = co.GetData("select * from SanPham");
            comboBox2.ValueMember = "MaSP";
            comboBox2.DisplayMember = "MaSP";

            comboBox1.DataSource = co.GetData("select * from KhachHang");
            comboBox1.ValueMember = "MaKH";
            comboBox1.DisplayMember = "MaKH";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Soluong = double.Parse(textBox4.Text);
            double Dongia = double.Parse(textBox8.Text);
            double Tongtien = Soluong * Dongia;
            textBox9.Text = Tongtien.ToString();
            //co.KetNoi();
            string sqlthem = "insert into Hoadonban values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + textBox4.Text + "','" + maskedTextBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            co.ThucThi(sqlthem);
            TTHDXuat_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from Hoadonban where MaHDB = '" + textBox1.Text + "'";
                co.ThucThi(sqlxoa);
            }
            TTHDXuat_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
            comboBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
            maskedTextBox1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString().Trim();
            textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
            textBox7.Text = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
            textBox8.Text = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Soluong = double.Parse(textBox4.Text);
            double Dongia = double.Parse(textBox8.Text);
            double Tongtien = Soluong * Dongia;
            textBox9.Text = Tongtien.ToString();
            co.KetNoi();
            string sqlsua = "update Hoadonban set MaHDB='" + textBox1.Text + "',MaNV='" + textBox2.Text +
                "',MaKH='" + comboBox1.SelectedValue + "',MaSP='" + comboBox2.SelectedValue +
                "',Soluong='" + textBox4.Text + "',Ngayban='" + maskedTextBox1.Text + "',Diachi='" + textBox6.Text +
                "',sdt='" + textBox7.Text + "',Dongia='" + textBox8.Text + "',Tongtien='" + textBox9.Text + "' where MaHDB='" + textBox1.Text + "'";
            co.ThucThi(sqlsua);
            //LoadData();
            TTHDXuat_Load(sender, e);
        }
    }
}
