﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Strategy_Patten_01
{
    public class 四分五裂果實 : 超人系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("到處亂飛");
        }
    }
}