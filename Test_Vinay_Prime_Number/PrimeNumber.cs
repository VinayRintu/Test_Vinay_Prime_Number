using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Vinay_Prime_Number
{
    public class PrimeNumber
    {
        int count=0;
        public void FindPrimeNumber()
        {
            Console.WriteLine("Enter any Number");
            int num=int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count == 2)            
                Console.WriteLine("Given Number Is PrimeNumber");            
            else            
                Console.WriteLine("Given Number Not a PrimeNumber");            
        }
    }
}
