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
    public partial class FCapNhatVatTu : Form
    {
        public FCapNhatVatTu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyPhong mqv = new FQuanLyPhong();
            mqv.Show();
            this.Hide();
        }
        private void BindGrid(List<VatTu> listVatTu)
        {
            dgvVatTu.Rows.Clear();
            int id = 1;
            foreach (var item in listVatTu)
            {
                int index = dgvVatTu.Rows.Add();
                dgvVatTu.Rows[index].Cells[0].Value = id++;
                dgvVatTu.Rows[index].Cells[1].Value = item.IDVatTu;
                dgvVatTu.Rows[index].Cells[2].Value = item.TenVT;
            }
        }

        private void FCapNhatVatTu_Load(object sender, EventArgs e)
        {
            try
            {
               
                BindGrid(VatTu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private VatTu GetVatTu()
        {
            VatTu k = new VatTu();
            k.TenVT = txtTenVatTu.Text;
            return k;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                VatTu s = GetVatTu();
                VatTu db = VatTu.GetVatTu(s.IDVatTu);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Thêm vật tư thành công!");
                }
                BindGrid(VatTu.GetAll());
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
                int rowIndex = (int)dgvVatTu.CurrentRow.Cells[1].Value;
                VatTu.Delete(rowIndex);
                BindGrid(VatTu.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvVatTu.Rows[e.RowIndex];
                int maVT = int.Parse(row.Cells[1].Value.ToString());
                VatTu db = VatTu.GetVatTu(maVT);
                txtTenVatTu.Text = db.TenVT.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            VatTu s = GetVatTu();
            s.IDVatTu = (int)dgvVatTu.CurrentRow.Cells[1].Value;
            VatTu db = VatTu.GetVatTu(s.IDVatTu);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(VatTu.GetAll());
        }
    }
}
