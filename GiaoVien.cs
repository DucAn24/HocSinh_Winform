using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class GiaoVien
    {
        private string name;
        private string address;
        private string phoneNumber;
        private int cmnd;


        public GiaoVien(string name, string address, string phoneNumber, int cmnd)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.cmnd = cmnd;

        }

    }
}
