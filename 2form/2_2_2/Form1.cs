using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_2_2
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
                int countPassMonth = Convert.ToInt32(textBox1.Text);
                DateTime date = DateTime.Now;
                DateTime oldDate = date.AddMonths(-countPassMonth);
                int oldMonth = oldDate.Month;
                string oldMonthStr = "";
                switch (oldMonth)
                {
                    case 01:
                        oldMonthStr = "Январь";
                        break;
                    case 02:
                        oldMonthStr = "Февраль";
                        break;
                    case 03:
                        oldMonthStr = "Март";
                        break;
                    case 04:
                        oldMonthStr = "Апрель";
                        break;
                    case 05:
                        oldMonthStr = "Май";
                        break;
                    case 06:
                        oldMonthStr = "Июнь";
                        break;
                    case 07:
                        oldMonthStr = "Июль";
                        break;
                    case 08:
                        oldMonthStr = "Август";
                        break;
                    case 09:
                        oldMonthStr = "Сентябрь";
                        break;
                    case 10:
                        oldMonthStr = "Октябрь";
                        break;
                    case 11:
                        oldMonthStr = "Ноябрь";
                        break;
                    case 12:
                        oldMonthStr = "Декабрь";
                        break;
                }
                Otvet.Text = $"{oldMonthStr}";

            }
            catch (Exception)
            {
                Otvet.Text = "Ошибка";
                MessageBox.Show(
                      "Некорректное значение месяца!\nНеобходимо число.",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }
    }
}
