using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSHOANGLONG.Model;

namespace QLKSHOANGLONG
{
    public partial class FCapNhatThongTinNhanVien : Form
    {
        public FCapNhatThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void BindGrid(List<NhanVien> listNhanVien)
        {
            dgvThongTinNhanVien.Rows.Clear();
            int id = 1;
            foreach (var item in listNhanVien)
            {
                int index = dgvThongTinNhanVien.Rows.Add();
                dgvThongTinNhanVien.Rows[index].Cells[0].Value = item.IDNhanVien;
                dgvThongTinNhanVien.Rows[index].Cells[1].Value = item.SDT;
                dgvThongTinNhanVien.Rows[index].Cells[2].Value = item.TenNV;
            }
        }
        private NhanVien GetNhanVien()
        {
            NhanVien k = new NhanVien();
            k.TenNV = txtTenNhanVien.Text;
            k.SDT = int.Parse(txtSDTNhanVien.Text);
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyNhanVien qlnv = new FQuanLyNhanVien();
            qlnv.Show();
            this.Hide();
        }

        private void FCapNhatThongTinNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien s = GetNhanVien();
                NhanVien db = NhanVien.GetNhanVien(s.IDNhanVien);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //không xóa được những thằng đang có liên kết đến bảng khác.
                //ví dụ k thể xóa những nv có id 1->3 vì bên lịch làm việc có 3 id nv từ 1->3
                int rowIndex = (int)dgvThongTinNhanVien.CurrentRow.Cells[0].Value;
                NhanVien.Delete(rowIndex);
                BindGrid(NhanVien.GetAll());
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa không thành công vì liên quan đến các dữ liệu khác!");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            NhanVien s = GetNhanVien();
            s.IDNhanVien = (int)dgvThongTinNhanVien.CurrentRow.Cells[0].Value;
            NhanVien db = NhanVien.GetNhanVien(s.IDNhanVien);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(NhanVien.GetAll());
        }

        private void dgvThongTinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThongTinNhanVien.Rows[e.RowIndex];
                int IDNhanVien = int.Parse(row.Cells[0].Value.ToString());
                NhanVien db = NhanVien.GetNhanVien(IDNhanVien);
                txtTenNhanVien.Text = db.TenNV.ToString();
                txtSDTNhanVien.Text = db.SDT.ToString();
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<NhanVien> listKQTK = NhanVien.GetAll();
            var listTimNhanVien = listKQTK.Where(p => (p is NhanVien) && (p as NhanVien).TenNV.ToLower().Contains(txtTenNhanVien.Text.ToLower())).ToList();
            if (listTimNhanVien.Count > 0)
            {
                BindGrid(listTimNhanVien);
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            BindGrid(NhanVien.GetAll());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
