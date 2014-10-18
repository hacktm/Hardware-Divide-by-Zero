using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/**/ 
namespace A_Sharp_Bench
{

    /*Algorithm class*/ 
    public class Algorithms
    {

        /*Prime Calculation*/ 
        public bool Prime_calculation(long Number)
        {
            bool Prime_isTrue = true;
            long i;
            int Counter = 0; 

            /**/ 
            for (i = 2; i < (long)(Number / 2); i++)
            {
                /**/
                if ((Number % i) == 0)
                {
                    Counter++;
                }
                else
                {
                  /*Do nothing*/ 
                }
            }

            /**/
            if (Counter != 0) {Prime_isTrue = false;}
            else {Prime_isTrue = true;}



            return Prime_isTrue; 
        }




        /*Mersenne Prime Calculation*/
        public bool Mersenne_Prime_Calculation(long Number)
        {
            bool isTrue = true;

            return isTrue; 
         }




    }



}
