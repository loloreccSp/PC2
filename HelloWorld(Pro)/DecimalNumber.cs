using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Pro_
{
    public struct DecimalNumber
    {
        public int number { get; set; }

        public DecimalNumber(int number)
        {
            this.number = number;
        }

        public void BinarySystem()
        {
            int num_check = number;
            int check = number % 2;
            int num = 0;
            int[] arr = new int[] { num };
            //Console.WriteLine(arr);

            if (check <= 1) 
            {
                for (int i = 0; i <= num_check / 2; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        num_check = num_check / 2;
                        num = num_check % 2;
                        //arr += num;
                        Console.Write(num);
                    }
                }

            }
        }
    }
}
