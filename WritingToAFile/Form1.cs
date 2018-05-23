using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingToAFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number;

            if (int.TryParse(tBoxHowManyNum.Text,out int howManyNum))
            {
                if (sfdRandomNumber.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter outputFile;
                    outputFile = File.CreateText(sfdRandomNumber.FileName);
                    for (int i = 0; i < howManyNum; i++)
                    {
                        number = rand.Next(1, 101);
                        outputFile.WriteLine(number);
                    }
                    outputFile.Close();
                }
            }
        }
    }
}
