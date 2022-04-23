using DrillToolWeight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSR;


namespace DrillToolWeight
{
    public partial class AddSectionForm : Form
    {
        private DataWorker dataWorker = null;
        private List<Engine> _listEngines;
        private List<Pipe> _listPipes;
        private List<Other> _listOthers;

        // объявление публичной переменной для возврата результата
        public Knbk resultStr = new Knbk();


        public AddSectionForm()
        {
            InitializeComponent();

            _listEngines = new List<Engine>();
            _listPipes = new List<Pipe>();
            _listOthers = new List<Other>();

            dataSections.AutoGenerateColumns = true; // автогенерация колонок. потом убрать
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /* Действия при загрузке формы */
        private void AddSectionForm_Load(object sender, EventArgs e)
        {
            // Инициализация формы
            comboCategory.SelectedIndex = 0;
            comboType.SelectedIndex = 0;
            comboType.Enabled = false;
            ApplyBtn.Enabled = false;

            dataWorker = new DataWorker();

        }

        /* действия при закрытии формы */
        private void AddSectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }

        // Выбор категории секции
        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboType.Items.Clear();   // Сброс выбора типа
            comboType.Items.Add("Все");
            comboType.SelectedIndex = 0;

            switch (comboCategory.SelectedIndex)
            {
                case 1: // Двигатели
                    comboType.Enabled = true;
                    textWeight1m.Enabled = false;
                    textLength.Enabled = true;
                    textWeightSection.Enabled = true;
                    textWeight1m.Text = "";


                    _listEngines.Clear();
                    List<Engine> listEngines = dataWorker.GetEngines(comboType.Text);
                    if (listEngines != null && listEngines.Count > 0)
                    {
                        _listEngines.AddRange(listEngines);
                        bsAddSection.ResetBindings(false);
                    }
                    bsAddSection.DataSource = _listEngines;

                    // Чтение типов в comboType
                    foreach (Engine item in _listEngines)
                    {
                        bool flag = false;
                        foreach (string type in comboType.Items)
                        {
                            if (item.Type == type)
                                flag = true;
                        }
                        if (flag == false)
                            comboType.Items.Add(item.Type);
                    }

                    break;

                case 2: // Трубы
                    comboType.Enabled = true;
                    textWeight1m.Enabled = true;
                    textLength.Enabled = true;
                    textWeightSection.Enabled = true;
                    textLength.Text = "";

                    _listPipes.Clear();
                    List<Pipe> listPipes = dataWorker.GetPipes(comboType.Text);
                    if (listPipes != null && listPipes.Count > 0)
                    {
                        _listPipes.AddRange(listPipes);
                        bsAddSection.ResetBindings(false);
                    }
                    bsAddSection.DataSource = _listPipes;

                    // Чтение типов в comboType
                    foreach (Pipe item in _listPipes)
                    {
                        bool flag = false;
                        foreach (string type in comboType.Items)
                        {
                            if (item.Type == type)
                                flag = true;
                        }
                        if (flag == false)
                            comboType.Items.Add(item.Type);
                    }

                    break;

                case 3: // Прочее
                    comboType.Enabled = true;
                    textWeight1m.Enabled = false;
                    textLength.Enabled = true;
                    textWeightSection.Enabled = true;
                    textWeight1m.Text = "";

                    _listOthers.Clear();
                    List<Other> listOther = dataWorker.GetOthers(comboType.Text);
                    if (listOther != null && listOther.Count > 0)
                    {
                        _listOthers.AddRange(listOther);
                        bsAddSection.ResetBindings(false);
                    }
                    bsAddSection.DataSource = _listOthers;

                    // Чтение типов в comboType
                    foreach (Other item in _listOthers)
                    {
                        bool flag = false;
                        foreach (string type in comboType.Items)
                        {
                            if (item.Type == type)
                                flag = true;
                        }
                        if (flag == false)
                            comboType.Items.Add(item.Type);
                    }

                    break;

                default: // Без категории
                    comboType.Enabled = false;
                    textWeight1m.Enabled = false;
                    textLength.Enabled = true;
                    textWeightSection.Enabled = true;
                    textWeight1m.Text = "";

                    bsAddSection.DataSource = null;
                    textLength.Text = "";
                    textWeightSection.Text = "";
                    ApplyBtn.Enabled = false;

                    break;
            }

            comboType.SelectedIndex = 0;
            // перевод фокуса на первую ячейку
            if (dataSections.CurrentCell != null)
            {
                dataSections.CurrentCell = dataSections[0, 0];
            }

        }

        /* Выбор по типу */
        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboCategory.SelectedIndex)
            {
                case 1: // Двигатели
                    _listEngines.Clear();
                    List<Engine> list = dataWorker.GetEngines(comboType.Text);
                    if (list != null && list.Count > 0)
                    {
                        _listEngines.AddRange(list);
                        bsAddSection.ResetBindings(false);
                    }

                    break;

                case 2: // Трубы
                    _listPipes.Clear();
                    List<Pipe> listPipes = dataWorker.GetPipes(comboType.Text);
                    if (listPipes != null && listPipes.Count > 0)
                    {
                        _listPipes.AddRange(listPipes);
                        bsAddSection.ResetBindings(false);
                    }
                    textLength.Text = "";

                    break;

                case 3: // Прочее
                    _listOthers.Clear();
                    List<Other> listOthers = dataWorker.GetOthers(comboType.Text);
                    if (listOthers != null && listOthers.Count > 0)
                    {
                        _listOthers.AddRange(listOthers);
                        bsAddSection.ResetBindings(false);
                    }

                    break;

                default: // Без категории

                    break;
            }
            // перевод фокуса на первую ячейку
            if (dataSections.CurrentCell != null)
            {
                dataSections.CurrentCell = dataSections[0, 0];
            }

        }

        /* Считывание данных из выбранной строки */
        private void dataSections_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (comboCategory.SelectedIndex)
            {
                case 1:
                    if (e.RowIndex < _listEngines.Count)
                    {
                        resultStr.Section = _listEngines[e.RowIndex].Type;
                        resultStr.Mark = _listEngines[e.RowIndex].Name;
                        textLength.Text = _listEngines[e.RowIndex].Length.ToString();
                        textWeightSection.Text = (_listEngines[e.RowIndex].Weight / 1000).ToString();
                        textWeight1m.Text = "";
                    }

                    break;

                case 2:
                    if (e.RowIndex < _listPipes.Count)
                    {
                        resultStr.Section = _listPipes[e.RowIndex].Type;
                        resultStr.Mark = _listPipes[e.RowIndex].Name;
                        textWeight1m.Text = _listPipes[e.RowIndex].Weight1m.ToString();
                        CalcWeightSection();
                    }

                    break;

                case 3:
                    if (e.RowIndex < _listOthers.Count)
                    {
                        resultStr.Section = _listOthers[e.RowIndex].Type;
                        resultStr.Mark = _listOthers[e.RowIndex].Name;
                        textLength.Text = _listOthers[e.RowIndex].Length.ToString();
                        textWeightSection.Text = (_listOthers[e.RowIndex].Weight / 1000).ToString();
                        textWeight1m.Text = "";
                    }
                    break;

                default:

                    break;
            }
            CheckOutputValues();
        }

        // Проверка правильности ввода результатов
        private void CheckOutputValues()
        {
            float aLength = SStrings.ParseToFloat(textLength.Text);
            float aWeight = SStrings.ParseToFloat(textWeightSection.Text);

            if (aLength != 0.0f && aWeight != 0.0f)
            {
                ApplyBtn.Enabled = true;
            }
            else
            {
                ApplyBtn.Enabled = false;
            }
        }
        
        // Вычисление веса секции по весу 1 п/м и длине секции
        private void CalcWeightSection()
        {
            float aLength = SStrings.ParseToFloat(textLength.Text);
            float aWeight1m = SStrings.ParseToFloat(textWeight1m.Text);

            if (aLength != 0.0f && aWeight1m != 0.0f)
            {
                textWeightSection.Text = (aLength * aWeight1m / 1000).ToString();
                ApplyBtn.Enabled = true;
            }
            else 
            {
                textWeightSection.Text = "";
                ApplyBtn.Enabled = false;
            }
        }

        // Изменение текста в окне веса 1 п/м
        private void textWeight1m_TextChanged(object sender, EventArgs e)
        {
            CalcWeightSection();
            CheckOutputValues();
        }

        // Изменение текста в окне длины секции
        private void textLength_TextChanged(object sender, EventArgs e)
        {
            if (textWeight1m.Enabled == true)
            {
                CalcWeightSection();
            }
            CheckOutputValues();
        }

        //Изменение текста в окне веса секции
        private void textWeightSection_TextChanged(object sender, EventArgs e)
        {
            CheckOutputValues();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (resultStr.Section == null)
                resultStr.Section = "Нет данных";
            if (resultStr.Mark == null)
                resultStr.Mark = "Нет данных";

            resultStr.Length = SStrings.ParseToFloat(textLength.Text);
            resultStr.Weight = SStrings.ParseToFloat(textWeightSection.Text);
        }

    }
}
