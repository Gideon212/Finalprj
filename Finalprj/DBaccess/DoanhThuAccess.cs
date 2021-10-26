using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalprj.DBaccess
{
    internal class DoanhThuAccess
    {
        public List<myDataBase.HoaDonNhapHang> GetHoaDonNhapHang()
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.HoaDonNhapHangs.ToList();
        }

        public List<myDataBase.f_LayCTHoaDonNhapHang_Result> Get_ChiTiet(string ID)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.f_LayCTHoaDonNhapHang(ID).ToList();
        }

        public List<myDataBase.f_DoanhThu_Result> GetDoanhThu(DateTime daybegin, DateTime dayend)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.f_DoanhThu(daybegin, dayend).ToList();
        }

        public List<myDataBase.f_DoanhThuNgay_BanHang_Result> GetDoanhThuNgay_BanHang(DateTime date)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.f_DoanhThuNgay_BanHang(date).ToList();
        }

        public List<myDataBase.f_DoanhThuNgay_NhapHang_Result> GetDoanhThuNgay_NhapHang(DateTime date)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.f_DoanhThuNgay_NhapHang(date).ToList();
        }
    
    }
}
