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
    public partial class QLTT : Form
    {
        public QLTT()
        {
            InitializeComponent();
        }
        Conect co = new Conect();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from SanPham where MaSP = '" + textBox1.Text + "'";
                co.ThucThi(sqlxoa);
            }
            QLTT_Load(sender, e);

        }
        public void LoadData()
        {
            co.KetNoi();
            dataGridView1.DataSource = co.GetData("select * from SanPham");
            co.NgatKetNoi();
        }
        private void QLTT_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();

            comboBox1.DataSource = co.GetData("select * from NhaCC");
            comboBox1.ValueMember = "MaNCC";
            comboBox1.DisplayMember = "MaNCC";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into SanPham values ('" + textBox1.Text + "','" + textBox2.Text
                + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";

            co.ThucThi(sqlthem);
            //LoadData();
            QLTT_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlsua = "update SanPham set MaSP='" + textBox1.Text + "',TenSP='" + textBox2.Text
            + "',MaNCC='" + comboBox1.SelectedValue + "',soluong='" + textBox4.Text + "',giaban='" + textBox3.Text + "'where MaSP='" + textBox1.Text + "'";
            co.ThucThi(sqlsua);
            //LoadData();

           
            QLTT_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();

            this.textBox3.Clear();
            this.textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
            comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString().Trim();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString().Trim();
            textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString().Trim();
        }
    }
}
