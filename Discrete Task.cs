using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


                
                            //prime number

            int num, i, ctr, stno, enno;

            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.ReadKey();



            //------------------------------------------------------------------------------------------------



                             // perfect number

            int n, i, sum;
            int mn, mx;

            Console.Write("Input the starting number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
            Console.ReadKey();


            //--------------------------------------------
            
                   //Eng:mohamed Ahmed elhusseini
                   //Eng:Amar Yasser Frag
        }
    }
}
