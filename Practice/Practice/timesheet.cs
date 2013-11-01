using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class timesheet : Form
    {
        DateTime sunstart, sunlunchstart, sunlunchend, sunend, sunextrastart, sunextraend;
        DateTime monstart, monlunchstart, monlunchend, monend, monextrastart, monextraend;
        DateTime tuestart, tuelunchstart, tuelunchend, tueend, tueextrastart, tueextraend;
        DateTime wedstart, wedlunchstart, wedlunchend, wedend, wedextrastart, wedextraend;
        DateTime thurstart, thurlunchstart, thurlunchend, thureend, thurextrastart, thurextraend;
        DateTime fristart, frilunchstart, frilunchend, friend, friextrastart, friextraend;
        DateTime satstart, satlunchstart, satlunchend, satend, satextrastart, satextraend;
        
        public timesheet()
        {
            InitializeComponent();            
        }

        

        private void suntotal_Click(object sender, EventArgs e)
        {
            
        }
             
        
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            sunstart = dt_sunstart.Value;
            sunlunchstart = dt_sunlunchstart.Value;
            sunlunchend = dt_sunlunchend.Value;
            TimeSpan sunday = sunend.Subtract(sunstart);
            TimeSpan sunlunch = sunlunchend.Subtract(sunlunchstart);
            TimeSpan sunover = sunextraend.Subtract(sunextrastart);

            TimeSpan totalsunday = sunday.Subtract(sunlunch);
            totalsunday = totalsunday.Add(sunover);
            suntotal.Text = totalsunday.ToString("hh\\:mm");

        }
    }
}
