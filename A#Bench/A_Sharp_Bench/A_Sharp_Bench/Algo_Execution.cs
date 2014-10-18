using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A_Sharp_Bench
{

    
    /*Algorithm Execution class*/ 
    public class Algo_Execution
    {
        /**/ 
        static Algorithms algo = new Algorithms();  

        /*ExecPrime_Number function*/
        public void ExecPrime_Number()
        {
            ulong Number_Range;
            for (Number_Range = 2; Number_Range <= 32; Number_Range++)
            {
                algo.Prime_calculation(Number_Range);
            }
        }


        /*execMPrime_Number function*/ 
       /// <summary>
       /// 
       /// </summary>
        public void execMPrime_Number()
        {
            ulong Number_Range;
            for (Number_Range = 2; Number_Range <= 32; Number_Range++)
            {
                algo.Mersenne_Prime_Calculation(Number_Range);
            }
        }

        


    }
}
