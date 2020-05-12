using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 첫 번째 수열 : 1
             * 두 번째 수열 : 11
             * 세 번째 수열 : 12
             * 네 번째 수열 : 1121
             * 다섯 번째 수열 : 122111
             * 여섯 번째 수열 : 112213
             */

            int[] sequence = new int[1000];
            int[] temp = new int[1000];
            int j = 0, k = 0;
            int cnt = 1;
            int length = 20;
            sequence[0] = 1;

            for(int i = 0; i < length - 1; i++)
            {
                j = 0;
                k = 0;

                while(sequence[j] != 0)
                {
                    if(sequence[j] == sequence[j + 1])
                    {
                        cnt++;
                    } else
                    {
                        temp[k] = sequence[j];
                        k++;
                        temp[k] = cnt;
                        k++;

                        cnt = 1;
                    }
                    j++;
                }
                
                for(int z = 0; z < 1000; z++)
                {
                    sequence[z] = temp[z];
                    temp[z] = 0;
                }
            }

            Console.Write(length + "번째 수열 : ");

            for(int i = 0; i < 1000; i++)
            {
                if (sequence[i] == 0)
                    break;
                Console.Write(sequence[i]);
            }

            Console.WriteLine();
        }
    }
}
