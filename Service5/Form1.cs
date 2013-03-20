using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            //time zone client for the service
            TimeZones.Service1Client timeClient = new TimeZones.Service1Client();
            InitializeComponent();
            //display the current time at the current location
            result.Text = "The current date and time is: " + DateTime.Now + ".";
            string[] zones = timeClient.getTimeZones();
            //close client
            timeClient.Close();
            foreach (string m in zones)
                timeZones.Items.Add(m);
        }

        private void getTime_Click(object sender, EventArgs e)
        {

            string s;
            try
            {
                //time zone client for the service
                TimeZones.Service1Client timeClient = new TimeZones.Service1Client();
                //try and get the time at the selected time zone and store it in s
                s = String.Format("The date and time of the {0} time zone are {1}", timeZones.SelectedItem.ToString(),
                    timeClient.getTimeIn(timeZones.SelectedItem.ToString()));
                timeClient.Close();
                
                
                
            }
            catch (Exception ERROR)
            {
                //if it fails display error message
                s = ERROR.Message.ToString();
            }

            result.Text = s;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
