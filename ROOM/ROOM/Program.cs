using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROOM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入所选年级,1为一年级、2为二年级、3为三年级、4为四年级、5为五年级、6为六年级");
            int quantity = int.Parse(Console.ReadLine());
            Create.A(quantity);
        }
    }
}
