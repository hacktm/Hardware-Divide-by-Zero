using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;

/*A#Bench namespace*/ 
namespace A_Sharp_Bench
{

     
    
    /**/ 
    public partial class A_Sharp_Bench : Form
    {
        static Algo_Execution algo_exec = new Algo_Execution();
        
        /*Component Initialization*/ 
        public A_Sharp_Bench()
        {
            /**/
            Console.WriteLine("Hello! Welcome to A#Bench!"); 
            
            InitializeComponent();
        }


        /**/ 
        public void Lauch_Execution()
        {
            /*4 situations*/
            /*
             1 - Only Prime 
             2 - Only Mersenne Prime 
             3 - Both of them   
             4 - None of them are selected (exported in Launch_Click()) 
             */

            /*1 - Only Prime*/
            if ((checkbox_Prime.Checked == true) && (checkbox_MPrime.Checked == false))
            {
                algo_exec.ExecPrime_Number(); 
            }

            /*2 - Only Mersenne Prime*/
            if ((checkbox_Prime.Checked == false) && (checkbox_MPrime.Checked == true))
            {
                algo_exec.execMPrime_Number();
            }

            /*3 - Both of them*/
            if ((checkbox_Prime.Checked == true) && (checkbox_MPrime.Checked == true))
            {
                algo_exec.ExecPrime_Number();
                algo_exec.execMPrime_Number();
            }
        }


        /*Loop execution function*/
        void Loop_execution()
        {
            int Loop_Number = 6;
            int Loop_Counter = 1; 

            /*Loop Execution*/
            while (Loop_Number != 0)
            {
                var start = Stopwatch.StartNew(); //start of measurement 
                Lauch_Execution();
                long elapsedTimeMs = start.ElapsedMilliseconds; //end of time measurement



                Console.ForegroundColor = ConsoleColor.Red;  
                Console.WriteLine("Loop counter:{0}", Loop_Counter); 
                Console.WriteLine("{0}",elapsedTimeMs);
                Console.ResetColor(); 

                Console.WriteLine("\n");

                Loop_Counter++;
                Loop_Number--; 
            }
        }





        /*Launch button*/ 
        private void Launch_Click(object sender, EventArgs e)
        {

            /*4 - None of them*/
            if ((checkbox_Prime.Checked == false) && (checkbox_MPrime.Checked == false))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You must select at lest one value!");
                Console.ResetColor();
            }
             

            


           
             
            Thread.Sleep(1000); 
            Console.Clear(); 
            Console.ResetColor(); 
        }

        



    }
}
