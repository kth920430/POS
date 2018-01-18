﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject0._1
{
    class CheckIn
    {
        private int empId;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        private int empPass;

        public int EmpPass
        {
            get { return empPass; }
            set { empPass = value; }
        }

        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private byte[] empPic;

        public byte[] EmpPic
        {
            get { return empPic; }
            set { empPic = value; }
        }


        public CheckIn(int empId, int empPass, string empName,byte[] empPic)
        {
            this.empId = empId;
            this.empPass = empPass;
            this.empName = empName;
            this.empPic = empPic;
        }
    }
}
