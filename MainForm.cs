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
using System.Configuration;
using SSR;

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
            float liquidDensity = 0.0f;
            const float LBT = 2.78f; // плотность материала ЛБТ
            const float TB = 7.85f; // плотность материала стального инструмента

            liquidDensity = SStrings.ParseToFloat(tbLiquidDensity.Text);

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

            labelResult.Text = $"Длина бурильной колонны = {Math.Round(sumLength,2)} м;  " +
                $"Вес бурильной колонны = {Math.Round(sumWeight, 2)} т.";

        }

        private void tbLiquidDensity_TextChanged(object sender, EventArgs e)
        {
            float value = SStrings.ParseToFloat(tbLiquidDensity.Text);
            if (value != 0)
                ReCalculationKnbk();
        }
    }
}
