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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Переменные для построения графика
            double begin = Convert.ToDouble(a.Text);
            double end = Convert.ToDouble(b.Text);
            double shag = Convert.ToDouble(step.Text);
            double x, y;

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
