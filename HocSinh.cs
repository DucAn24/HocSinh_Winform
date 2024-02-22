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

        // Getter and setter for name
        public string getName
        {
            get { return name; }
            set { name = value; }
        }

        // Getter and setter for address
        public string getAddress
        {
            get { return address; }
            set { address = value; }
        }

        // Getter and setter for cmnd
        public string getCmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        // Getter and setter for birth
        public string getBirth
        {
            get { return birth; }
            set { birth = value; }
        }




    }
}
