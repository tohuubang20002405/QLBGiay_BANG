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
    public partial class TTHDNhap : Form
    {
        public TTHDNhap()
        {
            InitializeComponent();
        }
        Conect co = new Conect();
        public void LoadData()
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from Hoadonnhap");
            co.NgatKetNoi();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TTHDNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();
            comboBox1.DataSource = co.GetData("select * from SanPham");
            comboBox1.ValueMember = "MaSP";
            comboBox1.DisplayMember = "MaSP";

            comboBox2.DataSource = co.GetData("select * from NhaCC");
            comboBox2.ValueMember = "MaNCC";
            comboBox2.DisplayMember = "MaNCC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox3.Clear();
            this.textBox6.Clear();
            this.textBox5.Clear();
            this.textBox4.Clear();
            this.textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Soluong = double.Parse(textBox4.Text);
            double Dongia = double.Parse(textBox6.Text);
            double Tongtien = Soluong * Dongia;
            textBox7.Text = Tongtien.ToString();
            //co.KetNoi();
            string sqlthem = "insert into Hoadonnhap values ('" + textBox1.Text + "','" + textBox2.Text +
                "','" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + textBox4.Text + "','" + maskedTextBox1.Text +
                "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            co.ThucThi(sqlthem);
            
            TTHDNhap_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Soluong = double.Parse(textBox4.Text);
            double Dongia = double.Parse(textBox6.Text);
            double Tongtien = Soluong * Dongia;
            textBox7.Text = Tongtien.ToString();
            //co.KetNoi();
            string sqlsua = "update Hoadonnhap set MaHDN='" + textBox1.Text + "',MaNV='" + textBox2.Text +
                "',MaSP='" + comboBox1.SelectedValue +
                "',MaNCC='" + comboBox2.SelectedValue + "',Soluong='" + textBox4.Text + "',Ngayban='" + maskedTextBox1.Text + "',Diachi='" + textBox3.Text +
                "',sdt='" + textBox5.Text + "',Dongia='" + textBox6.Text + "',Tongtien='" + textBox7.Text + "' where MaHDN='" + textBox1.Text + "'";
            co.ThucThi(sqlsua);

            TTHDNhap_Load(sender, e);
            //LoadData();
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
            textBox3.Text = dataGridView1.Rows[i].Cells[6].Value.ToString().Trim();
            textBox5.Text = dataGridView1.Rows[i].Cells[7].Value.ToString().Trim();
            textBox6.Text = dataGridView1.Rows[i].Cells[8].Value.ToString().Trim();
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
                string sqlxoa = "delete from Hoadonnhap where MaHDN = '" + textBox1.Text + "'";
                co.ThucThi(sqlxoa);
            }
            TTHDNhap_Load(sender, e);
        }
    }
}
