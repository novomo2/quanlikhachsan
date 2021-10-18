using QLKSHOANGLONG.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSHOANGLONG
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Silver;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Silver;
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            //gọi đến class MatKhau
            MatKhau obj = new MatKhau();
            List<MatKhau> list = obj.GetAll();

            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            var check = list.Where(item => item.username.Equals(tenDangNhap)).ToList();
            if (check.Count > 0)
            {
                if (check[0].password.Equals(matKhau))
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    formManHinhChinh mhc = new formManHinhChinh();
                    mhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Không ĐÚng !");
                }
            }
            else
            {
                MessageBox.Show("Tài Khoản Không Tồn Tại!");
            }
        }

        private void btQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quên thì phải chịu");
        }
    }
}
