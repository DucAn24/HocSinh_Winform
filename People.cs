using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class People
    {
        private String ten;
        private String diaChi;
        private String cmnd;
        private DateTime ngaySinh;

        public People()
        {

        }

        public People(string ten, string diaChi, string cmnd, DateTime ngaySinh)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
        }

        public String getHoTen
        {
            get { return ten; }
            set { ten = value; }
        }

        public String getDiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public String getCmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public DateTime getNgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
    }
}

