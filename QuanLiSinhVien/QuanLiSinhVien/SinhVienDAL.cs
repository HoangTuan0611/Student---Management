using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    class SinhVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        public SinhVienDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllSinhVien()
        {
            // Tạo câu lệnh sql để lấy toàn bộ sinh viên
            string sql = "SELECT * FROM SINHVIEN";
            // Tạo kết nối đến sql
            SqlConnection con = dc.getConnect();

            // Mở kết nối
            con.Open();
            
            // Khởi tạo đối tượng của lớp DataAdapter
            da = new SqlDataAdapter(sql,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Đóng kết nối
            con.Close();
            return dt;
        }
        
    }
}
