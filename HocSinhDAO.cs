using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thucHanh
{
    internal class HocSinhDAO
    {
        dbConnection db = new dbConnection();


        public void Add(HocSinh hocSinh)
        {

            string sqlStr = string.Format("INSERT INTO HocSinh( id, ten, gioi_tinh, dia_chi, cmnd, ngay_thang_nam, phone, email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}','{5}', '{6}' ,'{7}' )"
                                    , hocSinh.getId, hocSinh.getHoTen, hocSinh.getGioiTinh, hocSinh.getDiaChi, hocSinh.getCmnd, hocSinh.getNgaySinh.ToString("yyyy-MM-dd"), hocSinh.getPhone, hocSinh.getEmail );
            db.Execute(sqlStr);
        }

        public void Modify(HocSinh hocSinh)
        {

            string sqlStr = string.Format("UPDATE HocSinh SET  ten = '{0}', gioi_tinh = '{1}', dia_chi = '{2}', cmnd = '{3}', ngay_thang_nam = '{4}',phone = '{5}', email = '{6}'  WHERE id = '{7}'"
                                        ,hocSinh.getHoTen, hocSinh.getGioiTinh, hocSinh.getDiaChi, hocSinh.getCmnd, hocSinh.getNgaySinh.ToString("yyyy-MM-dd"), hocSinh.getPhone, hocSinh.getEmail, hocSinh.getId);
            db.Execute(sqlStr);
        }

        public void Delete(HocSinh hocSinh)
        {
            string sqlStr = string.Format(" DELETE FROM HocSinh WHERE id = '{0}' ", hocSinh.getId);
            db.Execute(sqlStr);
        }


    }
}
