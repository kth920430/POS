using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionEx1
{
    class friend
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        private string addr;

        public string Addr
        {
            get { return addr; }
            set { addr = value; }
        }
        public friend(string name,string mobile,string addr)
        {
            this.name = name;
            this.mobile = mobile;
            this.addr = addr;
        }


    }
}
