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


        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.RootFolder = Environment.SpecialFolder.Desktop;
            browse.Description = "Choose a directory to save your text file";
            browse.ShowNewFolderButton = false;

            if (browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter File = new StreamWriter();
                MessageBox.Show(browse.SelectedPath);
            }
        }
    }
}
