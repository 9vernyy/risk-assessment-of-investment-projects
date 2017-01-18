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
    public partial class AuthRegForm : Form
    {
        public AuthRegForm()
        {
            InitializeComponent();
        }

        // Функция для проверки логина на уникальность
        private bool isUniqueLogin() 
        {
            int count; // Переменная длч счетчика
            // Sql скрипт сравнивает каждый логин в БД с логином введенный юзером
            // Этот скрипт возращает кол-во записей удовлетворяющих условию где логин в БД равен логину введенный юзером
            // Принимаем кол-во записей возращенный скриптом Sql
            count = Convert.ToInt32(StatClass.getExecScalarQuery(String.Format("SELECT COUNT(*) FROM users WHERE userLogin='{0}'",
                       Login2TB.Text)));
            // Если кол-во записей больше 0 то
            if (count == 0)
                // Этот логин уникален
                return true;
            // Иначе он не уникален
            else return false; 
        }

        // Событие возникающее при закрытии формы регистрации/входа
        private void AuthRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // При закрытии формы, закрывает приложение
            Application.Exit();
        }

        // Событие возникающее при клике на кнопку войти
        private void SignInBut_Click(object sender, EventArgs e)
        {
            // Создаем объект главной формы
            MainForm mainForm = new MainForm();
            // создаем объект для соединения с базой, в качестве параметра вызываем функция getConnecttoDB
            MySqlConnection myConnection = new MySqlConnection(StatClass.getConnectToDb());
            // Если поля логина или пароля не заполнены то
            if (LoginTB.TextLength == 0 || PassTB.TextLength == 0)
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Одно из полей не заполнено!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Очищаем текстбоксы
                LoginTB.Clear();
                PassTB.Clear();
            }
            else
            {
                try
                {
                    // Sql скрипт для получения ид юзера. Этот скрипт сравнивает лог и пасс ввеедный юзером с записями в бд
                    MySqlCommand sqlComForId = new MySqlCommand(String.Format("SELECT userId FROM users WHERE userLogin='{0}' AND userPass='{1}'",
                        LoginTB.Text, PassTB.Text), myConnection);
                    // Открываем соединение с базой
                    myConnection.Open();
                    // Если результат sql запроса с ид не пустой
                    if (sqlComForId.ExecuteScalar() != null) {
                        // Sql скрипт для получения ид юзера. Этот скрипт сравнивает лог и пасс ввеедный юзером с записями в бд
                        StatClass.setUserId(Convert.ToInt32(StatClass.getExecScalarQuery(String.Format("SELECT userId FROM users WHERE userLogin='{0}' AND userPass='{1}'",
                        LoginTB.Text, PassTB.Text))));
                        // Sql скрипт для получения имени юзера. Этот скрипт сравнивает лог и пасс ввеедный юзером с записями в бд
                        StatClass.setUserName(StatClass.getExecScalarQuery(String.Format("SELECT userName FROM users WHERE userLogin='{0}' AND userPass='{1}'",
                        LoginTB.Text, PassTB.Text)));
                        // Sql скрипт для получения фамилии юзера. Этот скрипт сравнивает лог и пасс ввеедный юзером с записями в бд
                        StatClass.setUserSurname(StatClass.getExecScalarQuery(String.Format("SELECT userSurname FROM users WHERE userLogin='{0}' AND userPass='{1}'",
                        LoginTB.Text, PassTB.Text)));
                        // Скрываем эту форму
                        this.Hide();
                        // Показываем главную форму
                        mainForm.Show();
                    }
                    else
                    {
                        // Если нет комбинаций лога и пасса в базе выводим ошибку
                        MessageBox.Show("Вы ввели неверный логин или пароль!", "Неверный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Очищаем текстбоксы
                        LoginTB.Clear();
                        PassTB.Clear();
                    }
                }
                // Обрабатываем исключения
                catch (Exception exc)
                {
                    // Выводим сообщение исключения
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    // Закрываем соединение с базой
                    myConnection.Close();
                }
            }
        }
  
        // Событие возникающее при клике на надпись регистрации
        private void RegLab_Click(object sender, EventArgs e)
        {
            // Отображаем панель регистрации
            RegPan.Visible = true;
        }

        // Событие возникающее при наведении мыши на надпись регистрации
        private void RegLab_MouseEnter(object sender, EventArgs e) 
        {
            // Изменеяет цвет шрифта на синий
            RegLab.ForeColor = Color.DodgerBlue;
            //Изменяет курсор на Hand
            RegLab.Cursor = Cursors.Hand;
            // Изменяет стиль шрифта на подчеркнутый
            RegLab.Font = new Font(RegLab.Font, FontStyle.Underline); 
        }


        // Событие возникающее при отведении курсора от надписи регистрации
        private void RegLab_MouseLeave(object sender, EventArgs e) 
        {
            // Возращает на черный цвет
            RegLab.ForeColor = SystemColors.ControlText;
            // Возращает стиль шрифта на простой
            RegLab.Font = new Font(RegLab.Font, FontStyle.Regular); 
        }

        // Событие возникающее при клике на кнопку зарегистрироваться
        private void RegBut_Click(object sender, EventArgs e) {
            // Если поля не заполнены то
            if (NameTB.TextLength == 0 || SurNTB.TextLength == 0 || EmailTB.TextLength == 0 || Login2TB.TextLength == 0
                || Pass2TB.TextLength == 0) 
                // Выводим сообщение об ошибке
                MessageBox.Show("Одно из полей не заполнено!", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Если длина логина меньше или равна 3 символам то
            else if (Login2TB.TextLength <= 3) 
                // Выводим сообщение об ошибке
                MessageBox.Show("Логин слишком короткий!", "Некорректный логин", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Если длина пароля меньше или равна 3 символам то
            else if (Pass2TB.TextLength <= 3) 
                // Выводим сообщение об ошибке
                MessageBox.Show("Пароль слишком короткий!", "Некорректный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Если логин не уникален
            else if(isUniqueLogin()==false) 
                // То выводим сообщение о существовании такого логина
                MessageBox.Show("Такой логин уже существует!", "Некорректный логин", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Если юзер все заполнил нормально то выполняем код снизу
            else 
            {
                // наш Sql запрос для записи в базу то что ввел пользователь в текстбоксы
                StatClass.execNonQuery(String.Format("INSERT INTO users(userId, userName, userSurname, userEmail, userLogin, userPass) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}')"
                    , 0, NameTB.Text, SurNTB.Text, EmailTB.Text, Login2TB.Text, Pass2TB.Text));
                // Если юзер нажмет на Ок то
                if (MessageBox.Show("Регистрация успешно завершена!", "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // Очищаем наши текстбоксы
                    NameTB.Clear(); 
                    SurNTB.Clear();
                    EmailTB.Clear();
                    Login2TB.Clear();
                    Pass2TB.Clear();
                    // Скрываем панель регистрации
                    RegPan.Visible = false; 
                }
            }
        }

        // Событие возникающее при клике на надпись отмены
        private void CancelLab_Click(object sender, EventArgs e)
        {
            // Скрываем панель регистрации
            RegPan.Visible = false;
        }

        // Событие возникающее при наведении на надпись отмены
        private void CancelLab_MouseEnter(object sender, EventArgs e)
        {
            // Изменеяет цвет шрифта на синий
            CancelLab.ForeColor = Color.DodgerBlue;
            //Изменяет курс на Hand
            CancelLab.Cursor = Cursors.Hand;
            // Изменяет стиль шрифта на подчеркнутый
            CancelLab.Font = new Font(RegLab.Font, FontStyle.Underline);
        }

        // Событие возникающее при отведении курсора от надписи отмены
        private void CancelLab_MouseLeave(object sender, EventArgs e)
        {
            // Возращает на черный цвет
            CancelLab.ForeColor = SystemColors.ControlText;
            // Возращает стиль шрифта на простой
            CancelLab.Font = new Font(RegLab.Font, FontStyle.Regular);
        }
    }
}
// Наш статичный класс. Его создали для того чтобы, передавать ид, имя, фамилию юзера, ид и названия проектов между формами
public static class StatClass
{
    //Эти переменные статического класса
    private static int userId; // Переменная для хранения ид юзера
    private static string userName; // Переменная для хранения имени юзера
    private static string userSurname; // Переменная для хранения фамилии юзера
    private static string connStr; // Переменная для хранения строки с параметрами БД
    private static string resultOfQuery; // Переменная для хранния результата Sql запроса
    private static int projIdFMF; // Переменная для хранения ид проекта с главной формы
    private static int projIdFCF; // Переменная для хранения ид проекта с формы сравнения проектов
    private static string projNameFMF; // Переменная для хранения названия проекта с главной формы

    // Функция возращающая строку с параметрами БД
    public static string getConnectToDb() 
    {
        string serverName = "localhost"; // Адрес сервера (для локальной базы "localhost")
        string userName = "admin"; // Имя пользователя
        string dbName = "proinvestdb"; //Имя базы данных
        string port = "3306"; // Порт для подключения
        string password = "root"; // Пароль
        // Объеденяем всю информацию сверху в одну строку
        connStr = "server=" + serverName + 
            ";user=" + userName +
            ";database=" + dbName +
            ";port=" + port +
            ";password=" + password + ";";
        // И возращаем эту строку
        return connStr; 
    }

    // Функция для выполнения Sql запроса с результатом. Используется для извлечения данных из БД
    public static string getExecScalarQuery(string query) 
    {
        // Создаем объект подключения к БД, в качестве параметра вызываем функция getConnecttoDB
        MySqlConnection myConnection = new MySqlConnection(getConnectToDb());
        // Создаем объект выполнения Sql команды
        MySqlCommand sqlCom = new MySqlCommand(query, myConnection);
        // Открываем соединение с БД
        myConnection.Open();
        // Записываем результат выполнения Sql команды в переменную
        resultOfQuery = Convert.ToString(sqlCom.ExecuteScalar());
        // Закрываем соединение с БД
        myConnection.Close();
        // Возращаем резульат нашего запроса
        return resultOfQuery; 
    }

    // Функция для выполнения Sql запроса без результата. Используется для внесения или обновления данных в БД
    public static void execNonQuery(string query) 
    {
        // Создаем объект подключения к БД, в качестве параметра вызываем функция getConnecttoDB
        MySqlConnection myConnection = new MySqlConnection(getConnectToDb());
        // Создаем объект выполнения Sql команды
        MySqlCommand sqlCom = new MySqlCommand(query, myConnection);
        // Открываем соединение с БД
        myConnection.Open();
        // Выполняем Sql команду, которая ничего не возращает
        sqlCom.ExecuteNonQuery();
        // Закрываем соединение с БД
        myConnection.Close(); 
    }

    // Функция для вывода данных из БД в DataGridView(таблицу)
    public static void showDataToDGV(string selectCommand, DataGridView dataGrid) 
    {
        // Создаем объект подключения к БД, в качестве параметра вызываем функция getConnecttoDB
        MySqlConnection myConnection = new MySqlConnection(getConnectToDb()); 
        try {
            // Открываем соединение с БД
            myConnection.Open();
            // Создаем объект dataAdapter
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            // Наш dataAdapter хранит результат Sql запроса
            dataAdapter.SelectCommand = new MySqlCommand(selectCommand, myConnection);
            // Создаем объект table
            DataTable table = new DataTable();
            // Локализируем нашу таблицу
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            // Заполняем таблицу данными из нашего Sql запроса
            dataAdapter.Fill(table);
            // Создаем объект ресурса
            BindingSource bindingSource1 = new BindingSource();
            // Заполняем наш ресурс данными из таблицы
            bindingSource1.DataSource = table;
            // И выводим его в таблицу
            dataGrid.DataSource = bindingSource1;
            // Если в таблице нету проектов
            if (dataGrid.RowCount == 0)
                // Скрываем шапку таблицу
                dataGrid.ColumnHeadersVisible = false;
            // Иначе, если есть проекты в таблице
            else if(dataGrid.RowCount > 0)
                // Показываем шапку
                dataGrid.ColumnHeadersVisible = true;
        }
        catch (Exception exc)
        {
            // Выводим сообщение о необработанном исключении
            MessageBox.Show(exc.Message); 
        }
        finally
        {
            // Закрываем соединение с БД
            myConnection.Close(); 
        }
    }

    // Функция принимает значение ид юзера
    public static void setUserId(int value) 
    {
        userId = value;
    }

    // Функция для возращения ид юзера
    public static int getUserId() 
    {
        return userId;
    }

    // Функция принимает имя юзера
    public static void setUserName(string value) 
    {
        userName = value;
    }

    // Функция для возращения имени юзера
    public static string getUserName() 
    {
        return userName;
    }

    // Функция принимает фамилию юзера
    public static void setUserSurname(string value) 
    {
        userSurname = value;
    }

    // Функция для возращения фамилии юзера
    public static string getUserSurname() 
    {
        return userSurname;
    }

    // Функция принимает значение ид проекта с главной формы
    public static void setProjIdFMF(int value) 
    {
        projIdFMF = value;
    }

    // Функция для возращения ид проекта с главной формы
    public static int getProjIdFMF() 
    {
        return projIdFMF;
    }

    // Функция принимает значение ид проекта с формы сравнения проектов
    public static void setProjIdFCF(int value) 
    {
        projIdFCF = value;
    }

    // Функция возращает значение ид проекта с формы сравнения проектов
    public static int getProjIdFCF() 
    {
        return projIdFCF;
    }

    // Функция принимает название проекта с главной формы
    public static void setProjNameFMF(string value) 
    {
        projNameFMF = value;
    }

    // Функция возращает название проекта с главной формы
    public static string getProjNameFMF() 
    {
        return projNameFMF;
    }
}