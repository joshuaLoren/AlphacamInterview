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
 *    This WPF will save a text file with 1000 randomly generated integers 
 *    to a directory of the user's choosing. The integers generated will be
 *    between 0 and 100,000 and will not be divisible by 3 and does not end in 3.
 */
namespace AlphacamInterviewWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         *    Allows the user to select a directory. Once a 
         *    directory is selected a text file will be generated and 
         *    a dialogue box will show the user where their text file was 
         *    saved.
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.RootFolder = Environment.SpecialFolder.Desktop;
            browse.Description = "Choose a directory to save your text file";
            browse.ShowNewFolderButton = false;

            //If the user selects a directory
            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(browse.SelectedPath, "1000numbers.txt")))
                {
                    Random randomNumber = new Random();
                    int count = 1;

                    outputFile.Write("1000 random numbers" + Environment.NewLine);
                    outputFile.Write(Environment.NewLine);

                    //Only increment the counter if the random number generated is not
                    //divisble by 3 and does not end in 3.
                    while (count <= 1000)
                    {
                        int temp = randomNumber.Next(0, 100000);
                        //if temp % 3 != then the random number is not divisble by 3, or
                        //if temp # 10 != 3 then the last digit is not the number 3
                        if (temp % 3 != 0 && temp % 10 != 3)
                        {
                            outputFile.Write("{0:N0}", count + " " + temp + Environment.NewLine);
                            count++;
                        }
                    }
                }
                MessageBox.Show("1000numbers.txt generated in: " + browse.SelectedPath);
            }
        }

  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
