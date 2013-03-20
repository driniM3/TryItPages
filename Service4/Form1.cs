using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service4
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        //
        private void sort_Click(object sender, EventArgs e)
        {
            try
            {
                //client to be used
                QuickSort.Service1Client quickSort = new QuickSort.Service1Client();
                //declare the array the size of the number of lines entered
                string[] result = new string[toBeSorted.Lines.Length];
                //initiate the array with each line of the input
                int i = 0;
                foreach (string line in toBeSorted.Lines)
                {
                    result[i] = line;
                    i++;
                }

                //sort using the quicksort client
                result = quickSort.quickSortArray(result);
                //close client
                quickSort.Close();
                //reset text fields
                toBeSorted.Text = "";
                resultBox.Text = "";
                //add results to results
                foreach (string s in result)
                {
                    resultBox.AppendText(s + ", ");
                }
            }
            catch (Exception ERROR)
            {
                //if there is an error display it
                resultBox.AppendText(ERROR.Message.ToString());
            }
        }
    }
}
