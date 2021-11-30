using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            for (int i = 7; i > 2; i--)
            {
                for (int j = 0; j < 8 - i; j++)
                {
                    Result.Text+= i + " ";
                }
                Result.Text +="\n";
            }
        }
    }
}
