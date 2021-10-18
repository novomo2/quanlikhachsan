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
    
    public partial class FQuanLyPhong : Form
    {
        public FQuanLyPhong()
        {
            InitializeComponent();
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindGrid(List<Phong> listPhong)
        {
            dgvQuanLyPhong.Rows.Clear();

            foreach (var item in listPhong)
            {
                int index = dgvQuanLyPhong.Rows.Add();
                dgvQuanLyPhong.Rows[index].Cells[0].Value = item.IDPhong;
                dgvQuanLyPhong.Rows[index].Cells[1].Value = item.TenPhong;
                dgvQuanLyPhong.Rows[index].Cells[2].Value = item.LoaiPhong.TenLoai;
                dgvQuanLyPhong.Rows[index].Cells[3].Value = item.GiaPhong;
            }
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            formManHinhChinh mhc = new formManHinhChinh();
            mhc.Show();
            this.Hide();
        }

       
        private void fmb_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btCapNhatDV_Click(object sender, EventArgs e)
        {
            FCapNhatDichVu fmdv = new FCapNhatDichVu();
            fmdv.Show();
            this.Hide();
        }
        private void fmdv_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btCapNhatVatTu_Click(object sender, EventArgs e)
        {
           FCapNhatVatTu fmvt = new FCapNhatVatTu();
            fmvt.Show();
            this.Hide();
        }
        private void fmvt_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FQuanLyPhong_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvQuanLyPhong);
                BindGrid(Phong.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btCapNhatLoaiPhong_Click(object sender, EventArgs e)
        {
            FCapNhatLoaiPhong fmb = new FCapNhatLoaiPhong();
            fmb.Show();
            this.Hide();
        }
    }
}
