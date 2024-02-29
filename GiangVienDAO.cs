using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class GiangVienDAO
    {
        dbConnection db = new dbConnection();
        public void Add(GiangVien giangVien)
        {

            string sqlStr = string.Format("INSERT INTO GiangVien(id, ten, gioi_tinh, dia_chi, cmnd, ngay_thang_nam, phone, email) VALUES ('{0}', '{1}', '{2}','{3}' , '{4}' ,'{5}', '{6}' , '{7}')"
                                        , giangVien.getId, giangVien.getHoTen, giangVien.getGioiTinh, giangVien.getDiaChi, giangVien.getCmnd, giangVien.getNgaySinh.ToString("yyyy-MM-dd"), giangVien.getPhone, giangVien.getEmail);
            db.Execute(sqlStr);
        }

        public void Modify(GiangVien giangVien)
        {

            string sqlStr = string.Format("UPDATE GiangVien SET  ten = '{0}', gioi_tinh = '{1}', dia_chi = '{2}', cmnd = '{3}', ngay_thang_nam = '{4}' ,phone = '{5}', email = '{6}'  WHERE id = '{7}' "
                                        , giangVien.getHoTen, giangVien.getGioiTinh, giangVien.getDiaChi, giangVien.getCmnd, giangVien.getNgaySinh.ToString("yyyy-MM-dd"), giangVien.getPhone, giangVien.getEmail, giangVien.getId);
            db.Execute(sqlStr);
        }

        public void Delete(GiangVien giangVien)
        {
            string sqlStr = string.Format(" DELETE FROM GiangVien WHERE id = '{0}' ", giangVien.getId);
            db.Execute(sqlStr);
        }

    }
}
