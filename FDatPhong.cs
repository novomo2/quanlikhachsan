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
    public partial class FDatPhong : Form
    {
        public FDatPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formManHinhChinh f = new formManHinhChinh();
            f.Show();
            this.Hide();
        }

        private void BindGrid(List<DatPhong> listDatPhong)
        {
            dgvDatPhong.Rows.Clear();
            int id = 1;
            foreach (var item in listDatPhong)
            {
                int index = dgvDatPhong.Rows.Add();
                dgvDatPhong.Rows[index].Cells[0].Value = id++;
                dgvDatPhong.Rows[index].Cells[1].Value = item.TenDatPhong;
                dgvDatPhong.Rows[index].Cells[2].Value = item.SDTDatPhong;
                dgvDatPhong.Rows[index].Cells[3].Value = item.IDDatPhong;
            }
        }

        private void FDatPhong_Load(object sender, EventArgs e)
        {
            try
            {

                BindGrid(DatPhong.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DatPhong GetDatPhong()
        {
            DatPhong k = new DatPhong();
            k.TenDatPhong = txtKhachDat.Text;
            k.SDTDatPhong = int.Parse(txtSDTDatPhong.Text);
            return k;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                DatPhong s = GetDatPhong();
                DatPhong db = DatPhong.GetDatPhong(s.IDDatPhong);
                if (db == null)
                {
                    s.InsertUpdate();
                    MessageBox.Show("Đã đặt phòng thành công!");
                }
                BindGrid(DatPhong.GetAll());
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
                int rowIndex = (int)dgvDatPhong.CurrentRow.Cells[1].Value;
                DatPhong.Delete(rowIndex);
                BindGrid(DatPhong.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDatPhong.Rows[e.RowIndex];
                int maDatPhong = int.Parse(row.Cells[0].Value.ToString());
                DatPhong db = DatPhong.GetDatPhong(maDatPhong);
                txtKhachDat.Text = db.TenDatPhong.ToString();
                txtSDTDatPhong.Text = db.SDTDatPhong.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            DatPhong s = GetDatPhong();
            s.IDDatPhong = (int)dgvDatPhong.CurrentRow.Cells[1].Value;
            DatPhong db = DatPhong.GetDatPhong(s.IDDatPhong);
            if (db != null)
            {
                db = s;
                db.InsertUpdate();
                MessageBox.Show("Sửa thành công!");
            }
            BindGrid(DatPhong.GetAll());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
