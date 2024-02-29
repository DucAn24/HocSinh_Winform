using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class People
    {
        private int id;
        private string hoTen;
        private string gioiTinh;
        private string diaChi;
        private string cmnd;
        private DateTime ngaySinh;
        private string phone;
        private string email;

        public People()
        {

        }

        public People(int id, string hoTen, string gioiTinh, string diaChi, string cmnd, DateTime ngaySinh, string phone, string email)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
            this.phone = phone;
            this.email = email; 
        }

        public int getId
        {
            get { return id; }
            set { id = value; }
        }

        public string getHoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string getGioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string getDiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string getCmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public DateTime getNgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string getPhone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string getEmail
        {
            get { return email; }
            set { email = value; }
        }
    }
}

