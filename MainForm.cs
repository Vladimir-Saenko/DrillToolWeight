using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DrillToolWeight.Models;
using SSR;
using IniParser;
using IniParser.Model;

namespace DrillToolWeight
{
    public partial class MainForm : Form
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\currentKnbk.json";
        private FileIOService _fileIOService;

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        } // свойство для извлечения Версии программы из AssemblyInfo

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolAboutBtn_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /* Действия при загрузке главной формы */
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Загрузка данных из INI-файла
            string iniPath = $"{Environment.CurrentDirectory}\\DrillToolWeight.ini";
            if (File.Exists(iniPath)) 
            {
                var parser = new FileIniDataParser();
                IniData iniData = parser.ReadFile(iniPath);
                string iniStr;

                iniStr = iniData["UI"]["winLeft"];
                this.Left = int.Parse(iniStr);

                iniStr = iniData["UI"]["winTop"];
                this.Top = int.Parse(iniStr);

                iniStr = iniData["UI"]["winHeight"];
                this.Height = int.Parse(iniStr);

                iniStr = iniData["UI"]["winWidth"];
                this.Width = int.Parse(iniStr);

                iniStr = iniData["Values"]["liquidDensity"];
                tbLiquidDensity.Text = iniStr;

            }

            // Вывод в Статус версии билда
            statusAppVersion.Text = String.Format("Версия: {0}", AssemblyVersion);

            /* загрузка последней КНБК */
            bool doneFlag = LoadKnbkFromFile(PATH); // сохранение текущей КНБК
            if (!doneFlag)
                MessageBox.Show("Ошибка: текущая КНБК не найдена.");
            
            ChangeDgvRow();

        }

        /* Загрузка сохраненной КНБК */
        private void ToolLoadBtn_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.CurrentDirectory}\\Knbk"; // Выставляем путь по умолчанию

            openFileDlg.InitialDirectory = path;
            openFileDlg.Filter = "json файлы (*.json)|*.json|Все файлы (*.*)|*.*"; // фильтр

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDlg.FileName)) // Если файл существует
                {
                    bool doneFlag = LoadKnbkFromFile(openFileDlg.FileName); // загрузка КНБК
                    if (!doneFlag)
                        MessageBox.Show("Ошибка загрузки КНБК.");
                }
                
            }

            ChangeDgvRow();
        }

        /* Загрузка КНБК */
        private bool LoadKnbkFromFile(string path) 
        {
            bool doneFlag = true;
            _fileIOService = new FileIOService(path); // создаем объект для чтения

            List<Knbk> loadKnbk = new List<Knbk>(); // выделяем память под список
            try
            {
                loadKnbk = _fileIOService.LoadData(); // читаем КНБК из файла в список
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // если ошибка чтения, то зануляем
                loadKnbk = null;
            }

            dataGridKnbk.Rows.Clear(); // Очищаем таблицу
            
            foreach (Knbk knbk in loadKnbk) // читаем КНБК из списка в таблицу
            {
                dataGridKnbk.Rows.Add(
                    knbk.Section,
                    knbk.Mark,
                    knbk.Length,
                    knbk.Weight
                    );
            }

            ReCalculationKnbk(); // пересчитываем вес и длину КНБК

            return doneFlag;
        }

        /* Действия при закрытии формы */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool doneFlag = SaveKnbkToFile(PATH); // сохранение текущей КНБК
            if (!doneFlag)
                MessageBox.Show("Ошибка: текущая КНБК не сохранена.");

            // Сохранение данных в INI-файл
            string iniPath = $"{Environment.CurrentDirectory}\\DrillToolWeight.ini";
            var parser = new FileIniDataParser();
            //IniData iniData = parser.ReadFile(iniPath);
            IniData iniData = new IniData();
            
            iniData["UI"]["winLeft"] = this.Left.ToString();
            iniData["UI"]["winTop"] = this.Top.ToString();
            iniData["UI"]["winHeight"] = this.Size.Height.ToString();
            iniData["UI"]["winWidth"] = this.Size.Width.ToString();
            iniData["Values"]["liquidDensity"] = tbLiquidDensity.Text;

            parser.WriteFile(iniPath, iniData);
        }

        /* Сохранение КНБК в архив */
        private void toolSaveBtn_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.CurrentDirectory}\\Knbk";
            if (!Directory.Exists(path)) 
            {
                Directory.CreateDirectory(path);
            }

            saveFileDlg.InitialDirectory = path;
            saveFileDlg.Filter = "json файлы (*.json)|*.json|Все файлы (*.*)|*.*";

            if (saveFileDlg.ShowDialog() == DialogResult.OK) 
            {
                string fileName = saveFileDlg.FileName; // Извлекаем имя файла
                string fileExt = Path.GetExtension(saveFileDlg.FileName).ToLower(); // Извлекаем расширение файла

                if (fileExt != ".json") // Если не указано расширение ".json",
                    fileName += ".json"; // то дописываем

                bool doneFlag = SaveKnbkToFile(fileName); // сохранение КНБК
                if (!doneFlag)
                    MessageBox.Show("Ошибка: текущая КНБК не сохранена.");
                                   
                    
            }

        }

        /* Сохранение КНБК */
        private bool SaveKnbkToFile(string path) 
        {
            bool doneFlag = true;
            _fileIOService = new FileIOService(path); // создаем объект для записи

            List<Knbk> currentKnbk = new List<Knbk>();


            for (int i = 0; i < dataGridKnbk.RowCount; i++)
            {
                currentKnbk.Add(new Knbk() // Добавляем следующую строку из таблицы
                {
                    Section = dataGridKnbk.Rows[i].Cells[0].Value.ToString(),
                    Mark = dataGridKnbk.Rows[i].Cells[1].Value.ToString(),
                    Length = (float)dataGridKnbk.Rows[i].Cells[2].Value,
                    Weight = (float)dataGridKnbk.Rows[i].Cells[3].Value
                });
            }

            try
            {
                _fileIOService.SaveData(currentKnbk); // сохраняем текущую КНБК
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // если ошибка, то вывод ошибки
                doneFlag = false;
            }

            return doneFlag;
        }


        /* Добавление секции */
        private void toolAddBtn_Click(object sender, EventArgs e)
        {
            AddSectionForm addDlg = new AddSectionForm();
            if (addDlg.ShowDialog() == DialogResult.OK) // прием данных из диалога
            {
                dataGridKnbk.Rows.Add(
                    addDlg.resultStr.Section,
                    addDlg.resultStr.Mark,
                    addDlg.resultStr.Length,
                    addDlg.resultStr.Weight
                    );

            }

            ReCalculationKnbk();

            ChangeDgvRow();
        }

        // Пересчет результатов
        private void ReCalculationKnbk()
        {
            float sumLength = 0.0f;
            float sumWeight = 0.0f; 
            const float LBT = 2.78f; // плотность материала ЛБТ
            const float TB = 7.85f; // плотность материала стального инструмента

            // Чтение значеия плотности ПЖ
            float liquidDensity = SStrings.ParseToFloat(tbLiquidDensity.Text);

            if (liquidDensity != 0)
            {
                for (int i = 0; i < dataGridKnbk.RowCount; i++)
                {
                    sumLength += (float)dataGridKnbk.Rows[i].Cells[2].Value;

                    float weight = (float)dataGridKnbk.Rows[i].Cells[3].Value;

                    switch (dataGridKnbk.Rows[i].Cells[0].Value)
                    {
                        case "ЛБТ":
                            weight *= (1 - (liquidDensity / LBT));
                            break;

                        case "ВБТ":
                            break;

                        default:
                            weight *= (1 - (liquidDensity / TB));
                            break;
                    }

                    sumWeight += weight;
                }
            }

            labelResult.Text = $"Длина бурильной колонны = {Math.Round(sumLength, 2)} м;  " +
                $"Вес бурильной колонны = {Math.Round(sumWeight, 2)} т.";

        }

        /* Изменение значения плотности ПЖ */
        private void tbLiquidDensity_TextChanged(object sender, EventArgs e)
        {
            float value = SStrings.ParseToFloat(tbLiquidDensity.Text);
            if (value != 0)
                ReCalculationKnbk();
        }

        /* Удаление строки из текущей компановки */
        private void toolRemoveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridKnbk.CurrentRow != null)
            {
                dataGridKnbk.Rows.Remove(dataGridKnbk.CurrentRow);
                float value = SStrings.ParseToFloat(tbLiquidDensity.Text);
                if (value != 0)
                    ReCalculationKnbk();

                ChangeDgvRow();
            }
        }

        /* Сдвиг строки вверх */
        private void ToolMoveUpBtn_Click(object sender, EventArgs e)
        {
            if (dataGridKnbk.CurrentRow.Index > 0) 
            {
                DataGridViewRow row = dataGridKnbk.CurrentRow;
                int currentRow = dataGridKnbk.CurrentCell.RowIndex;
                int currentColumn = dataGridKnbk.CurrentCell.ColumnIndex;

                dataGridKnbk.Rows.Remove(row);
                dataGridKnbk.Rows.Insert(currentRow - 1, row);
                dataGridKnbk.CurrentCell = dataGridKnbk.Rows[currentRow - 1].Cells[currentColumn];

                ChangeDgvRow();
            }
        }

        /* Сдвиг строки вниз */
        private void ToolMoveDownBtn_Click(object sender, EventArgs e)
        {
            if (dataGridKnbk.CurrentRow.Index < dataGridKnbk.RowCount - 1) 
            {
                DataGridViewRow row = dataGridKnbk.CurrentRow;
                int currentRow = dataGridKnbk.CurrentCell.RowIndex;
                int currentColumn = dataGridKnbk.CurrentCell.ColumnIndex;

                dataGridKnbk.Rows.Remove(row);
                dataGridKnbk.Rows.Insert(currentRow + 1, row);
                dataGridKnbk.CurrentCell = dataGridKnbk.Rows[currentRow + 1].Cells[currentColumn];

                ChangeDgvRow();
            }
        }

        /* Изменение длины секции */
        private void ToolEditBtn_Click(object sender, EventArgs e)
        {
             
            float lengthSection = Convert.ToSingle(dataGridKnbk[2, dataGridKnbk.CurrentRow.Index].Value);
            float weight1m = Convert.ToSingle(dataGridKnbk[3, dataGridKnbk.CurrentRow.Index].Value)/lengthSection;

            EditLengthDialog editLengthDlg = new EditLengthDialog(lengthSection);

            if (editLengthDlg.ShowDialog() == DialogResult.OK) 
            {
                if (editLengthDlg.lengthSection != 0)
                {
                    //прописываем новую длину секции
                    dataGridKnbk[2, dataGridKnbk.CurrentRow.Index].Value = editLengthDlg.lengthSection;

                    // пересчитываем вес секции
                    dataGridKnbk[3, dataGridKnbk.CurrentRow.Index].Value = editLengthDlg.lengthSection * weight1m;

                    ReCalculationKnbk();

                }
                
            }


        }

        /* Действия при переходе на другую строку */
        private void ChangeDgvRow() 
        {
            if (dataGridKnbk.Rows.Count > 0 && dataGridKnbk.CurrentRow != null) // Если количество строк больше нуля
            {
                // Проверка текущей секции
                string section = dataGridKnbk[0, dataGridKnbk.CurrentRow.Index].Value.ToString();
                if (section == "УБТ" | section == "ТБ" | section == "ЛБТ" | section == "ОТ")
                {
                    toolEditBtn.Enabled = true;
                }
                else
                {
                    toolEditBtn.Enabled = false;
                }

                // Проверка номера строки
                int index = dataGridKnbk.CurrentRow.Index;
                if (index > 0)
                {
                    toolMoveUpBtn.Enabled = true;
                }
                else
                {
                    toolMoveUpBtn.Enabled = false;
                }
                if (index < dataGridKnbk.Rows.Count - 1)
                {
                    toolMoveDownBtn.Enabled = true;
                }
                else
                {
                    toolMoveDownBtn.Enabled = false;
                }
            }
            else //Если таблица пуста или нет текущей строки
            {
                toolEditBtn.Enabled = false;
                toolMoveUpBtn.Enabled = false;
                toolMoveDownBtn.Enabled = false;
            }
        }

        /* Изменение позиции курсора в таблице */
        private void DataGridKnbk_SelectionChanged(object sender, EventArgs e)
        {
            ChangeDgvRow();
        }

        /* Очистка таблицы */
        private void ToolClearBtn_Click(object sender, EventArgs e)
        {
            dataGridKnbk.Rows.Clear();
            ChangeDgvRow();

        }

         /* TODO:
         * 1. Сделать правку справочников
         */
        private void ToolDictBtn_Click(object sender, EventArgs e)
        {
            EditDictForm dictDlg = new EditDictForm();
            dictDlg.ShowDialog();

        }

        
    }
}
