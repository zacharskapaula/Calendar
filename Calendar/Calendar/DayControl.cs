using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DayControl : UserControl
    {
        public DateTime _date;
        public DateTime Date    
        {
            get => _date;
            set
            {
                _date = value;
                dayUserControl.Text = _date.ToString();
            }
        }

        

        public DayControl()
        {


            InitializeComponent();



        }
   
         

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
