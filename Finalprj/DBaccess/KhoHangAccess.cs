using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalprj.DBaccess
{
    internal class KhoHangAccess
    {
        public List<myDataBase.KhoHang> Get()
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            return db.KhoHangs.ToList();
        }

        public void Them(myDataBase.KhoHang value)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            db.sp_Insert_KhoHang(value.ID, value.Ten, value.DonViTinh, value.soLuong, value.DonGia);
        }
        public void Sua(myDataBase.KhoHang value)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            db.sp_Update_KhoHang(value.ID, value.Ten, value.DonViTinh, value.soLuong, value.DonGia);
        }
        public void Xoa(myDataBase.KhoHang value)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            db.sp_Delete_KhoHang(value.ID);
        }

        public void Xoa(string ID)
        {
            myDataBase.MyDatabase db = new myDataBase.MyDatabase();
            db.sp_Delete_KhoHang(ID);
        }
    }
}
