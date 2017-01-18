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
using Excel = Microsoft.Office.Interop.Excel;

namespace ProInvest
{
    public partial class ReportForm : Form
    {
        private Excel.Application excelApp; // Переменная приложения Excel
        private int i; // Переменная шага
        private int j; // Переменная шага
        private static bool flag = false; // // Переменная флага

        public ReportForm()
        {
            InitializeComponent();
        }
        
        // Функция определяющая были ли выбраны итемы(перв. данные, скрытые рассчеты, пок. эфф) содержания отчета
        public bool isCheckBoxSelected()
        {
            // Если юзер выбрал хоть один итем
            if (PdpCB.Checked == true || PeCB.Checked == true || PsrCB.Checked == true)
                // то функция вернет true(а это значит что юзер выбрал хоть один итем)
                return true;
                // иначе вернет false
            else return false;
        }

        public void setIsCompareClicked(bool value)
        {
            flag = value;
        }

        public bool getIsCompareClicked()
        {
            return flag;
        }

        // Событие возникающее при закрытии формы
        private void ReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Обнуляем функцию о нажатии на кнопку сравнить
            setIsCompareClicked(false);
        }

        private void OkBut_Click(object sender, EventArgs e)
        {
            // Если юзер выбрал хоть один итем
            if (isCheckBoxSelected())
            {
                // Выводим все данные о проекте из БД в таблицу
                StatClass.showDataToDGV(String.Format("SELECT * FROM projects WHERE projId={0}", StatClass.getProjIdFMF()), DGVFM);//execQuery(StatClass.getProjIdFMF());
                // Создаем объект приложения Excel
                excelApp = new Excel.Application(); 
                // Открываем приложения Excel и записываем в соответствующие ячейки данные о выбранном проекте
                excelApp.Visible = true;
                // Добавляем книгу
                excelApp.Workbooks.Add(Type.Missing);
                // Кол-во листов в книге = 1
                excelApp.SheetsInNewWorkbook = 1; 
                // Лист
                Excel.Worksheet sheet = (Excel.Worksheet)excelApp.Sheets[1];
                // Столбец
                Excel.Worksheet column = (Excel.Worksheet)excelApp.Sheets[1];
                // Строка
                Excel.Worksheet rows = (Excel.Worksheet)excelApp.Sheets[1];
                // Название листа = Отчет
                sheet.Name = "Отчет";

                // Устанавливаем ширину столбцов
                column.Columns[1, Type.Missing].ColumnWidth = 33;
                column.Columns[3, Type.Missing].ColumnWidth = 3;
                column.Columns[4, Type.Missing].ColumnWidth = 30;
                column.Columns[6, Type.Missing].ColumnWidth = 3;
                column.Columns[7, Type.Missing].ColumnWidth = 30;
                
                // Форматирование стиля шрифта
                rows.Rows[1, Type.Missing].Font.Bold = true;
                rows.Rows[1, Type.Missing].Font.Size = 11;
                rows.Rows[2, Type.Missing].Font.Bold = true;
                rows.Rows[2, Type.Missing].Font.Size = 11;
                rows.Rows[4, Type.Missing].Font.Bold = true;
                rows.Rows[4, Type.Missing].Font.Size = 11;

                // Значение [i][j] ячеек = "То что мы вводим сюда";
                // Значение [i][j] ячеек = DGVFM[2-27] данные из БД;
                
                sheet.Cells[1, 1] = "Название проекта";
                sheet.Cells[2, 1] = "Инициатор проекта";

                sheet.Cells[1, 2] = DGVFM[2, 0].Value;
                sheet.Cells[2, 2] = DGVFM[3, 0].Value;

                // Первичные данные проекта
                if (PdpCB.Checked == true)
                {
                    sheet.Cells[4, 1] = "Первичные данные проекта";
                    sheet.Cells[6, 1] = "Вложения, требуемые проектом ("+DGVFM[28, 0].Value+")";
                    sheet.Cells[7, 1] = "Ставка дисконта (%)";
                    sheet.Cells[8, 1] = "Поток доходов в 1-ый год (" + DGVFM[28, 0].Value + ")";
                    sheet.Cells[9, 1] = "Поток доходов во 2-ой год (" + DGVFM[28, 0].Value + ")";
                    sheet.Cells[10, 1] = "Поток доходов в 3-ий год (" + DGVFM[28, 0].Value + ")";
                    sheet.Cells[11, 1] = "Поток доходов в 4-ый год (" + DGVFM[28, 0].Value + ")";
                    sheet.Cells[12, 1] = "Поток доходов в 5-ый год (" + DGVFM[28, 0].Value + ")";

                    sheet.Cells[6, 2].value = DGVFM[4, 0].Value;
                    sheet.Cells[7, 2].value = DGVFM[5, 0].Value;
                    sheet.Cells[8, 2].value = DGVFM[6, 0].Value;
                    sheet.Cells[9, 2].value = DGVFM[7, 0].Value;
                    sheet.Cells[10, 2].value = DGVFM[8, 0].Value;
                    sheet.Cells[11, 2].value = DGVFM[9, 0].Value;
                    sheet.Cells[12, 2].value = DGVFM[10, 0].Value;
                    i = 3;
                }

                // Показатели эффективности проекта
                if (PeCB.Checked == true)
                {
                    sheet.Cells[4, 1 + i] = "Показатели эффективности";
                    sheet.Cells[6, 1 + i] = "Период окупаемости (год(а))";
                    sheet.Cells[7, 1 + i] = "Чистый приведенный доход (" + DGVFM[28, 0].Value + ")";
                    sheet.Cells[8, 1 + i] = "Внутренняя норма доходности (%)";
                    sheet.Cells[9, 1 + i] = "Коэффицент рентабельности (%)";

                    sheet.Cells[6, 2 + i].value = DGVFM[11, 0].Value;
                    sheet.Cells[7, 2 + i].value = DGVFM[12, 0].Value;
                    sheet.Cells[8, 2 + i].value = DGVFM[13, 0].Value;
                    sheet.Cells[9, 2 + i].value = DGVFM[14, 0].Value;
                    i += 3;
                }

                // Скрытые рассчета проекта
                if (PsrCB.Checked == true)
                {
                    sheet.Cells[4, 1 + i] = "Показатели скрытых рассчетов";
                    sheet.Cells[6, 1 + i] = "Дисконтированный денежный поток доходов";
                    sheet.Cells[12, 1 + i] = "Накопленный дисконтированный денежный поток доходов";
                    sheet.Cells[18, 1 + i] = "Суммарный приведенный доход";
                    sheet.Cells[19, 1 + i] = "NPV для барьерной ставки = 10%";
                    sheet.Cells[20, 1 + i] = "NPV для барьерной ставки = 15%";

                    sheet.Cells[7, 2 + i].value = DGVFM[15, 0].Value;
                    sheet.Cells[8, 2 + i].value = DGVFM[16, 0].Value;
                    sheet.Cells[9, 2 + i].value = DGVFM[17, 0].Value;
                    sheet.Cells[10, 2 + i].value = DGVFM[18, 0].Value;
                    sheet.Cells[11, 2 + i].value = DGVFM[19, 0].Value;
                    sheet.Cells[13, 2 + i].value = DGVFM[20, 0].Value;
                    sheet.Cells[14, 2 + i].value = DGVFM[21, 0].Value;
                    sheet.Cells[15, 2 + i].value = DGVFM[22, 0].Value;
                    sheet.Cells[16, 2 + i].value = DGVFM[23, 0].Value; ;
                    sheet.Cells[17, 2 + i].value = DGVFM[24, 0].Value;
                    sheet.Cells[18, 2 + i].value = DGVFM[25, 0].Value;
                    sheet.Cells[19, 2 + i].value = DGVFM[26, 0].Value;
                    sheet.Cells[20, 2 + i].value = DGVFM[27, 0].Value;
                }

                // Если происходит сравнение 2-х проектов
                if (getIsCompareClicked() == true)
                {
                    StatClass.showDataToDGV(String.Format("SELECT * FROM projects WHERE projId={0}", StatClass.getProjIdFCF()), DGVFC);

                    rows.Rows[22, Type.Missing].Font.Bold = true;
                    rows.Rows[22, Type.Missing].Font.Size = 11;
                    rows.Rows[23, Type.Missing].Font.Bold = true;
                    rows.Rows[23, Type.Missing].Font.Size = 11;
                    rows.Rows[25, Type.Missing].Font.Bold = true;
                    rows.Rows[25, Type.Missing].Font.Size = 11;

                    sheet.Cells[22, 1] = "Название проекта";
                    sheet.Cells[23, 1] = "Инициатор проекта";

                    sheet.Cells[22, 2] = DGVFC[2, 0].Value;
                    sheet.Cells[23, 2] = DGVFC[3, 0].Value;

                    if (PdpCB.Checked == true)
                    {
                        sheet.Cells[25, 1] = "Первичные данные проекта";
                        sheet.Cells[27, 1] = "Вложения, требуемые проектом (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[28, 1] = "Ставка дисконта (%)";
                        sheet.Cells[29, 1] = "Поток доходов в 1-ый год (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[10, 1] = "Поток доходов во 2-ой год (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[31, 1] = "Поток доходов в 3-ий год (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[32, 1] = "Поток доходов в 4-ый год (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[33, 1] = "Поток доходов в 5-ый год (" + DGVFC[28, 0].Value + ")";

                        sheet.Cells[27, 2].value = DGVFC[4, 0].Value;
                        sheet.Cells[28, 2].value = DGVFC[5, 0].Value;
                        sheet.Cells[29, 2].value = DGVFC[6, 0].Value;
                        sheet.Cells[30, 2].value = DGVFC[7, 0].Value;
                        sheet.Cells[31, 2].value = DGVFC[8, 0].Value;
                        sheet.Cells[32, 2].value = DGVFC[9, 0].Value;
                        sheet.Cells[33, 2].value = DGVFC[10, 0].Value;
                        j = 3;
                    }

                    if (PeCB.Checked == true)
                    {
                        sheet.Cells[25, 1 + j] = "Показатели эффективности";
                        sheet.Cells[27, 1 + j] = "Период окупаемости (год(а))";
                        sheet.Cells[28, 1 + j] = "Чистый приведенный доход (" + DGVFC[28, 0].Value + ")";
                        sheet.Cells[29, 1 + j] = "Внутренняя норма доходности (%)";
                        sheet.Cells[30, 1 + j] = "Коэффицент рентабельности (%)";

                        sheet.Cells[27, 2 + j].value = DGVFC[11, 0].Value;
                        sheet.Cells[28, 2 + j].value = DGVFC[12, 0].Value;
                        sheet.Cells[29, 2 + j].value = DGVFC[13, 0].Value;
                        sheet.Cells[30, 2 + j].value = DGVFC[14, 0].Value;
                        j += 3;
                    }

                    if (PsrCB.Checked == true)
                    {
                        sheet.Cells[25, 1 + j] = "Показатели скрытых рассчетов";
                        sheet.Cells[27, 1 + j] = "Дисконтированный денежный поток доходов";
                        sheet.Cells[33, 1 + j] = "Накопленный дисконтированный денежный поток доходов";
                        sheet.Cells[39, 1 + j] = "Суммарный приведенный доход";
                        sheet.Cells[40, 1 + j] = "NPV для барьерной ставки = 10%";
                        sheet.Cells[41, 1 + j] = "NPV для барьерной ставки = 15%";

                        sheet.Cells[28, 2 + j].value = DGVFC[15, 0].Value;
                        sheet.Cells[29, 2 + j].value = DGVFC[16, 0].Value;
                        sheet.Cells[30, 2 + j].value = DGVFC[17, 0].Value;
                        sheet.Cells[31, 2 + j].value = DGVFC[18, 0].Value;
                        sheet.Cells[32, 2 + j].value = DGVFC[19, 0].Value;
                        sheet.Cells[34, 2 + j].value = DGVFC[20, 0].Value;
                        sheet.Cells[35, 2 + j].value = DGVFC[21, 0].Value;
                        sheet.Cells[36, 2 + j].value = DGVFC[22, 0].Value;
                        sheet.Cells[37, 2 + j].value = DGVFC[23, 0].Value;
                        sheet.Cells[38, 2 + j].value = DGVFC[24, 0].Value;
                        sheet.Cells[39, 2 + j].value = DGVFC[25, 0].Value;
                        sheet.Cells[40, 2 + j].value = DGVFC[26, 0].Value;
                        sheet.Cells[41, 2 + j].value = DGVFC[27, 0].Value;
                    }
                }
            }
        }

        // Событие возникающее при клике на кнопку отмена
        private void CancelBut_Click(object sender, EventArgs e)
        {
            // Закрываем текущую форму
            this.Close();
        }
    }
}
