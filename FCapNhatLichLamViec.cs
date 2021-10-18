using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSHOANGLONG.Model;

namespace QLKSHOANGLONG
{
    public partial class FCapNhatLichLamViec : Form
    {
        public FCapNhatLichLamViec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyNhanVien fqlnv = new FQuanLyNhanVien();
            fqlnv.Show();
            this.Hide();
        }
        private void BindGrid(List<LichLamViec> listLichLamViec)
        {
            dgvLichLamViec.Rows.Clear();
            int id = 1;
            foreach (var item in listLichLamViec)
            {
                int index = dgvLichLamViec.Rows.Add();
                dgvLichLamViec.Rows[index].Cells[0].Value = id++;
                dgvLichLamViec.Rows[index].Cells[1].Value = item.TenNV;
                dgvLichLamViec.Rows[index].Cells[2].Value = item.Ca;
                dgvLichLamViec.Rows[index].Cells[3].Value = item.Ngay;
                dgvLichLamViec.Rows[index].Cells[4].Value = item.IDLichLamViec;

            }
        }

        private void FillTenNhanVienCombobox(List<NhanVien> listTenNV)
        {
            this.cbTenNhanVien.DataSource = listTenNV;
            this.cbTenNhanVien.DisplayMember = "TenNV";
            this.cbTenNhanVien.ValueMember = "IDNhanVien";
        }
        private LichLamViec GetLichLamViec()
        {
            LichLamViec k = new LichLamViec();
          
            k.TenNV = cbTenNhanVien.Text;
            k.Ca = txtCaLamViec.Text;
            k.Ngay = dtpNgayLamViec.Value.ToString("dd/MM/yyyy");
            return k;
        }
        

        private void FCapNhatLichLamViec_Load(object sender, EventArgs e)
        {
            try
            {
                FillTenNhanVienCombobox(NhanVien.GetAll());
                BindGrid(LichLamViec.GetAll());
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
                LichLamViec s = GetLichLamViec();
                LichLamViec db = LichLamViec.GetLichLamViec(s.IDLichLamViec);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm  thành công!");
                }
                BindGrid(LichLamViec.GetAll());
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
                int rowIndex = (int)dgvLichLamViec.CurrentRow.Cells[0].Value;
                LichLamViec.Delete(rowIndex);
                BindGrid(LichLamViec.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            LichLamViec s = GetLichLamViec();
            s.IDLichLamViec = (int)dgvLichLamViec.CurrentRow.Cells[0].Value;
            LichLamViec db = LichLamViec.GetLichLamViec(s.IDLichLamViec);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(LichLamViec.GetAll());
        }
    }
}
