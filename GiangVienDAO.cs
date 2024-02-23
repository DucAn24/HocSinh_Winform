using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class GiangVienDAO
    {
        public void Add(GiangVien  giangVien)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten, Diachi, Cmnd, NgayThangNam) VALUES ('{0}', '{1}', '{2}', GETDATE())", giangVien.getHoTen, giangVien.getDiaChi, giangVien.getCmnd, giangVien.getNgaySinh);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }

        public void Modify(GiangVien giangVien)
        {

            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', NgayThangNam = '{2}'  WHERE CMND = '{3}' ", giangVien.getHoTen, giangVien.getDiaChi, giangVien.getNgaySinh, giangVien.getCmnd);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }

        public void Delete(GiangVien giangVien)
        {
            string sqlStr = string.Format(" DELETE FROM HocSinh WHERE CMND = '{0}' ", giangVien.getCmnd);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }

    }
}
