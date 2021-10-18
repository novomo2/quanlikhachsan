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
    public partial class FQuanLyKhachHang : Form
    {
        public FQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            formManHinhChinh fmmhc = new formManHinhChinh();
            fmmhc.Show();
            this.Hide();
        }
        private void BindGrid(List<KhachHang> listKhachHang)
        {
            dgvQuanLyKhachHang.Rows.Clear();

            foreach (var item in listKhachHang)
            {
                int index = dgvQuanLyKhachHang.Rows.Add();
                dgvQuanLyKhachHang.Rows[index].Cells[0].Value = item.IDKhachHang;
                dgvQuanLyKhachHang.Rows[index].Cells[1].Value = item.TenKH;
                dgvQuanLyKhachHang.Rows[index].Cells[2].Value = item.QuocTich;
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            List<KhachHang> listkh = new List<KhachHang>();
            List<HoaDon> listHD = HoaDon.GetAll();
            DateTime tungay = DateTime.Parse(dtpTuNgay.Text);
            DateTime denngay = DateTime.Parse(dtpTuNgay.Text);
            foreach (var item in listHD)
            {
                DateTime dt = DateTime.Parse(item.NgayHD);
                if (dt >= tungay && dt <= denngay)
                {
                    KhachHang kh = new KhachHang();
                    kh.IDKhachHang = ((int)item.IDKhachHang);
                    kh.TenKH = (item.KhachHang.TenKH);
                    kh.QuocTich = (item.KhachHang.QuocTich);
                    listkh.Add(kh);
                }
            }
            BindGrid(listkh);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<KhachHang> listKQTK = KhachHang.GetAll();
            var listKhacHang = listKQTK.Where(p => (p is KhachHang) && (p as KhachHang).TenKH.ToLower().Contains(txtTim.Text.ToLower())).ToList();
            if (listKhacHang.Count > 0)
            {
                BindGrid(listKhacHang);
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng nào!");
            }
        }

        private void FQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid(KhachHang.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
