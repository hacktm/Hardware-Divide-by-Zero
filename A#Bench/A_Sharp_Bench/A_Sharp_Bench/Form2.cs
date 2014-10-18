using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Sharp_Bench
{
    public partial class Chart : Form
    {
        /**/
        

        public Chart()
        {
            InitializeComponent();
        }


        /*Load Chart Button*/ 
        private void Load_Chart_Button_Click(object sender, EventArgs e)
        {
            CPU_Chart.Series["Time"].Points.AddXY("Intel Core i5 - 4200u", 102946);
            CPU_Chart.Series["Time"].Points.AddXY("AMD FX-8320", 93617);
            CPU_Chart.Series["Time"].Points.AddXY("Core i7 - 4770k", 82989);
            CPU_Chart.Series["Time"].Points.AddXY("YOUR CPU", A_Sharp_Bench.Total_Time);  
        }

        

    }
}
