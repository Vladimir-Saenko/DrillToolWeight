using SSR;
using System;
using System.Windows.Forms;

namespace DrillToolWeight
{
    public partial class MainForm : Form
    {
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
            // загрузка последней КНБК

        }

        /* Действия при закрытии формы */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // сохранение текущей КНБК
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
            }
        }
    }
}
