using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(705, 480);
        }

        /// <summary>
        /// Обработчик кнопки "Построить"
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            //Переменные для построения графика
            double begin = 0.1, end = 0, shag = 0;
            double x, y;

            //Отлов исключения неверного формата ввода
            try
            {
                begin = Convert.ToDouble(a.Text);
                end = Convert.ToDouble(b.Text);
                shag = Convert.ToDouble(step.Text);
            }
            catch(FormatException mes)
            {
                MessageBox.Show(mes.Message);
            }

            //Проверка на синтаксис
            if (begin >= end)
                MessageBox.Show("Начальное значение должно быть меньше конечного!", "Ошибка синтаксиса", MessageBoxButtons.OKCancel);

            
            this.chart1.Series[0].Points.Clear();
            x = begin;

            //Построение графика
            while(x <= end)
            {
                y = Math.Cos(x) * Math.Cos(x) + Math.Tan(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += shag;
            }
        }
    }
}
