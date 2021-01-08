using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLBG
{
    class Conect
    {
        static string strConnect = @"Data Source=DESKTOP-ATMD6BL\SQLEXPRESS;Initial Catalog=QLCuaHangGiay;Integrated Security=True";
        //Khai báo đối tƣợng Connection (SqlConnection) và SqlCommand 
        SqlConnection sqlCon;//sử dụng cách 1         
        SqlCommand sqlCom;
        SqlCommand sqlCom2 = new SqlCommand();
        DataTable dt;
        //DataSet ds;
        //Phƣơng thức kết nối tới CSDL 
        public void KetNoi()
        {
            sqlCon = new SqlConnection(strConnect);
            //Kết nối tới nguồn CSDL 
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        //Ngắt kết nối (thƣờng gọi trong sự kiện FormClosing của Form) 
        public void NgatKetNoi()
        {
            sqlCon.Close();
        }
        public void ThucThi(string strSQL)
        {
            //Bƣớc 1: Kết nối tới CSLD (Gọi phƣơng thức KetNoi) 
            KetNoi();
            //Bƣớc 2: Khởi tạo và gọi phƣơng thức của đối tƣợng Command 
            sqlCom  = new SqlCommand(strSQL, sqlCon);
            sqlCom.ExecuteNonQuery();
            //Bƣớc 3: Ngắt kết nối 
            NgatKetNoi();

        }

        public DataTable GetData(string strSQL)
        {
            SqlDataAdapter DA;
           // ds = new DataSet();
            dt = new DataTable();
            //khoi tao gia tri cho doi tuong sqldataadapter
            DA = new SqlDataAdapter(strSQL, sqlCon);
            DA.Fill(dt);
            return dt;
        }
    }
}

