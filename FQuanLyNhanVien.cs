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
    public partial class FQuanLyNhanVien : Form
    {
        public FQuanLyNhanVien()
        {
            InitializeComponent();
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
                dgvLichLamViec.Rows[index].Cells[2].Value = item.NhanVien.SDT;
                dgvLichLamViec.Rows[index].Cells[3].Value = item.Ca;
                dgvLichLamViec.Rows[index].Cells[4].Value = item.Ngay;
                dgvLichLamViec.Rows[index].Cells[5].Value = item.IDNhanVien;
            }
        }
        private void fmmhgc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           formManHinhChinh fmmhc = new formManHinhChinh();
            fmmhc.Show();
            this.Hide();
        }
        private void fmmhc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btThongTinNhanVien_Click(object sender, EventArgs e)
        {
            FCapNhatThongTinNhanVien cnttnv = new FCapNhatThongTinNhanVien();
            cnttnv.Show();
            this.Hide();
        }

        private void btLichLamViec_Click(object sender, EventArgs e)
        {
            FCapNhatLichLamViec llv = new FCapNhatLichLamViec();
            llv.Show();
            this.Hide();
        }

        private void FQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(LichLamViec.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
