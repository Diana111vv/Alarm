using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            Program.alarm = this;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_alarm add_Alarm = new Add_alarm();
            add_Alarm.Show();
        }
    }
}
