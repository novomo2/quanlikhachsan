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
    public partial class FCapNhatLoaiPhong : Form
    {
        public FQuanLyPhong objQuanLyPhong;
        public FCapNhatLoaiPhong()
        {
            InitializeComponent();
        }
        public FCapNhatLoaiPhong(FQuanLyPhong frm)
        {

            InitializeComponent();
            objQuanLyPhong = frm;
        }

        private void FillLoaiPhongCombobox(List<LoaiPhong> listLoaiPhong)
        {
            this.cbTenLoaiPhong.DataSource = listLoaiPhong;
            this.cbTenLoaiPhong.DisplayMember = "TenLoai";
            this.cbTenLoaiPhong.ValueMember = "IDLoaiPhong";
        }
        private void FillSoPhongCombobox(List<Phong> listSoPhong)
        {
            this.cbSoPhong.DataSource = listSoPhong;
            this.cbSoPhong.ValueMember = "IDPhong";
        }

        private void FCapNhatLoaiPhong_Load(object sender, EventArgs e)
        {
            
            FillLoaiPhongCombobox(LoaiPhong.GetAll());
            FillSoPhongCombobox(Phong.GetAll());
        }

        private LoaiPhong GetLoaiPhong()
        {
            LoaiPhong k = new LoaiPhong();
            k.TenLoai = cbTenLoaiPhong.Text;
            return k;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FQuanLyPhong mqv = new FQuanLyPhong();
            mqv.Show();
            this.Hide();
        }
    }
}
