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
    public partial class MainForm : Form 
    {
        private bool flag=false;

        public MainForm()
        {
            InitializeComponent();
        }

        // Событие возникающее при закрытии формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AuthRegForm authRegForm = new AuthRegForm();
            // Выводим соответствующее сообщение
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти из учетной записи? ", "Выход из учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Если юзер нажал да
            if (result == DialogResult.Yes)
            {
                // То выводим окно аутентификации/регистрации
                StatClass.setProjIdFMF(0);
                StatClass.setProjIdFCF(0);
                StatClass.setProjNameFMF("");
                authRegForm.Show();
            }
            // Если юзер нажал нет
            else if (result == DialogResult.No)
                // То отменяем событие закрытии формы
                e.Cancel = true;
        }

        // Событие возникающее при загрузке формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Выводим фамилию и имя юзера из БД в Label
            UserNSLab.Text = "Вы вошли как " + StatClass.getUserSurname() + " " + StatClass.getUserName();
            // Выводим в таблицу информацию о проекте: Имя, автора, инвестиции, ставку проекта
            StatClass.showDataToDGV(String.Format("SELECT projId, projName, projAuthor, projInvest, projDiscRate FROM projects WHERE userId={0}", StatClass.getUserId()), dataGridView1);
            // Устанавливаем ширину 60 для столбца ид проекта
            dataGridView1.Columns[0].Width = 60;
            // Устанавливаем ширину 135 для столбца имя проекта
            dataGridView1.Columns[1].Width = 135;
            // Устанавливаем ширину 135 для столбца автора проекта
            dataGridView1.Columns[2].Width = 135;
            // Устанавливаем ширину 95 для столбца инвестиции проекта
            dataGridView1.Columns[3].Width = 95;
            // Устанавливаем ширину 94 для столбца ставка проекта
            dataGridView1.Columns[4].Width = 94;
            // Устанавливаем соответствующие имена столбцов проекта
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Название проекта";
            dataGridView1.Columns[2].HeaderText = "Инициатор проекта";
            dataGridView1.Columns[3].HeaderText = "Требуемые вложения";
            dataGridView1.Columns[4].HeaderText = "Ставка дисконта";
            dataGridView1.ClearSelection();
            // Отключаем сортировку таблицы
            foreach(DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            // Снимаем выделения с таблицы
            //dataGridView1.ClearSelection();
        }

        // Событие возникающее при активации формы
        private void MainForm_Activated(object sender, EventArgs e)
        {
            // Выводим в таблицу информацию о проекте: Имя, автора, инвестиции, ставку проекта
            StatClass.showDataToDGV(String.Format("SELECT projId, projName, projAuthor, projInvest, projDiscRate FROM projects WHERE userId={0}", StatClass.getUserId()), dataGridView1);
            // Снимаем выделения с таблицы
            dataGridView1.ClearSelection();
            // Обнуляем ид с главной формы, ид с формы сравнения и имя проекта
            //StatClass.setProjIdFMF(0);
            //StatClass.setProjIdFCF(0);
            //StatClass.setProjNameFMF("");
        }  

        // Событие возникающее при клике по записи в таблице
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Записываем ид выбранного проекта
            StatClass.setProjIdFMF(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            // Записываем имя выбранного проекта
            StatClass.setProjNameFMF(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        // Событие возникающее при клике по шапке таблицы
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Обнуляем ид и имя проекта с главной формы
            StatClass.setProjIdFMF(0);
            StatClass.setProjNameFMF("");
            // Снимаем выделения с таблицы
            dataGridView1.ClearSelection();
        }

        // Событие возникающее при клике на кнопку cоздать проект
        private void CreateProjBut_Click(object sender, EventArgs e)
        {
            // Делает видимым панель создания нового проекта
            NewProjPan.Visible = true;
            label2.Text = "Создание нового проекта. Заполните все поля!";
            // Меняет название кнопки
            SaveBut.Text = "Создать";
            // Меняет заголовок формы
            this.Text = "Создание нового проекта";
        }

        // Событие возникающее при клике на кнопку открыть проект
        private void OpenProjBut_Click(object sender, EventArgs e)
        {
            ProjectForm projForm = new ProjectForm();
            // Если пользователь выбрал хоть один проект в таблице
            if (StatClass.getProjIdFMF() > 0)
            {
                // Отображаем форму проекта
                projForm.Text = "Проект " + StatClass.getProjNameFMF();
                projForm.ShowDialog();
            }
        }

        // Событие возникающее при клике на кнопку удалить проект
        private void DeleteProjBut_Click(object sender, EventArgs e)
        {
            // Если пользователь выбрал хоть один проект в таблице
            if (StatClass.getProjIdFMF() > 0)
            {
                // То выводим сообщение о намерении удалить проект
                DialogResult result = MessageBox.Show("Вы уверены что хотите удалить проект " + StatClass.getProjNameFMF() + "?", "Удаление проекта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Если пользователь нажал на кнопку да, в сообщении
                if (result == DialogResult.Yes)
                {
                    // Sql скрипт для удаления записи из БД
                    StatClass.execNonQuery(String.Format("DELETE FROM projects WHERE projId={0}",
                            StatClass.getProjIdFMF()));

                    // Выводим в таблицу все проекты, кроме удаленного
                    StatClass.showDataToDGV(String.Format("SELECT projId, projName, projAuthor, projInvest, projDiscRate FROM projects WHERE userId={0}", StatClass.getUserId()), dataGridView1);
                    // Снимаем выделения с таблицы
                    dataGridView1.ClearSelection();
                    // Обнуляем ид с главной формы, ид с формы сравнения и имя проекта
                    StatClass.setProjIdFMF(0);
                    StatClass.setProjIdFCF(0);
                    StatClass.setProjNameFMF("");
                }
                else
                    // Обнуляем ид с главной формы, ид с формы сравнения и имя проекта
                    StatClass.setProjIdFMF(0);
            }
        }

        // Событие возникающее при клике на кнопку сравнить проект
        private void CompareProjBut_Click(object sender, EventArgs e)
        {
            // Если пользователь выбрал хоть один проект в таблице
            if (StatClass.getProjIdFMF() > 0)
            {
                // Отображаем форму сравнения проектов
                CompareForm compareForm = new CompareForm();
                compareForm.Text = "Сравнение проекта " + StatClass.getProjNameFMF() + " с";
                compareForm.ShowDialog();
            }
        }

        // Событие возникающее при клике на кнопку изменить проект
        private void ChangeProjBut_Click(object sender, EventArgs e)
        {
            // Если пользователь выбрал хоть один проект в таблице
            if (StatClass.getProjIdFMF() > 0)
            {
                // Создаем объект для соединения с базой, в качестве параметра вызываем функция getConnecttoDB
                MySqlConnection myConnection = new MySqlConnection(StatClass.getConnectToDb());
                // Sql скрипт для получения вышеуказанных столбцов из БД и внесения их в TextBox'ы панели изменения проекта
                MySqlCommand sqlComForSelect = new MySqlCommand(String.Format("SELECT projName, projAuthor, projInvest, " +
                    "projDiscRate, incFirstY, incSecY, incThirdY, incFourthY, incFithY, projCurr FROM projects WHERE projId={0}",
                            StatClass.getProjIdFMF()), myConnection);
                // Открываем соединение с БД
                myConnection.Open();
                // Создаем объект dataReader для выполнения Sql запроса, который возратит несколько значений
                MySqlDataReader datareader = sqlComForSelect.ExecuteReader();
                // Пока выполняется Sql запрос
                while (datareader.Read())
                {
                    // Извлекаем в текстбоксы соответствующую информацию о проекте
                    NameProjTB2.Text = datareader["projName"].ToString(); ;
                    AuthProjTB2.Text = datareader["projAuthor"].ToString();
                    InvestTB.Text = datareader["projInvest"].ToString();
                    DiscRateTB.Text = datareader["projDiscRate"].ToString();
                    Income1YTB.Text = datareader["incFirstY"].ToString();
                    Income2YTB.Text = datareader["incSecY"].ToString();
                    Income3YTB.Text = datareader["incThirdY"].ToString();
                    Income4YTB.Text = datareader["incFourthY"].ToString();
                    Income5YTB.Text = datareader["incFithY"].ToString();
                    CurrCB.Text = datareader["projCurr"].ToString();
                    Y1Lab.Text = datareader["projCurr"].ToString();
                    Y2Lab.Text = datareader["projCurr"].ToString();
                    Y3Lab.Text = datareader["projCurr"].ToString();
                    Y4Lab.Text = datareader["projCurr"].ToString();
                    Y5Lab.Text = datareader["projCurr"].ToString();
                }
                // Как только Sql запрос завершил выполнение
                datareader.Close();
                // Закрываем соединение с БД
                myConnection.Close();
                flag = true;
                // Отображаем панель изменения проекта
                NewProjPan.Visible = true;
                label2.Text = "Изменение проекта " + StatClass.getProjNameFMF() + ". Заполните все поля!";
                SaveBut.Text = "Изменить";
                this.Text = "Изменение проекта " + StatClass.getProjNameFMF();
            }
        }

        // Событие возникающее при клике на кнопку о программе
        private void AboutProjAuthBut_Click(object sender, EventArgs e)
        {
            // Отображаем форму с информацией о проекте
            AboutProgAuth about = new AboutProgAuth();
            about.ShowDialog();
        }

        // Событие возникающее при клике на кнопку справка
        private void HelpBut_Click(object sender, EventArgs e)
        {
            // Открываем файл Help.chm
            Help.ShowHelp(this, "Help.chm");

        }

        // Событие возникающее при клике на надпись выход
        private void ExitFromAccLab_Click(object sender, EventArgs e)
        {
            // Закрываем эту форму
            this.Close();

        }

        // Cобытие возникающее при наведении на надпись выход
        private void ExitFromAcc_MouseEnter(object sender, EventArgs e) 
        {
            // Изменеяет цвет шрифта на синий
            ExitFromAccLab.ForeColor = SystemColors.HotTrack;
            //Изменяет курс на Hand
            ExitFromAccLab.Cursor = Cursors.Hand;
            // Изменяет стиль шрифта на подчеркнутый
            ExitFromAccLab.Font = new Font(ExitFromAccLab.Font, FontStyle.Underline); 
        }

        // Событие возникающее при отведении курсора от надписи выхода
        private void ExitFromAccLab_MouseLeave(object sender, EventArgs e) 
        {
            // Возращает на черный цвет
            ExitFromAccLab.ForeColor = SystemColors.ControlText;
            // Возращает стиль шрифта на простой
            ExitFromAccLab.Font = new Font(ExitFromAccLab.Font, FontStyle.Regular); 
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void InvestTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                // То не даем пользователю вводить в текстбокс что то крое цифр
                e.Handled = true;
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void DiscRateTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void Income1YTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void Income2YTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void Income3YTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void Income4YTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Textbox
        private void Income5YTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // По таблице ASCII символам от 0 до 9 эквивалентны 48-57 включительно. Для Backspace эквивалент 8.
            // Если пользоваель введет что то кроме цифр
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)

                e.Handled = true; // То не даем пользователю вводить в текстбокс что то крое цифр
        }

        // Событие возникающее при попытке ввести что нибудь в Combobox
        private void CurrCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Не даем юзеру вводить что нибудь в Combobox, т.к ему дается возможность выбрать валюту из списка
            e.Handled = true;
        }

        // Событие возникающее при выбооре валюты из выпадающего спика
        private void CurrCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Присваиваем всем Label ту валюту, которую выбрал юзер
            Y1Lab.Text = CurrCB.Text;
            Y2Lab.Text = CurrCB.Text;
            Y3Lab.Text = CurrCB.Text;
            Y4Lab.Text = CurrCB.Text;
            Y5Lab.Text = CurrCB.Text;
        }

        // Событие возникающее при клике на кнопку создать проект
        private void SaveBut_Click(object sender, EventArgs e)
        {
            double J; // Размер инвестиций проекта
            double[] d = new double[6]; // Прогнозируемые доходы от проекта по годам
            double s; // Ставка дисконта
            double p; // Период окупаемости проекта
            double w; // Чистый приведенный доход проекта
            double q; // Внутрення норма доходности проекта
            double v; // Рентабельность проекта
            int i; // Шаг
            double sum; // Сумма
            int r; // Года
            double[] m = new double[6]; // Дисконтный денежный поток
            double[] o = new double[6]; // Накопленный дисконтый денеженый поток
            double spd; // Суммарный приведенный доход проекта
            double b1; // Барьерная ставка 1
            double b2; // Барьерная ставка 2
            double w1; // Чистый приведенный доход проекта по 1-ой барьерной ставке
            double w2; // Чистый приведенный доход проекта по 2-ой барьерной ставке
            double[] m1 = new double[6]; // Дисконтный денежный поток по 1-ой барьерной ставке
            double[] m2 = new double[6]; // Дисконтный денежный поток по 2-ой барьерной ставке
            double spd1 = 0; // Суммарный приведенный доход проекта по 1-ой барьерной ставке
            double spd2 = 0; // Суммарный приведенный доход проекта по 2-ой барьерной ставке
            
            //Проверка целостности заполнения полей
            if (NameProjTB2.Text == "" || AuthProjTB2.Text == "" || InvestTB.Text == ""
                || DiscRateTB.Text == "" || Income1YTB.Text == "" || Income2YTB.Text == ""
                || Income3YTB.Text == "" || Income4YTB.Text == "" || Income5YTB.Text == "" || CurrCB.Text == "")
                MessageBox.Show("Одно из полей не заполнено!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Нахождение периода окупаемости проекта
                // Года=5
                r=5;
                // Размер инвестиций проекта=ивестции требуемые проектом = Инвестиции требуемые проектом
                J=Convert.ToDouble(InvestTB.Text);
                // Ставка дисконта = (дисконтная ставка)/100
                s=(Convert.ToDouble(DiscRateTB.Text))/100;
                // Накопленный дисконтый денеженый поток[0] = 0-Размер инвестиций проекта
                o[0]=0-J;
                // Суммарный приведенный доход проекта = 0
                spd=0;
                // Заполняем прогнозируемые доходы от проекта по годам значениями прогнозируемого дохода от 1го до 5го года
                d[1]= Convert.ToDouble(Income1YTB.Text);
                d[2]= Convert.ToDouble(Income2YTB.Text);
                d[3]= Convert.ToDouble(Income3YTB.Text);
                d[4]= Convert.ToDouble(Income4YTB.Text);
                d[5]= Convert.ToDouble(Income5YTB.Text);

                // Запускаем цикл от 1 до 5
                for(int j=1; j<=r; j++) 
                {
                    // Дисконтный денежный поток[j] = Прогнозируемые доходы от проекта по годам[j]/Exp(j-ый элемент*Ln(1+s)
                    m[j]=d[j]/(Math.Exp(j*Math.Log(1+s)));
                    // Накопленный дисконтый денеженый поток[j]= предыдущий накопленный дисконтый денеженый поток[j-1]
                    //+ Дисконтный денежный поток[j]
                    o[j]=o[j-1]+m[j];
                    // Суммарный приведенный доход проекта = предыдущий суммарный приведенный доход проекта + Дисконтный денежный поток[j]
                    spd=spd+m[j];
                }
                // Сумма = Накопленный дисконтый денеженый поток[1]
                sum=m[1];
                // Шаг=1
                i=1;
                // Пока Размер инвестиций проекта=ивестции требуемые проектом > Суммы
                while(J>sum) {
                    // Увеличиваем шаг на 1
                    i++;
                    // Сумма = Предыдущая сумма + Дисконтный денежный поток[i]
                    sum=sum+m[i];
                }
                // Период окупаемости проекта
                p = (i - 1) + o[i - 1] / m[i]; 
                
                // Нахождение чистого приведенного дохода
                // Чистый приведенный доход проекта
                w = spd - J;
                
                // Нахождение внутренней нормы доходности(коэффицент внутренней окуапемости)
                // Барьерная ставка 1 = 10
                b1=10;
                // Барьерная ставка 2 = 15
                b2=15;

                // Запускаем цикл от 1 до 5
                for (int j=1; j<=r; j++) 
                {
                    // Дисконтный денежный поток по 1-ой барьерной ставке = прогнозируемые доходы от проекта по годам
                    // / (Exp(j*Ln(1+(Барьерная ставка 1/100))
                    m1[j]=d[j]/(Math.Exp(j*Math.Log(1+(b1/100))));
                    // Дисконтный денежный поток по 2-ой барьерной ставке = прогнозируемые доходы от проекта по годам
                    // / (Exp(j*Ln(1+(Барьерная ставка 2/100))
                    m2[j]=d[j]/(Math.Exp(j*Math.Log(1+(b2/100))));
                    // Суммарный приведенный доход проекта по 1-ой барьерной ставке = 
                    // Предыдущий суммарный приведенный доход проекта по 1-ой барьерной ставке / Накопленный дисконтый денеженый поток[j]
                    spd1+=m1[j];
                    // Суммарный приведенный доход проекта по 2-ой барьерной ставке = 
                    // Предыдущий суммарный приведенный доход проекта по 2-ой барьерной ставке / Накопленный дисконтый денеженый поток[j]
                    spd2+=m2[j];
                }

                // Чистый приведенный доход проекта по 1-ой барьерной ставке = Суммарный приведенный доход проекта по 1-ой барьерной ставке
                // - Размер инвестиций проекта
                w1=spd1-J;
                // Чистый приведенный доход проекта по 2-ой барьерной ставке = Суммарный приведенный доход проекта по 2-ой барьерной ставке
                // - Размер инвестиций проекта
                w2=spd2-J;
                // Внутрення норма доходности проекта
                q=b1+(b2-b1)*w1/(w1-w2);
                
                // Нахождение коэффицента рентабельности проекта
                // Коэффицент рентабельности проекта
                v=(w/J)*100;
                
                // Если инветиции, дисконтная ставка, прогнозируемый доход, период окупаемости, чистый приведенный доход,
                // Внутрення норма доходности и коэффицент рентабельности проекта меньше 0
                if (Convert.ToDouble(InvestTB.Text) < 0 || Convert.ToDouble(DiscRateTB.Text) < 0 || Convert.ToDouble(DiscRateTB.Text) > 100
                    || Convert.ToDouble(Income1YTB.Text) < 0 || Convert.ToDouble(Income2YTB.Text) < 0
                    || Convert.ToDouble(Income3YTB.Text) < 0 || Convert.ToDouble(Income4YTB.Text) < 0
                    || Convert.ToDouble(Income5YTB.Text) < 0 || p < 0 || w < 0 || q < 0 || v < 0)
                    // То выводим соответствующее сообщение
                    MessageBox.Show("Данные значения не допустимы для рассчета!", "Недопустимые значения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Если пользователь нажал на кнопку изменения проекта
                    if (flag == true)
                    {
                        // То записываем обновленные данные в БД
                        StatClass.execNonQuery(String.Format("UPDATE projects SET projName='{0}', projAuthor='{1}', " +
                            "projInvest='{2}', projDiscRate='{3}', incFirstY='{4}', incSecY='{5}', incThirdY='{6}', " +
                            "incFourthY='{7}', incFithY='{8}', paybPer='{9}', presInc='{10}', intRate='{11}', rentInc='{12}', m_1='{13}', " +
                            "m_2='{14}', m_3='{15}', m_4='{16}', m_5='{17}', o_1='{18}', o_2='{19}', o_3='{20}', o_4='{21}', o_5='{22}', " +
                            "sum_m='{23}', w_1='{24}', w_2='{25}', projCurr='{26}' WHERE projId={27}"
                        , NameProjTB2.Text, AuthProjTB2.Text, InvestTB.Text, DiscRateTB.Text, Income1YTB.Text,
                        Income2YTB.Text, Income3YTB.Text, Income4YTB.Text, Income5YTB.Text, p.ToString("0.0"),
                        w.ToString("0.00"), q.ToString("0.00"), v.ToString("0.00"), m[1].ToString("0.00"),
                        m[2].ToString("0.00"), m[3].ToString("0.00"), m[4].ToString("0.00"), m[5].ToString("0.00"),
                        o[1].ToString("0.00"), o[2].ToString("0.00"), o[3].ToString("0.00"), o[4].ToString("0.00"),
                        o[5].ToString("0.00"), sum.ToString("0.00"), w1.ToString("0.00"), w2.ToString("0.00"), CurrCB.Text, StatClass.getProjIdFMF()));
                        flag = false;
                        // Выводим сообщение о успешном изменении проекта
                        DialogResult result = MessageBox.Show("Проект " + NameProjTB2.Text + " успешно изменен!", "Изменение проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Если пользователь нажмет ОК в окне сообщения
                        if(result == DialogResult.OK)
                        // Скрываем панель изменения проекта
                        NewProjPan.Visible = false;
                    }
                    // Если пользователь нажал на создание нового проекта
                    else if (flag == false)
                    {
                        // То записываем данные в БД
                        StatClass.execNonQuery(String.Format("INSERT INTO projects(projId, userId, " +
                            "projName, projAuthor, projInvest, projDiscRate, incFirstY, incSecY, incThirdY, " +
                            "incFourthY, incFithY, paybPer, presInc, intRate, rentInc, m_1, m_2, m_3, m_4, m_5, " +
                            "o_1, o_2, o_3, o_4, o_5, sum_m, w_1, w_2, projCurr)" +
                            " VALUES({0}, {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}'," +
                            "'{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}'," +
                            "'{23}', '{24}', '{25}', '{26}', '{27}', '{28}')"
                        , 0, StatClass.getUserId(), NameProjTB2.Text, AuthProjTB2.Text, InvestTB.Text, DiscRateTB.Text, Income1YTB.Text,
                        Income2YTB.Text, Income3YTB.Text, Income4YTB.Text, Income5YTB.Text, p.ToString("0.0"),
                        w.ToString("0.00"), q.ToString("0.00"), v.ToString("0.00"), m[1].ToString("0.00"),
                        m[2].ToString("0.00"), m[3].ToString("0.00"), m[4].ToString("0.00"), m[5].ToString("0.00"),
                        o[1].ToString("0.00"), o[2].ToString("0.00"), o[3].ToString("0.00"), o[4].ToString("0.00"),
                        o[5].ToString("0.00"), sum.ToString("0.00"), w1.ToString("0.00"), w2.ToString("0.00"), CurrCB.Text));
                        // Выводим сообщение о успешном создании проекта
                        DialogResult result = MessageBox.Show("Проект " + NameProjTB2.Text + " успешно создан!", "Создание проекта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Если пользователь нажмет ОК в окне сообщения
                        if (result == DialogResult.OK)
                            // Скрываем панель создания проекта
                            NewProjPan.Visible = false;
                    }
                    // Устанавливаем название окна(отображается сверху)
                    this.Text = "ProInvest";
                    // Выводим данные о проекте в таблицу
                    StatClass.showDataToDGV(String.Format("SELECT projId, projName, projAuthor, projInvest, projDiscRate FROM projects WHERE userId={0}", StatClass.getUserId()), dataGridView1);
                    // Снимаем выделения с таблицы
                    dataGridView1.ClearSelection();
                    // Обнуляем ид проекта
                    StatClass.setProjIdFMF(0);
                }
            }

            // Очищаем текстбоксы
            NameProjTB2.Clear();
            AuthProjTB2.Clear();
            InvestTB.Clear();
            DiscRateTB.Clear();
            Income1YTB.Clear();
            Income2YTB.Clear();
            Income3YTB.Clear();
            Income4YTB.Clear();
            Income5YTB.Clear();
            // Очищаем комбобокс
            CurrCB.Text = "";
            // Очищаем надписи
            Y1Lab.Text = "";
            Y2Lab.Text = "";
            Y3Lab.Text = "";
            Y4Lab.Text = "";
            Y5Lab.Text = "";
        }

        // Событие возникающее при клике на Label отмены
        private void CancelLab_Click(object sender, EventArgs e)
        {
            // Скрываем панель создания проекта
            NewProjPan.Visible = false;
            // Очищаем текстбоксы
            NameProjTB2.Clear();
            AuthProjTB2.Clear();
            InvestTB.Clear();
            DiscRateTB.Clear();
            Income1YTB.Clear();
            Income2YTB.Clear();
            Income3YTB.Clear();
            Income4YTB.Clear();
            Income5YTB.Clear();
            // Очищаем комбобокс
            CurrCB.Text = "";
            // Очищаем надписи
            Y1Lab.Text = "";
            Y2Lab.Text = "";
            Y3Lab.Text = "";
            Y4Lab.Text = "";
            Y5Lab.Text = "";
            // Устанавливаем название окна(отображается сверху)
            this.Text = "ProInvest";
            flag = false;
            // Обнуляем ид проекта
            StatClass.setProjIdFMF(0);
            // Снимаем выделения с таблицы
            dataGridView1.ClearSelection();
        }

        // Событие возникающее при наведении на Label отмены
        private void CancelLab_MouseEnter(object sender, EventArgs e)
        {
            // Изменеяет цвет шрифта на синий
            CancelLab.ForeColor = SystemColors.HotTrack;
            //Изменяет курс на Hand
            CancelLab.Cursor = Cursors.Hand;
            // Изменяет стиль шрифта на подчеркнутый
            CancelLab.Font = new Font(CancelLab.Font, FontStyle.Underline);
        }

        // Событие возникающее при отведении курсора от Label отмены
        private void CancelLab_MouseLeave(object sender, EventArgs e)
        {
            // Возращает на черный цвет
            CancelLab.ForeColor = SystemColors.ControlText;
            // Возращает стиль шрифта на простой
            CancelLab.Font = new Font(CancelLab.Font, FontStyle.Regular);
        }
    }
}
