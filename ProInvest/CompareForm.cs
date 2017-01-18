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
using Word = Microsoft.Office.Interop.Word;

namespace ProInvest
{
    public partial class CompareForm : Form
    {
        private Word.Application wordApp; // Переменная для Word программы
        // Переменная шага. По результату этой переменной мы определяем какой из показетей 1го проекта меньше,
        //больше, или равен показателям 2го проекта
        private double i = 0;  
       
        public CompareForm()
        {
            InitializeComponent();
        }

        // Событие возникающее при закрытии формы
        private void CompareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Обнуляем ид проекта
            StatClass.setProjIdFCF(0);
            StatClass.setProjIdFMF(0);
        }

        // Событие возникающее при загрузке формы
        private void CompareForm_Load(object sender, EventArgs e)
        {
            // Показываем ид и имя проекта в таблице
            StatClass.showDataToDGV(String.Format("SELECT projId, projName FROM projects WHERE userId={0}", StatClass.getUserId()), dataGridView1);
            // Устанавливаем ширину ячейки Id=60
            dataGridView1.Columns[0].Width = 60;
            // Устанавливаем ширину ячейки Название проекта=160
            dataGridView1.Columns[1].Width = 160;
            // Устанавливаем название ячейки Id
            dataGridView1.Columns[0].HeaderText = "Id";
            // Устанавливаем название ячейки Название проекта
            dataGridView1.Columns[1].HeaderText = "Название проекта";
            dataGridView1.ClearSelection();
            // Отключаем возможность сортировки наших столбцов в таблице
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        // Событие возникающее при нажатии на любую ячейку таблицы
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Забираем ид проекта из таблицы
            StatClass.setProjIdFCF(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        }

        // Событие возникающее при клике по заголовку стоблца таблицы
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Обнуляем ид проекта
            StatClass.setProjIdFCF(0);
            // Снимаем выделения с таблицы
            dataGridView1.ClearSelection();
        }
        
        // Событие возникающее при нажатии на кнопку создания отчета
        private void CreateRepBut_Click(object sender, EventArgs e)
        {
            // Создаем объект формы ReportForm
            ReportForm reportForm = new ReportForm();
            // Если пользователь не нажал на какую либо ячейку в таблице по умолчанию ид проекта равен 0
            // Если ид проекта больше нуля(если пользователь нажал на какую либо ячейку в таблице) то выполяем код снизу
            if (StatClass.getProjIdFCF() > 0) 
            {
                // Если пользователь выбрал одинаковые проекты
                if (StatClass.getProjIdFCF() == StatClass.getProjIdFMF())
                    // То выводим соответствующее сообщение
                    MessageBox.Show("Вы не можете сравнивать одинаковые проекты!", "Одинаковые проекты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Юзер нажал на кнопку создать отчет находящая на форме сравнения
                    reportForm.setIsCompareClicked(true);
                    // Отображаем форму отчета
                    reportForm.ShowDialog();
                }
            }
        }

        // Событие возникающее при нажатии на кнопку экспертное заключения
        private void ConclBut_Click(object sender, EventArgs e)
        {
            // Если пользователь не нажал на какую либо ячейку в таблице по умолчанию ид проекта равен 0
            // Если ид проекта больше нуля(если пользователь нажал на какую либо ячейку в таблице) то выполяем код снизу
            if (StatClass.getProjIdFCF() > 0)
            {
                // Если пользователь выбрал одинаковые проекты
                if (StatClass.getProjIdFCF() == StatClass.getProjIdFMF())
                    // То выводим соответствующее сообщение
                    MessageBox.Show("Вы не можете сравнивать одинаковые проекты!", "Одинаковые проекты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Иначе выводим из нашей БД все записи проекта выбранного на главной форме в таблицу 
                    StatClass.showDataToDGV(String.Format("SELECT * FROM projects WHERE projId={0}", StatClass.getProjIdFMF()), DGVFM);
                    // Выводим из нашей БД все записи проекта выбранного на главной форме в таблицу 
                    StatClass.showDataToDGV(String.Format("SELECT * FROM projects WHERE projId={0}", StatClass.getProjIdFCF()), DGVFC);

                    // Вызываем приложение Word и делаем его видимым
                    wordApp = new Word.Application();
                    wordApp.Visible = true;
                    // Создаем новый пустой документ
                    wordApp.Documents.Add(Type.Missing);
                    // Создаем объект текущего выделения строки
                    Word.Selection curSel = wordApp.Selection;

                    // Там где вызывается метод TypeText мы записываем наш текст в текущую строку
                    // Там где вызывается метод TypeParagraph мы делаем отступ по абазцу
                    curSel.TypeText("ЭКСПЕРТНОЕ ЗАКЛЮЧЕНИЕ ПО ОПРЕДЕЛЕНИЮ НАИБОЛЕЕ ВЫГОДНОГО ПРОЕКТА");
                    curSel.TypeParagraph();
                    curSel.TypeText("Введение");
                    curSel.TypeParagraph();
                    curSel.TypeText("Экспертное заключение составлено с целью выявления наиболее выгодного проекта для инвестирования. ");
                    curSel.TypeText("На базе введенной информации рассчитываются скрытые показатели, которые в свою очередь являются исходной информацией для расчетов показателей эффективности. ");
                    curSel.TypeText("Анализируются показатели двух проектов, и выявляется наиболее привлекательный проект. ");
                    curSel.TypeParagraph();
                    curSel.TypeText("Исходные данные.");
                    curSel.TypeParagraph();
                    curSel.TypeText("Название 1-го проекта:- " + DGVFM[2, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Инициатор проекта:- " + DGVFM[3, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Вложения, требуемые проектом:- " + DGVFM[4, 0].Value + " "+DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Ставка дисконта:- " + DGVFM[5, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 1-ый год:- " + DGVFM[6, 0].Value + " " + DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов во 2-ой год:- " + DGVFM[7, 0].Value + " " + DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 3-ий год:- " + DGVFM[8, 0].Value + " " + DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 4-ый год:- " + DGVFM[9, 0].Value + " " + DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 5-ый год:- " + DGVFM[10, 0].Value + " " + DGVFM[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Название 2-го проекта:- " + DGVFC[2, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Инициатор проекта:- " + DGVFC[3, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Вложения, требуемые проектом:- " + DGVFC[4, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Ставка дисконта:- " + DGVFC[5, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 1-ый год:- " + DGVFC[6, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов во 2-ой год:- " + DGVFC[7, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 3-ий год:- " + DGVFC[8, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 4-ый год:- " + DGVFC[9, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Прогнозируемый поток доходов в 5-ый год:- " + DGVFC[10, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Показатели эффективности проекта " + DGVFM[2, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Период окупаемости проекта:- " + DGVFM[11, 0].Value + " год(а)");
                    curSel.TypeParagraph();
                    curSel.TypeText("Чистый приведенный доход:- " + DGVFM[12, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Внутренняя норма доходности:- " + DGVFM[13, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Коэффициент рентабельности проекта:- " + DGVFM[14, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Показатели эффективности проекта " + DGVFC[2, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Период окупаемости проекта:- " + DGVFC[11, 0].Value + " год(а)");
                    curSel.TypeParagraph();
                    curSel.TypeText("Чистый приведенный доход:- " + DGVFC[12, 0].Value + " " + DGVFC[28, 0].Value);
                    curSel.TypeParagraph();
                    curSel.TypeText("Внутренняя норма доходности:- " + DGVFC[13, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Коэффициент рентабельности проекта:- " + DGVFC[14, 0].Value + " %");
                    curSel.TypeParagraph();
                    curSel.TypeText("Анализ данных.");
                    curSel.TypeParagraph();
                    curSel.TypeText("Из приведенных выше показателей эффективности проектов " + DGVFM[2, 0].Value + " и " + DGVFC[2, 0].Value + " видно, что период окупаемости проекта " + DGVFM[2, 0].Value);

                    // Если период окупаемости 1го проекта меньше периода окупаемости 2го проекта
                    if (Convert.ToDouble(DGVFM[11, 0].Value) < Convert.ToDouble(DGVFC[11, 0].Value))
                    {
                        // Увеличиваем переменую шага на 1
                        i = i + 1;
                        // Записываем соответствующее сообщение
                        curSel.TypeText(" меньше периода ");
                    }
                    else
                        // Если период окупаемости 1го проекта равен периоду окупаемости 2го проекта
                        if (Convert.ToDouble(DGVFM[11, 0].Value) == Convert.ToDouble(DGVFC[11, 0].Value))
                        {
                            // Увеличиваем переменую шага на 0,5
                            i = i + 0.5;
                            // Записываем соответствующее сообщение
                            curSel.TypeText(" равен периоду ");
                        }
                        // Иначе период окупаемости 1го проекта больше периода окупаемости 2го проекта
                        else curSel.TypeText(" больше периода ");

                    curSel.TypeText("окупаемости проекта " + DGVFC[2, 0].Value + ". Чистый приведенный доход проекта " + DGVFM[2, 0].Value);

                    // Если чистый приведенный доход 1го проекта больше чистого приведенного дохода 2го проекта
                    if (Convert.ToDouble(DGVFM[12, 0].Value) > Convert.ToDouble(DGVFC[12, 0].Value))
                    {
                        // Увеличиваем переменую шага на 1
                        i = i + 1;
                        // Записываем соответствующее сообщение
                        curSel.TypeText(" больше чистого приведенного дохода ");
                    }
                    else
                        // Если чистый приведенный доход 1го проекта равен чистому приведенному доходу 2го проекта
                        if (Convert.ToDouble(DGVFM[12, 0].Value) == Convert.ToDouble(DGVFC[12, 0].Value))
                        {
                            // Увеличиваем переменую шага на 0,5
                            i = i + 0.5;
                            // Записываем соответствующее сообщение
                            curSel.TypeText(" равен чистому приведенному доходу ");
                        }
                        // Иначе чистый приведенный доход 1го проекта меньше чистого приведенного дохода 2го проекта
                        else curSel.TypeText(" меньше чистого приведенного дохода ");

                    curSel.TypeText("проекта " + DGVFC[2, 0].Value + ". Внутренняя норма доходности проекта " + DGVFM[2, 0].Value);

                    // Если внутрення норма доходности 1го проекта больше внутренней нормы доходности 2го проекта
                    if (Convert.ToDouble(DGVFM[13, 0].Value) > Convert.ToDouble(DGVFC[13, 0].Value))
                    {
                        // Увеличиваем переменую шага на 1
                        i = i + 1;
                        // Записываем соответствующее сообщение
                        curSel.TypeText(" больше внутренней нормы доходности ");
                    }
                    else
                        // Если внутрення норма доходности 1го проекта равна внутренней нормы доходности 2го проекта
                        if (Convert.ToDouble(DGVFM[13, 0].Value) == Convert.ToDouble(DGVFC[13, 0].Value))
                        {
                            // Увеличиваем переменую шага на 0,5
                            i = i + 0.5;
                            // Записываем соответствующее сообщение
                            curSel.TypeText(" равна внутренней норме доходности ");
                        }
                        // Если внутрення норма доходности 1го проекта меньше внутренней нормы доходности 2го проекта
                        else curSel.TypeText(" меньше внутренней нормы доходности ");

                    curSel.TypeText("проекта " + DGVFC[2, 0].Value + ". Коэффициент рентабельности проекта " + DGVFM[2, 0].Value);

                    // Если коэффицент рентабельности 1го проекта больше коэффицента рентабельности 2го проекта
                    if (Convert.ToDouble(DGVFM[14, 0].Value) > Convert.ToDouble(DGVFC[14, 0].Value))
                    {
                        // Увеличиваем переменую шага на 1
                        i = i + 1;
                        // Записываем соответствующее сообщение
                        curSel.TypeText(" больше коэффициента ");
                    }
                    else
                        // Если коэффицент рентабельности 1го проекта равен коэффиценту рентабельности 2го проекта
                        if (Convert.ToDouble(DGVFM[14, 0].Value) == Convert.ToDouble(DGVFC[14, 0].Value))
                        {
                            // Увеличиваем переменую шага на 0,5
                            i = i + 0.5;
                            // Записываем соответствующее сообщение
                            curSel.TypeText(" равен коэффициенту ");
                        }
                        // Иначе коэффицент рентабельности 1го проекта меньше коэффицента рентабельности 2го проекта
                        else curSel.TypeText(" меньше коэффициента ");

                    curSel.TypeText(" рентабельности проекта " + DGVFC[2, 0].Value + ". Это означает, что ");

                    if (i > 2) // Если сумма переменной шага больше 2 то
                        // 1ый проект перспективнее
                        curSel.TypeText("проект " + DGVFM[2, 0].Value + " является более привлекательным для инвестирования, чем проект " + DGVFC[2, 0].Value + ".");
                    else
                        // Если сумма переменной шага равняется 2 то
                        if (i == 2)
                            // // Оба проекта рискованы
                            curSel.TypeText("оба проекта по-своему рискованы. Необходимо провести дополнительное исследование.");
                        else
                            // Иначе 2ой проект перспективнее
                            curSel.TypeText("проект " + DGVFC[2, 0].Value + " является более привлекательным для инвестирования, чем проект " + DGVFM[2, 0].Value + ".");
                }
            }
            
        }

        // Событие возникающее при нажатии на надпись отмены
        private void CancelBut_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }
        

        
        
    }
}
