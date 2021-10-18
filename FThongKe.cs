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
    public partial class FThongKe : Form
    {
        public FThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formManHinhChinh fmmhc = new formManHinhChinh();
            fmmhc.Show();
            this.Hide();
        }
        private void BindGrid(List<ThongKe> listThongKe)
        {
            dgvThongKe.Rows.Clear();

            foreach (var item in listThongKe)
            {
                int index = dgvThongKe.Rows.Add();
                dgvThongKe.Rows[index].Cells[0].Value = item.IDThongKe;
                dgvThongKe.Rows[index].Cells[1].Value = item.NgayBD;
                dgvThongKe.Rows[index].Cells[2].Value = item.NgayKT;
                dgvThongKe.Rows[index].Cells[3].Value = item.TongDoanhThu;
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            List<ThongKe> listtk = new List<ThongKe>();
            List<HoaDon> listHD = HoaDon.GetAll();
            DateTime tungay = DateTime.Parse(dtpTuNgay.Text);
            DateTime denngay = DateTime.Parse(dtpTuNgay.Text);
            foreach (var item in listHD)
            {
                DateTime dt = DateTime.Parse(item.NgayHD);
                if (dt >= tungay && dt <= denngay)
                {
                    ThongKe tk = new ThongKe();
                    tk.NgayBD = dtpTuNgay.Text;
                    tk.NgayKT = dtpDenNgay.Text;
                    tk.TongDoanhThu = listHD.Sum(p => p.TongTien);
                    listtk.Add(tk);
                }
            }
            BindGrid(listtk);
        }
    }

}
