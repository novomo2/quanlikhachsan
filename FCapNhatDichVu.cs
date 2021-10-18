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
    public partial class FCapNhatDichVu : Form
    {
        public FCapNhatDichVu()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
           FQuanLyPhong mqv = new FQuanLyPhong();
            mqv.Show();
            this.Hide();
        }
        private void BindGrid(List<DichVu> listDichVu)
        {
            dgvDichVu.Rows.Clear();
            int id = 1;
            foreach (var item in listDichVu)
            {
                int index = dgvDichVu.Rows.Add();
                dgvDichVu.Rows[index].Cells[0].Value = item.IDDichVu;
                dgvDichVu.Rows[index].Cells[1].Value = item.TenDV;
                dgvDichVu.Rows[index].Cells[2].Value = item.GiaDV;
            }
        }

        private void FCapNhatDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                
                BindGrid(DichVu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DichVu GetDichVu()
        {
            DichVu k = new DichVu();
            k.TenDV = txtTenDichVu.Text;
            k.GiaDV = int.Parse(txtGiaDV.Text);
            return k;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu s = GetDichVu();
                DichVu db = DichVu.GetDichVu(s.IDDichVu);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                BindGrid(DichVu.GetAll());
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
                int rowIndex = (int)dgvDichVu.CurrentRow.Cells[1].Value;
                DichVu.Delete(rowIndex);
                BindGrid(DichVu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
       

        private void btLuu_Click(object sender, EventArgs e)
        {
            DichVu s = GetDichVu();
            s.IDDichVu = (int)dgvDichVu.CurrentRow.Cells[0].Value;
            DichVu db = DichVu.GetDichVu(s.IDDichVu);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(DichVu.GetAll());
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDichVu.Rows[e.RowIndex];
                int id = int.Parse(row.Cells[0].Value.ToString());
                DichVu db = DichVu.GetDichVu(id);
                txtTenDichVu.Text = db.TenDV.ToString();
                txtGiaDV.Text = db.GiaDV.ToString();
            }
        }
    }
}
