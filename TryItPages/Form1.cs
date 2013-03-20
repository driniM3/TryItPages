using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace TryItPages
{
    public partial class Form1 : Form
    {
        
        


        public Form1()
        {
            InitializeComponent();
            
            
        }

        //get top 10 words on a webpage
        private void getTopTen_Click(object sender, EventArgs e)
        {
            

            urlResult.Text = "";
            try
            {
                //service clients to be used
                TopTenWords.Service1Client top10 = new TopTenWords.Service1Client();
                //attempt to get top ten words on a webpage and display them
                string[] result = top10.topTenWords(topTenUrl.Text);
                top10.Close();

                for (int i = 0; i < result.Length; i++)
                {
                    urlResult.AppendText(result[i]);
                    urlResult.AppendText(Environment.NewLine);

                }
            }
            catch (Exception ERROR)
            {
                //if failed display error
                urlResult.Text = ERROR.Message.ToString();
            }
        }

        private void getWordFilter_Click(object sender, EventArgs e)
        {
            try
            {
                //service clients to be used
                WordFilter.Service1Client wordFilter = new WordFilter.Service1Client();
                Web2Strings.ServiceClient web2Strings = new Web2Strings.ServiceClient();
                urlResult.Text = "";
                //get html source using web2strings
                string toFilter = web2Strings.GetWebContent(topTenUrl.Text); 
                //filter using wordfilter
                toFilter = wordFilter.WordFilter(toFilter);
                //close clients
                wordFilter.Close();
                web2Strings.Close();
                urlResult.Text = toFilter;
                
            }
            catch (Exception ERROR)
            {
                //if failed display error
                urlResult.Text = ERROR.Message.ToString();
            }
            

        }
    }
}
