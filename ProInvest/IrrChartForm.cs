using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProInvest
{
    public partial class IrrChartForm : Form
    {
        private double w_1; // переменная NPV для барьерной ставки = 10%
        private double w_2; // переменная NPV для барьерной ставки = 15%
        
        public IrrChartForm()
        {
            InitializeComponent();
        }

        // Функция принимает значение w_1 проекта
        private void setW_1(double w_1) 
        {
            this.w_1 = w_1;
        }

        // Функция для возращения значения w_1 проекта
        private double getW_1() 
        {
            return w_1;
        }

        // Функция принимает значение w_1 проекта
        private void setW_2(double w_2) 
        {
            this.w_2 = w_2;
        }

        // Функция для возращения значения w_1 проекта
        private double getW_2() 
        {
            return w_2;
        }

        // Событие возникающее при загрузки формы
        private void IrrChartForm_Load(object sender, EventArgs e)
        {
            // Из БД извлекаем значение стоблца w_1 выбранного проекта(ид) и записываем в переменную w_1
            setW_1(Convert.ToDouble(StatClass.getExecScalarQuery(String.Format("SELECT w_1 FROM projects WHERE projId='{0}'",StatClass.getProjIdFMF()))));
            // Из БД извлекаем значение стоблца w_2 выбранного проекта(ид) и записываем в переменную w_2
            setW_2(Convert.ToDouble(StatClass.getExecScalarQuery(String.Format("SELECT w_2 FROM projects WHERE projId='{0}'", StatClass.getProjIdFMF()))));
            // Максимальный диапазон по оси х=15
            IrrChart.ChartAreas[0].AxisX.Maximum = 15;
            // Минимальный диапазон по оси х=10
            IrrChart.ChartAreas[0].AxisX.Minimum = 10;
            // Интервал между минимальной и максимальной оси х=1
            IrrChart.ChartAreas[0].AxisX.Interval = 1;
            // Округляем максимальное значение w_1
            IrrChart.ChartAreas[0].AxisY.Maximum = Math.Round(getW_1());
            // Округляем минимальное значение w_2
            IrrChart.ChartAreas[0].AxisY.Minimum = Math.Round(getW_2());
            // Добавляем точки серии 1 значение оси х=10, значение оси y=w_1
            IrrChart.Series[0].Points.AddXY(10, getW_1());
            // Добавляем точки серии 1 значение оси х=15, значение оси y=w_2
            IrrChart.Series[0].Points.AddXY(15, getW_2());
        }
    }
}
