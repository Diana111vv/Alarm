using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Add_alarm : Form
    {
        public Add_alarm()
        {
            InitializeComponent();
            Program.add_Alarm = this;
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.alarm.rtbname.Text = textBox1.Text;
            Program.alarm.tbtime.Text = maskedTextBox1.Text;
                GroupBox mygroupbox = new GroupBox();

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is GroupBox)
                    {
                        GroupBox gbx = (GroupBox)ctrl;
                        mygroupbox = gbx;
                        break;
                    }
                }
                this.Controls.Add(mygroupbox);
            Close();
        }

        
    }
}
