using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            try
            {
                //mail service client
                mailService.Service1Client mailService = new mailService.Service1Client();
                //display the current email list on load
                string[] result = mailService.getMailingList();
                //close client
                mailService.Close();
                foreach (string z in result)
                {
                    emailList.AppendText(z);
                    emailList.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ERROR)
            {
                string s = ERROR.Message.ToString();
                input.Text = "";
                responseDetails.Text = s;
            }
        }

        //add an item to the email list
        private void addToList_Click(object sender, EventArgs e)
        {
            try
            {
                //mail service client
                mailService.Service1Client mailService = new mailService.Service1Client();
                //attempt to add the item and get the message
                string s = mailService.addEmail(input.Text);
                input.Text = "";
                responseDetails.Text = s;
                //refresh email list display after adding
                emailList.Text = "";
                string[] result = mailService.getMailingList();
                //close client
                mailService.Close();
                foreach (string z in result)
                {
                    emailList.AppendText(z);
                    emailList.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ERROR)
            {
                //if it failed display error
                string s = ERROR.Message.ToString();
                input.Text = "";
                responseDetails.Text = s;
            }

            
        }

        //remove item from list
        private void removeFromList_Click(object sender, EventArgs e)
        {
            try
            {
                //mail service client
                mailService.Service1Client mailService = new mailService.Service1Client();
                //attempt to remove from list and display message
                string s = mailService.removeEmail(input.Text);
                input.Text = "";
                responseDetails.Text = s;
                //refresh list display after removing item
                emailList.Text = "";
                string[] result = mailService.getMailingList();
                //close client
                mailService.Close();
                foreach (string z in result)
                {
                    emailList.AppendText(z);
                    emailList.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ERROR)
            {
                //if error display message
                string s = ERROR.Message.ToString();
                input.Text = "";
                responseDetails.Text = s;
            }

        }

        //send email action
        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                //mail service client
                mailService.Service1Client mailService = new mailService.Service1Client();
                //attempt to send email to the list
                string s = mailService.sendEmailToList(subject.Text, message.Text);
                //close client
                mailService.Close();
                //clear all text fields and display response
                input.Text = "";
                subject.Text = "";
                message.Text = "";
                responseDetails.Text = s;
            }
            catch (Exception ERROR)
            {
                //if failure display error
                string s = ERROR.Message.ToString();
                input.Text = "";
                responseDetails.Text = s;
            }
        }
    }
}
