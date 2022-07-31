using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrillToolWeight.Models;

namespace DrillToolWeight
{
    public partial class EditDictForm : Form
    {
        private DataWorker dataWorker = null;
        private List<Engine> _listEngines;
        private List<Pipe> _listPipes;
        private List<Other> _listOthers;

        public EditDictForm()
        {
            InitializeComponent();

            _listEngines = new List<Engine>();
            _listPipes = new List<Pipe>();
            _listOthers = new List<Other>();

            dgvDict.AutoGenerateColumns = true;
        }

        // действия при открытии диалога
        private void EditDictForm_Load(object sender, EventArgs e)
        {
            dataWorker = new DataWorker();
            comboCategory.SelectedIndex = 0;
        }

        private void СomboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboCategory.SelectedIndex) 
            {
                case 0: // Двигатели
                    _listEngines.Clear();
                    List<Engine> listEngines = dataWorker.GetEngines("Все");
                    if (listEngines != null && listEngines.Count > 0)
                    {
                        _listEngines.AddRange(listEngines);
                        bsDict.ResetBindings(false);
                    }
                    bsDict.DataSource = _listEngines;

                    // Наименование колонок таблицы
                    dgvDict.Columns[0].Visible = false;
                    dgvDict.Columns[1].HeaderText = "Наименование";
                    dgvDict.Columns[2].HeaderText = "Тип";
                    dgvDict.Columns[3].HeaderText = "Длина,м";
                    dgvDict.Columns[4].HeaderText = "Вес, кг";

                    break;

                case 1: // Трубы
                    _listPipes.Clear();
                    List<Pipe> listPipes = dataWorker.GetPipes("Все");
                    if (listPipes != null && listPipes.Count > 0)
                    {
                        _listPipes.AddRange(listPipes);
                        bsDict.ResetBindings(false);
                    }
                    bsDict.DataSource = _listPipes;

                    // Наименование колонок таблицы
                    dgvDict.Columns[0].Visible = false;
                    dgvDict.Columns[1].HeaderText = "Наименование";
                    dgvDict.Columns[2].HeaderText = "Тип";
                    dgvDict.Columns[3].HeaderText = "Нар.диаметр, мм";
                    dgvDict.Columns[4].HeaderText = "Вн.диаметр, мм";
                    dgvDict.Columns[5].HeaderText = "Вес 1 пог.м, кг";

                    break;

                case 2: // Прочее

                    _listOthers.Clear();
                    List<Other> listOther = dataWorker.GetOthers("Все");
                    if (listOther != null && listOther.Count > 0)
                    {
                        _listOthers.AddRange(listOther);
                        bsDict.ResetBindings(false);
                    }
                    bsDict.DataSource = _listOthers;

                    // Наименование колонок таблицы
                    dgvDict.Columns[0].Visible = false;
                    dgvDict.Columns[1].HeaderText = "Наименование";
                    dgvDict.Columns[2].HeaderText = "Тип";
                    dgvDict.Columns[3].HeaderText = "Длина,м";
                    dgvDict.Columns[4].HeaderText = "Вес, кг";

                    break;

                default:

                    break;

            }
        }

        // Сохранение изменений в наборе данных
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //bsDict.
        }
    }
}
