using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ประกาศตัวแปร 
            int x;
            int y;
            int z;
            string operand;

            //การป้อนตัวเลขค่าเข้าไปในเก็บใน x
            Console.WriteLine("Number x enter :");
            x = Convert.ToInt32(Console.ReadLine());

            //การใส่เครื่องหมายทางคณิตศาสตร์
            Console.WriteLine("operand (+ , - , * , /) enter:");
            operand = Console.ReadLine();

            //การป้อนตัวเลขค่าเข้าไปในเก็บใน y
            Console.WriteLine("Number y enter:");
            y = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {

                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;

                default:
                    z = 0;
                    break;
            }
            // การแสดงคำตอบของตัวแปร Z
            Console.WriteLine(x.ToString() + " " + operand + " " + y.ToString() + " = " + z.ToString());
            Console.ReadLine();


        }
    }
}
