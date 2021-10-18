using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSHOANGLONG.Model
{
    public class ThongTinPhieuPhong
    {


        public ThongTinPhieuPhong(String tenKhachDat, String tenKhachHang, String quocTich, int soKhach, DateTime ngayCI,
            DateTime ngayCO, int soPhong, int tongTien)
        {
            this.tenKhachDat = tenKhachDat;
            this.tenKhachHang = tenKhachHang;
            this.quocTich = quocTich;
            this.soKhach = soKhach;
            this.ngayCI = ngayCI;
            this.ngayCO = ngayCO;
            this.soPhong = soPhong;
            this.tongTien = tongTien;

        }

        public String tenKhachDat { get; set; }
        public String tenKhachHang { get; set; }
        public String quocTich { get; set; }

        public int soKhach { get; set; }

        public DateTime ngayCI { get; set; }
        public DateTime ngayCO { get; set; }

        public int soPhong { get; set; }

        public int tongTien { get; set; }


    }
}
