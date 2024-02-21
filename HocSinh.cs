using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thucHanh
{
    internal class HocSinh
    {
        private string name;
        private string address;
        private string cmnd;
        private string birth;


        public HocSinh(string name, string address,  string cmnd, string birth )
        {
            this.name = name;
            this.address = address;
            this.cmnd = cmnd;
            this.birth = birth;

        }

        public HocSinh() { }

        public string getName { get => name; set { } }
        public string getAddress { get => address; set { } }
        public string getCmnd { get => cmnd; set { } }
        public string getBirth { get => birth; set { } }




    }
}
