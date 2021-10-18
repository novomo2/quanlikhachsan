using QLKSHOANGLONG.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSHOANGLONG
{
    public partial class frmChiTietPhieuPhong : Form
    {
        public formManHinhChinh objMHC;
        //private ManHinhCuaNhanVien manHinhCuaNhanVien;

        //public frmChietTietPhieuPhong()
        //{
        //    InitializeComponent();
        //}
        public frmChiTietPhieuPhong(formManHinhChinh frm)
        {

            InitializeComponent();
            objMHC = frm;
        }

        //public frmChiTietPhieuPhong(ManHinhCuaNhanVien manHinhCuaNhanVien)
        //{
        //    this.manHinhCuaNhanVien = manHinhCuaNhanVien;
        //}

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
        //private void BindGrid(List<ChiTietHoaDon> listDichVu)
        //{
        //    dgvChiTietDichVu.Rows.Clear();
        //    foreach (var item in listDichVu)
        //    {
        //        int index = dgvChiTietDichVu.Rows.Add();
        //        dgvChiTietDichVu.Rows[index].Cells[0].Value = index++;
        //        dgvChiTietDichVu.Rows[index].Cells[1].Value = item.IDDichVu;
        //        //dgvChiTietDichVu.Rows[index].Cells[2].Value = ;
        //        dgvChiTietDichVu.Rows[index].Cells[3].Value = item.GiaDV;
        //        dgvChiTietDichVu.Rows[index].Cells[4].Value = item.SoLuong;
        //        dgvChiTietDichVu.Rows[index].Cells[5].Value = item.ThanhTien;
        //    }
        //}

        private void FillDichVuCombobox(List<DichVu> listDichVu)
        {
            this.cbTenDichVu.DataSource = listDichVu;
            this.cbTenDichVu.DisplayMember = "TenDV";
            this.cbTenDichVu.ValueMember = "IDDichVu";
        }
        private void FillLoaiPhongCombobox(List<LoaiPhong> listLoaiPhong)
        {
            this.cbLoaiPhong.DataSource = listLoaiPhong;
            this.cbLoaiPhong.DisplayMember = "TenLoai";
            this.cbLoaiPhong.ValueMember = "IDLoaiPhong";
        }
        private void FillSoPhongCombobox(List<Phong> listSoPhong)
        {
            this.cbSoPhong.DataSource = listSoPhong;
            this.cbSoPhong.DisplayMember = "IDPhong";
            this.cbSoPhong.ValueMember = "IDPhong";
        }
        private void FillKhachDatCombobox(List<DatPhong> listDatPhong)
        {
            this.cbKhachDat.DataSource = listDatPhong;
            this.cbKhachDat.DisplayMember = "TenDatPhong";
            this.cbKhachDat.ValueMember = "IDDatPhong";
        }
        private void FillNhanVienCombobox(ComboBox cbTen, List<NhanVien> listNhanVien)
        {
            this.cbNhanVien.DataSource = listNhanVien;
            this.cbNhanVien.DisplayMember = "TenNV";
            this.cbNhanVien.ValueMember = "IDNhanVien";
        }

        private void FChiTietPhieuPhong_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgvChiTietDichVu);
            //BindGrid(ChiTietHoaDon.GetAll());
            FillDichVuCombobox(DichVu.GetAll());
            FillLoaiPhongCombobox(LoaiPhong.GetAll());
            //cbLoaiPhong.SelectedIndex = 0;
            FillKhachDatCombobox(DatPhong.GetAll());
            FillNhanVienCombobox(cbNhanVien, NhanVien.GetAll());
            FillSoPhongCombobox(Phong.GetAll());
            //cbNhanVien.SelectedIndex = 0;
            //cbSoPhong.SelectedIndex = 0;

        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Fmmhc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private HoaDon GetHoaDon()
        {
            HoaDon hd = new HoaDon();
            hd.TenLoai = cbLoaiPhong.Text;
            hd.IDNhanVien = int.Parse(cbNhanVien.SelectedValue + "");
            //hd.TenPhong = cbSoPhong.Text;
            hd.IDPhong = int.Parse(cbSoPhong.SelectedValue + "");
            hd.SoDem = int.Parse(txtSoDemO.Text);
            hd.SoKhach = int.Parse(txtSoKhach.Text);
            hd.NgayHD = dtpNgayCI.Value.ToString("dd/MM/yyyy");

            //if (cbKhachDat.Text != "")
            //    hd.IDDatPhong = int.Parse(cbKhachDat.SelectedValue + "");
            return hd;
        }
        private List<DichVu> GetListDichVu()  //lay nguoc tu datagrid ra
        {
            //giá trị có thể là null nên cộng với null để k bị lỗi
            List<DichVu> list = new List<DichVu>();
            foreach (DataGridViewRow row in this.dgvChiTietDichVu.Rows)
            {
                DichVu dv = new DichVu();
                dv.IDDichVu = int.Parse(row.Cells["id"].Value + "");
                dv.TenDV = (row.Cells[1].Value + "");
                dv.GiaDV = int.Parse(row.Cells[2].Value + "");
                dv.SoLuong = int.Parse(row.Cells[3].Value + "");
                dv.ThanhTien = int.Parse(row.Cells[4].Value + "");
                list.Add(dv);
            }

            return list;
        }



     

        private void txtSoDemO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblThanhTien.Text = (int.Parse(txtGiaPhong.Text) * int.Parse(txtSoDemO.Text)).ToString();
            }
            catch
            {
                lblThanhTien.Text = "";
            }

            
        }


        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSoPhong.SelectedValue != null)
                {
                   
                    Phong objPhong = Phong.GetPhong(int.Parse(cbSoPhong.SelectedValue + ""));
                    if (objPhong != null)
                    {
                        txtGiaPhong.Text = objPhong.GiaPhong.ToString();
                    }
                }
            }
            catch { }
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbLoaiPhong.SelectedValue != null)
                {
                    LoaiPhong temp = (LoaiPhong)cbLoaiPhong.SelectedItem;
                    var list = Phong.GetAll(temp.IDLoaiPhong);
                    FillSoPhongCombobox(list);
                }
            }
            catch { }
        }

        private void cbTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tendv = cbTenDichVu.SelectedItem.ToString();
            List<DichVu> listKQTK = DichVu.GetAll();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dv = DichVu.GetDichVu(int.Parse(cbTenDichVu.SelectedValue.ToString()));
                if (txtSoLuong.Text == "")
                    throw new Exception("Vui long nhap so luong!");
                int index = dgvChiTietDichVu.Rows.Add();
                dgvChiTietDichVu.Rows[index].Cells[0].Value = (index + 1).ToString();
                dgvChiTietDichVu.Rows[index].Cells[1].Value = dv.TenDV;
                dgvChiTietDichVu.Rows[index].Cells[2].Value = dv.GiaDV + "";
                dgvChiTietDichVu.Rows[index].Cells[3].Value = txtSoLuong.Text + "";
                int thanhtien = dv.GiaDV.Value * int.Parse(txtSoLuong.Text);
                dgvChiTietDichVu.Rows[index].Cells[4].Value = thanhtien.ToString();
                dgvChiTietDichVu.Rows[index].Cells["id"].Value = dv.IDDichVu + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvChiTietDichVu.SelectedRows)
            {
                dgvChiTietDichVu.Rows.RemoveAt(item.Index);
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {

                //insert khách hàng trước mới có hóa đơn
                KhachHang kh = new KhachHang();
                kh.TenKH = txtTenKhach.Text;
                kh.QuocTich = txtQuocTich.Text;
                kh = kh.InsertUpdate();
                List<DichVu> listDV = GetListDichVu();

                //insert hoa don
                HoaDon hd = GetHoaDon();

                //insert  khách hàng trước khi insert hóa đơn
                hd.IDKhachHang = kh.IDKhachHang;
                hd.TongTien = listDV.Sum(p => p.ThanhTien) + int.Parse(txtGiaPhong.Text) * hd.SoDem.Value;
                int IdHoaDon = hd.InsertUpdate();

                //có hóa đơn rồi insert chi tiet hoa don
                foreach (DichVu d in listDV)
                {
                    ChiTietHoaDon item = new ChiTietHoaDon();
                    item.IDDichVu = d.IDDichVu;
                    item.GiaDV = d.GiaDV;
                    item.IDHoaDon = IdHoaDon;
                    item.SoLuong = d.SoLuong;
                    item.ThanhTien = d.ThanhTien;
                    item.InsertUpdate();
                }

                DateTime ngayCI = dtpNgayCI.Value;
                DateTime ngayCO = dtpNgayCO.Value;
                int soPhong = int.Parse(cbSoPhong.Text);
                string tenKhachDat = cbKhachDat.Text;

                ThongTinPhieuPhong thongTinPhieuPhong =
                 new ThongTinPhieuPhong(tenKhachDat, kh.TenKH, kh.QuocTich, int.Parse(txtSoKhach.Text), ngayCI, ngayCO, soPhong, hd.TongTien.Value);

                objMHC.DatPhongTruoc(thongTinPhieuPhong);
                this.Close();
                //  frmManHinhChinh frm2 = new frmManHinhChinh();
                //  frm2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
        }

       

       

      
    }


    
}
