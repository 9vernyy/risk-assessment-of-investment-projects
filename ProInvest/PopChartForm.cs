using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProInvest
{
    public partial class PopChartForm : Form
    {
        public PopChartForm()
        {
            InitializeComponent();
        }

        // Событие возникающее при загрузке формы
        private void PopChartForm_Load(object sender, EventArgs e)
        {
            double[] d = new double[6]; // Прогнозируемые доходы от проекта по годам
            double[] m = new double[6]; // Дисконтный денежный поток
            double[] o = new double[6]; // Накопленный дисконтый денеженый поток
            // Записываем в таблицу прогн. денежный поток от 1-5 года, показатели скрытых рассчетов
            StatClass.showDataToDGV(String.Format("SELECT incFirstY, incSecY, incThirdY, incFourthY, incFithY, " +
                "m_1, m_2, m_3, m_4, m_5, o_1, o_2, o_3, o_4, o_5 " + 
                "FROM projects WHERE projId={0}", StatClass.getProjIdFMF()), dataGridView1);
            // Прогнозируемые доходы от проекта от 1-5 года
            d[1] = Convert.ToDouble(dataGridView1[0,0].Value);
            d[2] = Convert.ToDouble(dataGridView1[1, 0].Value);
            d[3] = Convert.ToDouble(dataGridView1[2, 0].Value);
            d[4] = Convert.ToDouble(dataGridView1[3, 0].Value);
            d[5] = Convert.ToDouble(dataGridView1[4, 0].Value);

            // Дисконтный денежный поток от 1-5 года
            m[1] = Convert.ToDouble(dataGridView1[5, 0].Value);
            m[2] = Convert.ToDouble(dataGridView1[6, 0].Value);
            m[3] = Convert.ToDouble(dataGridView1[7, 0].Value);
            m[4] = Convert.ToDouble(dataGridView1[8, 0].Value);
            m[5] = Convert.ToDouble(dataGridView1[9, 0].Value);

            // Накопленный дисконтый денеженый поток от 1-5 года
            o[1] = Convert.ToDouble(dataGridView1[10, 0].Value);
            o[2] = Convert.ToDouble(dataGridView1[11, 0].Value);
            o[3] = Convert.ToDouble(dataGridView1[12, 0].Value);
            o[4] = Convert.ToDouble(dataGridView1[13, 0].Value);
            o[5] = Convert.ToDouble(dataGridView1[14, 0].Value);

            // Настройки серии, мин, макс, интервал оси х 
            PopChart.ChartAreas[0].AxisX.Minimum = 1;
            PopChart.ChartAreas[0].AxisX.Maximum = 5;
            PopChart.ChartAreas[0].AxisX.Interval = 1;

            for (int i = 1; i <= 5; i++)
            {
                // Для 1-ой серии, записываем точки оси х=i, точки оси y=Прогнозируемые доходы от проекта от 1-5 года
                PopChart.Series[0].Points.AddXY(i, d[i]);
                // Для 2-ой серии, записываем точки оси х=i, точки оси y=Дисконтный денежный поток от 1-5 года
                PopChart.Series[1].Points.AddXY(i, m[i]);
                // Для 3-ей серии, записываем точки оси х=i, точки оси y=Накопленный дисконтый денеженый поток от 1-5 года
                PopChart.Series[2].Points.AddXY(i, o[i]);
            }
        }
    }
}
