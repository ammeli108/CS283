using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Strategy_Patten_01
{
    internal class 轉轉果實 : 超人系果實, 具有飛行能力的介面
    {
        public void 飛行()
        {
            Console.WriteLine("變成飛機, 飛起來");
        }
    }
}