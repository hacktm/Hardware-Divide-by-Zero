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
        string RxString;

        /*Globals*/
        double Fast = 0;
        double Slow = 100000000;
        public static long Total_Time = 0;
        

        

        /*Component Initialization*/ 
        public A_Sharp_Bench()
        {

            /*Welcome screen*/
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--Welcome to A#Bench--");
            Console.WriteLine("a CPU benchmark application");

            /**/
            InitializeComponent();
            Serial_Init();

        }

        public void Serial_Init()
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            serialPort1.Write("1");
        }
        /**/ 
        public void Launch_Execution()
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
            long oldTimeMs = 100000000;
            Total_Time = 0;
             
            /*Start of execution console*/ 
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Starting execution\n"); 


            /*Loop Execution*/
            while (Loop_Number != 0)
            {

                Console.ResetColor(); 

                var start = Stopwatch.StartNew(); //start of measurement 
                Launch_Execution();
                long elapsedTimeMs = start.ElapsedMilliseconds; //end of time measurement

                /*Time Comparison*/
                if (oldTimeMs > elapsedTimeMs)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Loop counter:{0}", Loop_Counter);
                    Console.WriteLine("{0}", elapsedTimeMs);
                    Console.ResetColor();
                }
                else if (oldTimeMs <= elapsedTimeMs)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Loop counter:{0}", Loop_Counter);
                    Console.WriteLine("{0}", elapsedTimeMs);
                    Console.ResetColor();
                }

                 
                oldTimeMs = elapsedTimeMs;
                Total_Time += elapsedTimeMs;
 

                /*Slowest and fastest execution*/
                if (elapsedTimeMs > Fast)
                {
                    Fast = elapsedTimeMs;
                }
                else if (elapsedTimeMs < Slow)
                {
                    Slow = elapsedTimeMs;
                }


                
                /*Progress bar incrementation*/ 
                progressBar.Increment(20);

                Loop_Counter++;
                Loop_Number--;

                Console.WriteLine("\n");
 
            }

           
 

            /*Returns Total Time of loop execution*/
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Total time:{0}\n",Total_Time);



            /*Delta*/
            double Delta = Fast - Slow;
            Console.WriteLine("Delta is:{0}\n", Delta);
        }

        private void beginTest(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.Clear();



            /*4 - None of them*/
            if ((checkbox_Prime.Checked == false) && (checkbox_MPrime.Checked == false))
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You must select at lest one value!");
                Console.ResetColor();
            }
            else
            {
                /*Program Execution*/
                Loop_execution();


                /*Resetting progress bar to 0*/
                Thread.Sleep(500);
                progressBar.Value = 0;
            }

            Console.ResetColor();
            Thread.Sleep(1000);

            serialPort1.Write("2");

            Chart form2 = new Chart();
            form2.ShowDialog(); 
        }

        /*Launch button*/ 
        private void Launch_Click(object sender, EventArgs e)
        {
            
        }

        /*Open Chart Button*/
        private void Open_Chart_Button_Click(object sender, EventArgs e)
        {
        }


        /*Menu Strip : HELP -> About*/ 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Team Divide by Zero");   
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting().ToString();
            if (RxString == "1")
            {
                Thread.Sleep(1000);
                this.Invoke(new EventHandler(beginTest));
            }
        }

             



    }
}
