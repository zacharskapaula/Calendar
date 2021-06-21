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
    public partial class EventCreationDialog : Form
    {
       
        public Event CreatedEvent { get; set; }
        private DateTime _eventDate;
        public EventCreationDialog(DateTime date)
        {
            CreatedEvent = null;
            _eventDate = date;
            InitializeComponent();
        }
    
        private void OnOkClick(object sender, EventArgs e)
        {
            CreatedEvent = new Event { Title = txtBoxTitle.Text, Description = txtBoxDescription.Text, Date = _eventDate };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
