using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    class DataConnection
    {
        readonly string conStr;
        // tạo kết nối
        // cô có thể thêm data( file sql đính kèm) vào máy cô và thay đổi Data Source thành tên của laptop cô là sẽ có thể chạy được ạ! 
        public DataConnection()
        {
            conStr = "Data Source = DESKTOP-8I4FATD; initial catalog=SINHVIEN; integrated security=True";

        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
