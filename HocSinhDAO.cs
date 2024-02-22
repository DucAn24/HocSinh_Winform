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


        public void Add(HocSinh hocSinh)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten, Diachi, Cmnd, NgayThangNam) VALUES ('{0}', '{1}', '{2}', GETDATE())", hocSinh.getName, hocSinh.getAddress, hocSinh.getCmnd, hocSinh.getBirth);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }

        public void Modify(HocSinh hocSinh)
        {

            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi = '{1}', NgayThangNam = '{2}'  WHERE CMND = '{3}' ", hocSinh.getName, hocSinh.getAddress, hocSinh.getBirth, hocSinh.getCmnd);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }

        public void Delete(HocSinh hocSinh)
        {
            string sqlStr = string.Format(" DELETE FROM HocSinh WHERE CMND = '{0}' ", hocSinh.getCmnd);
            dbConnection db = new dbConnection();
            db.Execute(sqlStr);
        }



    }
}
