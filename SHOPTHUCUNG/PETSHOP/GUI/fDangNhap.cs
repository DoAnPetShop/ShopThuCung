using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE;

namespace GUI
{
    public partial class fDangNhap : UserControl
    {
        DataTable dt;
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            String MatKhau = txtPass.Text;
            sqlConnection con = new sqlConnection();
            String sql = "select count(TaiKhoan) from NhanVien where TaiKhoan = '" + Name + "' and MatKhau = '" + MatKhau + "'";
            con.CreateConnection(@"Data source=LAPTOP-VS13VLD8; Initial Catalog= QL_SHOPTHUCUNG1; Integrated Security = false; uid = sa;pwd = sa");
            dt = con.ExcuteQuery(sql);
            if (con.TaiKhoan(sql) > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = "";
                txtPass.Text = "";
                txtName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
    ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit(); 
        }
    }
}
