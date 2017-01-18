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
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        // Событие возникающее при загрузке формы
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            // Создаем объект для соединения с базой, в качестве параметра вызываем функция getConnecttoDB
            MySqlConnection myConnection = new MySqlConnection(StatClass.getConnectToDb());
            // Sql скрипт для получения информации о проекте
            MySqlCommand sqlComForSelect = new MySqlCommand(String.Format("SELECT projName, projAuthor, projInvest, " +
                "projDiscRate, incFirstY, incSecY, incThirdY, incFourthY, incFithY, paybPer, presInc, intRate, rentInc, projCurr " +
                "FROM projects WHERE projId={0}",
                        StatClass.getProjIdFMF()), myConnection);
            // Открываем соединение с БД
            myConnection.Open();
            // Создаем объект dataReader для выполнения Sql запроса, который возратит несколько значений
            MySqlDataReader datareader = sqlComForSelect.ExecuteReader();
            // Пока выполняется Sql запрос
            while (datareader.Read())
            {
                // Извлекаем в текстбоксы соответствующую информацию о проекте
                NameProjTB.Text = datareader["projName"].ToString();
                AuthProjTB.Text = datareader["projAuthor"].ToString();
                InvestProjTB.Text = datareader["projInvest"].ToString();
                DiscRateTB.Text = datareader["projDiscRate"].ToString();
                Income1YTB.Text = datareader["incFirstY"].ToString();
                Income2YTB.Text = datareader["incSecY"].ToString();
                Income3YTB.Text = datareader["incThirdY"].ToString();
                Income4YTB.Text = datareader["incFourthY"].ToString();
                Income5YTB.Text = datareader["incFithY"].ToString();
                PopTB.Text = datareader["paybPer"].ToString();
                NpvTB.Text = datareader["presInc"].ToString();
                IrrTB.Text = datareader["intRate"].ToString();
                KrfTB.Text = datareader["rentInc"].ToString();
                InvestCurrLab.Text = datareader["projCurr"].ToString();
                Y1CurrLab.Text = datareader["projCurr"].ToString();
                Y2CurrLab.Text = datareader["projCurr"].ToString();
                Y3CurrLab.Text = datareader["projCurr"].ToString();
                Y4CurrLab.Text = datareader["projCurr"].ToString();
                Y5CurrLab.Text = datareader["projCurr"].ToString();
                NPVCurrLab.Text = datareader["projCurr"].ToString();
            }
            // Как только Sql запрос завершил выполнение
            datareader.Close();
            // Закрываем соединение с БД
            myConnection.Close();
        }

        // Событие возникающее при клике на кнопку график ПОП
        private void PopBut_Click(object sender, EventArgs e)
        {
            // Показываем форму с диаграммой ПОП
            PopChartForm popCharForm = new PopChartForm();
            popCharForm.ShowDialog();
        }

        // Событие возникающее при клике на кнопку график IRR
        private void IrrBut_Click(object sender, EventArgs e)
        {
            // Показываем форму с диаграммой IRR
            IrrChartForm irrChartForm = new IrrChartForm();
            irrChartForm.ShowDialog();
        }

        // Событие возникающее клике на кнопку создать отчет
        private void ReportBut_Click(object sender, EventArgs e)
        {
            // Показываем форму отчета
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        // Событие возникающее клике на кнопку удалить проект
        private void DeleteProjBut_Click(object sender, EventArgs e)
        {
            // Выводим соответствующее сообщение
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить проект " + StatClass.getProjNameFMF() + "?", "Удаление проекта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Если юзер нажмет на да
            if (result == DialogResult.Yes)
            {
                // Sql скрипт для удаления записи из БД
                StatClass.execNonQuery(String.Format("DELETE FROM projects WHERE projId={0}",
                        StatClass.getProjIdFMF()));
                // Обнуляем ид с главной формы, ид с формы сравнения и имя проекта
                StatClass.setProjIdFMF(0);
                StatClass.setProjIdFCF(0);
                StatClass.setProjNameFMF("");
                // Закрываем текущую форму
                this.Close();
            }
        }

        // Событие возникающее клике на кнопку справка
        private void HelpBut_Click(object sender, EventArgs e)
        {
            // Показываем файл справки Help.chm
            Help.ShowHelp(this, "Help.chm");
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Обнуляем ид проекта
            StatClass.setProjIdFMF(0);
        }
    }
}
