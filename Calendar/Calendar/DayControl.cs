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
        public event EventHandler DayClicked;
        public DayControl()
        {   
            InitializeComponent();
        }
        
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

        public void ClearSelection()
        {
            BackColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DayControl_Load(object sender, EventArgs e)
        {

        }

        private void DayControl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void DayControl_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.White;
            DayClicked?.Invoke(this, new EventArgs());

        }
    }
}
