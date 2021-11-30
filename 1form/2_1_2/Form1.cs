using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                if (y < 12 && y > Math.Abs(x))
                {
                    Result.Text = "Точка внутри фигуры!";
                }
                else if (y == 12 || y == Math.Abs(x))
                {
                    Result.Text = "Точка на границе фигуры!";
                }
                else
                {
                    Result.Text = "Точка вне фигуры!";
                }
            }
            catch (Exception)
            {
                Result.Text = "Ошибка";
                MessageBox.Show(
                    "Одно из значений некорректно!",
                    "Предупреждение", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }
    }
}
