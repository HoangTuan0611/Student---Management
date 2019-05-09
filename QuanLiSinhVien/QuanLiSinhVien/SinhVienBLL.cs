using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    class SinhVienBLL
    {
        SinhVienDAL dalSV;
        public SinhVienBLL()
        {
            dalSV = new SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getAllSinhVien();
        }
    }
}
