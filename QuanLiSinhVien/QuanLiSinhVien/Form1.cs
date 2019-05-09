using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-8I4FATD; initial catalog=SINHVIEN; integrated security=True");
        SinhVienBLL bllSV;
        DataTable dt;
        private DataTable dtsv;

        public Form1()
        {
            InitializeComponent();
            bllSV = new SinhVienBLL();
        }

        public void ShowAllSinhVien() // hiển thị tất cả sinh viên
        {
            DataTable dt = bllSV.getAllSinhVien();
            dataGridViewSinhVien.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();
        }
        private void DisableControl() // khóa các thuộc tính
        {

            this.txtHoten.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtLop.Enabled = false;
            this.txtMavung.Enabled = false;
            this.txtMSSV.Enabled = false;
            this.txtNgaysinh.Enabled = false;
            this.txtSDT.Enabled = false;
            this.radioButton1.Enabled = false;
            this.radioButton2.Enabled = false;
            this.radioButton3.Enabled = false;
        }

        private void Enable() // mở các thuộc tính
        {
            this.txtHoten.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtLop.Enabled = true;
            this.txtMavung.Enabled = true;
            this.txtMSSV.Enabled = true;
            this.txtNgaysinh.Enabled = true;
            this.txtSDT.Enabled = true;
            this.radioButton1.Enabled = true;
            this.radioButton2.Enabled = true;
            this.radioButton3.Enabled = true;
        }

        private void Clear() // clear các thuộc tính
        {
            txtNgaysinh.Value = System.DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            txtHoten.Text = "";
            txtMSSV.Text = "";
            txtLop.Text = "";
            txtMavung.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void dataGridViewSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e) // hiện thị thông tin khi click chuột
        {
            int index = e.RowIndex;
            if(index>=0)
            {
                txtHoten.Text = dataGridViewSinhVien.Rows[index].Cells["HOTEN"].Value.ToString();
                txtMSSV.Text = dataGridViewSinhVien.Rows[index].Cells["MSSV"].Value.ToString();
                txtLop.Text = dataGridViewSinhVien.Rows[index].Cells["LOP"].Value.ToString();
                txtNgaysinh.Text = dataGridViewSinhVien.Rows[index].Cells["NGAYSINH"].Value.ToString();
                txtSDT.Text = dataGridViewSinhVien.Rows[index].Cells["DIENTHOAI"].Value.ToString();
                txtMavung.Text = dataGridViewSinhVien.Rows[index].Cells["MAVUNG"].Value.ToString();
                txtEmail.Text = dataGridViewSinhVien.Rows[index].Cells["EMAIL"].Value.ToString();

                if (dataGridViewSinhVien[4, dataGridViewSinhVien.CurrentRow.Index].Value.ToString() == "Nam")
                {
                    radioButton1.Checked = true;
                }
                if (dataGridViewSinhVien[4, dataGridViewSinhVien.CurrentRow.Index].Value.ToString() == "Nữ")
                {
                    radioButton2.Checked = true;
                }
                if (dataGridViewSinhVien[4, dataGridViewSinhVien.CurrentRow.Index].Value.ToString() == "Chưa xác định")
                {
                    radioButton3.Checked = true;
                }
                DisableControl();
            }
        }

       

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            //in hoa chữ cái đầu nhờ vào textinfo.ToTitlecase
            txtHoten.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtHoten.Text);
            //cho con nháy đi về sau mỗi kí tự được nhập
            txtHoten.SelectionStart = txtHoten.Text.Length;
        }
        private bool PhoneNumberCheck(string sdt) //Kiểm số điện thoại 
        {
            if (sdt.Length == 9 || sdt.Length == 10)
            {
                if (sdt[0] == '0')
                    return false;
                for (int i = 0; i < sdt.Length; i++)
                {
                    if (!char.IsDigit(sdt[i]))
                        return false;
                }
            }
            else
                return false;
            return true;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (PhoneNumberCheck(txtSDT.Text) == false)
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại(số điện thoại 9-10 số và không số 0 ở đâu)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
            }
        }

        private bool EmailCheck(string Email)//Kiểm tra email
        {
            Regex regex = new Regex(@"^([a-zA-z]+)(([a-z0-9A-Z]|[.])*)@([a-z0-9A-Z]+)([.]{1})([a-z0-9A-Z]+)(([.]{0,1}[a-z0-9A-Z])*)$");
            Match match = regex.Match(Email);
            if (match.Success)
                return true;
            else
                return false;
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (EmailCheck(txtEmail.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
        }

    

        private bool CheckData() //Kiểm tra dữ liệu đã nhập chưa
        {
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã số sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return false;
            }
            return true;
        }


        private bool MessageDelete() //Thông báo cho người dùng khi chuẩn bị xóa
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn xóa dữ liệu này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        private string GetGioiTinh()//Lấy giới tính của sinh viên
        {
            if (radioButton1.Checked)
                return "Nam";
            else if (radioButton2.Checked)
                return "Nữ";
            return "Chưa xác định";
        }

        public void InsertSinhVien() // thêm sinh viên
        {

            string sql = "INSERT INTO SINHVIEN VALUES(@HOTEN,@MSSV,@LOP,@NGAYSINH,@GIOITINH,@DIENTHOAI,@MAVUNG,@EMAIL)";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
            cmd.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
            cmd.Parameters.AddWithValue("@LOP", txtLop.Text);
            cmd.Parameters.AddWithValue("@NGAYSINH", txtNgaysinh.Value.ToString());
            cmd.Parameters.AddWithValue("@GIOITINH", GetGioiTinh());
            cmd.Parameters.AddWithValue("@DIENTHOAI", txtSDT.Text);
            cmd.Parameters.AddWithValue("@MAVUNG", txtMavung.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.ExecuteNonQuery();
            con.Close();

        }



        public void UpdateSinhVien() // edit sinh viên
        {
            string sql = "UPDATE SINHVIEN SET MSSV = @MSSV, HOTEN = @HOTEN, LOP = @LOP, NGAYSINH = @NGAYSINH, GIOITINH=@GIOITINH,DIENTHOAI=@DIENTHOAI,MAVUNG=@MAVUNG,EMAIL=@EMAIL WHERE MSSV=@MSSV";
            con.Open();
            cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@HOTEN", txtHoten.Text);
            cmd.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
            cmd.Parameters.AddWithValue("@LOP", txtLop.Text);
            cmd.Parameters.AddWithValue("@NGAYSINH", txtNgaysinh.Value.ToString());
            cmd.Parameters.AddWithValue("@GIOITINH", GetGioiTinh());
            cmd.Parameters.AddWithValue("@DIENTHOAI", txtSDT.Text);
            cmd.Parameters.AddWithValue("@MAVUNG", txtMavung.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowAllSinhVien();

        }

        public void DeleteSinhVien() // xóa sinh viên
        {
            string sql = "DELETE FROM SINHVIEN WHERE MSSV=@MSSV";

            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ShowAllSinhVien();
        }


        private void Insert_Click(object sender, EventArgs e) // event khi ấn vào nút thêm
        {
            Enable();
            if (Them.Text == "Thêm")
            {
                Clear();
                txtHoten.Focus(); // Focus vào textbox họ tên
                Them.Text = "Lưu"; // chuyển tên button sang Lưu
                this.Sua.Enabled = false;
                this.Xoa.Enabled = false;
                dataGridViewSinhVien.Enabled = false;
            }
            else if (Them.Text == "Lưu")
            {
                
                    if (CheckData())
                    {
                        InsertSinhVien();
                        ShowAllSinhVien();
                    }
                Them.Text = "Thêm";
                this.Sua.Enabled = true; // khóa button sửa
                this.Xoa.Enabled = true; // khóa button xóa
                dataGridViewSinhVien.Enabled = true; // mở dataGridViewSinhVien
            }
        }

        private void Update_Click(object sender, EventArgs e) // event khi nhấn vào nút sửa
        {
            Enable();
            if (Sua.Text == "Sửa")
            {
                
                txtHoten.Focus(); // Focus vào textbox họ tên
                Sua.Text = "Lưu"; // chuyển tên button sang Lưu
                this.Them.Enabled = false;
                this.Xoa.Enabled = false;
                dataGridViewSinhVien.Enabled = false;
            }
            else if(Sua.Text == "Lưu")
            {
                if(CheckData())
                {
                    UpdateSinhVien();
                    ShowAllSinhVien();
                }
                Sua.Text = "Sửa";
                this.Them.Enabled = true; // mở button thêm
                this.Xoa.Enabled = true; // mở button xóa
                dataGridViewSinhVien.Enabled = true; // mở dataGridViewSinhVien
            }

        }

        private void Xoa_Click(object sender, EventArgs e) // event khi nhấn vào nút xóa
        {
            if (MessageDelete() == true)
            {
                DeleteSinhVien();
                Clear();
            }
        }
    }
}
