using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class HocSinh:People
    {
        public HocSinh(int id, string hoTen, string gioiTinh, string diaChi, string cmnd, DateTime ngaySinh, string phone, string email) : base(id, hoTen, gioiTinh, diaChi, cmnd, ngaySinh, phone, email)
        {

        }


    }
}
