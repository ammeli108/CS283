﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Employee
    {
        public string Id { get; set; }

        public string Title;

        public string Name;

        public Employee()
        {
            Title = "行政助理";
            BaseSalary = 0;
        }

        protected int baseSalary;

        public virtual int BaseSalary
        {
            get => baseSalary;
            set
            {
                //switch (Title)
                //{
                //    case "經理:":
                //        if (value < 61009)
                //            baseSalary = 61009;
                //        else if (value > 90000)
                //            baseSalary = 90000;
                //        else
                //            baseSalary = value;
                //        break;

                //}
                if (value < 21009)
                    baseSalary = 21009;
                else if (value > 50000)
                    baseSalary = 50000;
                else
                    baseSalary = value;
            }
        }

        public virtual int Salary
        {
            get => baseSalary;
        }

        public override string ToString()
        {
            return string.Format(
                "員工編號:{0}\n" +
                "員工姓名:{1}\n" +
                "員工職稱:{4}\n" +
                "底薪:{2}" +
                "總薪資:{3}"
                , Id
                , Name
                , baseSalary
                , Salary
                , Title
                );
        }
    }
}