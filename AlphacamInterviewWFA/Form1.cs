using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * 
 * 
 */
namespace AlphacamInterviewWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /*
         * 
         * 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.RootFolder = Environment.SpecialFolder.Desktop;
            browse.Description = "Choose a directory to save your text file";
            browse.ShowNewFolderButton = false;


            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(browse.SelectedPath, "1000numbers.txt")))
                {
                    Random randomNumber = new Random();
                    int count = 0;
                   
                    outputFile.Write("1000 random numbers" + Environment.NewLine);
                    outputFile.Write(Environment.NewLine);
                    while (count<=1000)
                    {
                        int temp = randomNumber.Next(0, 10000);                          
                        if (temp % 3 != 0 && temp % 10 != 3)
                        {
                            outputFile.Write("{0:N0}", temp + Environment.NewLine);
                            count++;
                        }
                    }
                }

                    MessageBox.Show("1000numbers.txt generated in: " + browse.SelectedPath);
  
            }
        }
    }
}
