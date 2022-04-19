using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSR;

namespace DrillToolWeight
{
    partial class EditLengthDialog : Form
    {
        public float lengthSection = 0.0f;

        public EditLengthDialog()
        {
            InitializeComponent();
            this.Text = "Изменение длины секции";
            this.textLengthSection.Text = "";

        }

        public EditLengthDialog(float oldLenght)  : this()
        {
            this.textLengthSection.Text = oldLenght.ToString();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            lengthSection = SStrings.ParseToFloat(textLengthSection.Text);
        }

        /* TODO 
         * Сделать проверку корректности ввода в поле textBlock
         */
    }
}
