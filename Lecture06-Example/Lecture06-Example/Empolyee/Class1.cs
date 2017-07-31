using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpolyeeNS
{
    public class Empolyee
    {
        //    private int baseSalary;
        //    private int salary;
        //    public int Benefit;

        //    public int BaseSalary
        //    {
        //        get => baseSalary;

        //        set
        //        {
        //            if (value < 0)
        //                this.baseSalary = 0;
        //            else
        //                this.baseSalary = value;
        //        }
        //    }

        //    public int Salary { get => baseSalary + Benefit; }
        //}

        public string Name;
        private int baseSalary;
        private int benefit;

        public int BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value < 0)
                    this.baseSalary = 0;
                else
                    this.baseSalary = value;
            }
        }

        //public int Benefit
        //{
        //    get => benefit;

        //    set
        //    {
        //        {
        //            if (value < 0)
        //                this.Benefit = 0;
        //            else
        //                this.Benefit = value;
        //        }
        //    }
        //}

        public int Salary
        {
            get
            {
                return benefit + baseSalary;
            }
        }

        public int Benefit
        {
            get => benefit;

            set
            {
                if (value < 0)
                    this.benefit = 0;
                else
                    this.benefit = value;
            }
        }
    }
}