using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject0._1
{
    class Employee
    {
        private int empId;
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }//직원번호

        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }//직원명

        private int empPass;
        public int EmpPass
        {
            get { return empPass; }
            set { empPass = value; }
        }//직원 비밀번호

        //private Bitmap empimg;
        //public Bitmap EmpImg
        //{
        //    get { return empimg; }
        //    set { empimg = value; }
        //}//직원 사진

        private int workTime;
        public int WorkTime
        {
            get { return workTime; }
            set { workTime = value; }
        }//근무시간

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }//전화
        
        private DateTime hireDate;
        public DateTime Hiredate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }//입사일
        
        private int rank;
        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }//직급


    }
}
