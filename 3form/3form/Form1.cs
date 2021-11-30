using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3form
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
            bool violationOfEquality = false;
            try
            {
                double Abuf = Convert.ToDouble(textBox1.Text);
                double Bbuf = Convert.ToDouble(textBox2.Text);
                if (Abuf > Bbuf)
                {
                    violationOfEquality = true;
                    throw new Exception("");
                }
                else
                {
                    int A = Convert.ToInt32(Math.Ceiling(Abuf));
                    int B = Convert.ToInt32(Bbuf);
                    if (Bbuf - B < 0)
                    {
                        B -= 1;
                    }
                    Result.Text+="\n\n\tfor:\n\t";
                    for (int i = B; i >= A; i--)
                    {
                        Result.Text += $"{i*i*i} ";
                    }

                    int j = B;
                    Result.Text += "\n\n\twhile:\n\t";
                    while (j >= A)
                    {
                        Result.Text += ($"{j*j*j} ");
                        j--;
                    }

                    j = B;
                    Result.Text += "\n\n\tdo While:\n\t";
                    do
                    {
                        Result.Text += $"{j*j*j} ";
                        j--;
                    } while (j >= A);
                }
            }
            catch (Exception) when (violationOfEquality)
            {
                Result.Text = "Нарушено равенство.\n Необходимо: A<=B";
                MessageBox.Show(
                     "Нарушено равенство. Необходимо A<=B!",
                     "Предупреждение",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button3);
                violationOfEquality = false;
            }
            catch (Exception)
            {
                Result.Text = "У одной из переменных некорректное значение"; 
                MessageBox.Show(
                      "У одной из переменных некорректное нзачение",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }
    }
}
