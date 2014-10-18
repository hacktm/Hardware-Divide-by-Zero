using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;



/*namespace A_Sharp_Bench*/ 
namespace A_Sharp_Bench
{

    /*Algorithm class*/ 
    public class Algorithms
    {

        /*Prime Calculation*/ 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Number"></param>
        /// <returns></returns>
        public bool Prime_calculation(ulong Number)
        {
            bool Prime_isTrue = true;
            ulong i;
             
            /**/ 
            for (i = 2; i <= (ulong)(Number / 2); i++)
            {
                /**/
                if ((ulong)(Number % i) == 0)
                {
                    Prime_isTrue = false;
                    break;
                }
                else
                {
                    Prime_isTrue = true; 
                }
            }

            //Console.WriteLine("{0}", Prime_isTrue); 
            return Prime_isTrue; 
        }



        /*Mersenne Prime Calculation*/
        public bool Mersenne_Prime_Calculation(ulong Number)
        {
            bool MPrime_isTrue = true;
            ulong MPNumber;  
            
            /**/
            if (Prime_calculation(Number) == true)
            {
                
                /**/ 
                MPNumber = (ulong)(Math.Pow(2,Number)-1);
 

                /**/
                if (Prime_calculation(MPNumber) == true)
                {
                    /*Number is Mersene Prime*/ 
                    MPrime_isTrue = true; 
                }
                else
                {
                    /*Number is Prime, bt not Mersenne Prime*/ 
                    MPrime_isTrue = false; 
                }

            }
            else
            {
             /*Number is not Prime*/
             MPrime_isTrue = false;
            }


            return MPrime_isTrue; 
         }


        /*new Algo?*/ 
   }



}
