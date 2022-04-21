namespace DrillToolWeight
{
    partial class AddSectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSections = new System.Windows.Forms.DataGridView();
            this.bsAddSection = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.textWeight1m = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textWeightSection = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddSection)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataSections, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ApplyBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 26);
            this.panel1.TabIndex = 1;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ApplyBtn.Location = new System.Drawing.Point(308, 0);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 26);
            this.ApplyBtn.TabIndex = 1;
            this.ApplyBtn.Text = "Принять";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBtn.Location = new System.Drawing.Point(383, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 26);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboType);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 26);
            this.panel2.TabIndex = 2;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Все"});
            this.comboType.Location = new System.Drawing.Point(267, 3);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(141, 21);
            this.comboType.TabIndex = 3;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Нет",
            "Двигатели",
            "Трубы",
            "Прочее"});
            this.comboCategory.Location = new System.Drawing.Point(70, 3);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(141, 21);
            this.comboCategory.TabIndex = 1;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.combocategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория";
            // 
            // dataSections
            // 
            this.dataSections.AllowUserToAddRows = false;
            this.dataSections.AllowUserToDeleteRows = false;
            this.dataSections.AutoGenerateColumns = false;
            this.dataSections.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSections.DataSource = this.bsAddSection;
            this.dataSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSections.Location = new System.Drawing.Point(3, 35);
            this.dataSections.MultiSelect = false;
            this.dataSections.Name = "dataSections";
            this.dataSections.ReadOnly = true;
            this.dataSections.RowHeadersVisible = false;
            this.dataSections.RowTemplate.Height = 24;
            this.dataSections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSections.Size = new System.Drawing.Size(458, 259);
            this.dataSections.TabIndex = 3;
            this.dataSections.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSections_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textWeight1m);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textWeightSection);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textLength);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 26);
            this.panel3.TabIndex = 4;
            // 
            // textWeight1m
            // 
            this.textWeight1m.Location = new System.Drawing.Point(224, 2);
            this.textWeight1m.Name = "textWeight1m";
            this.textWeight1m.Size = new System.Drawing.Size(63, 22);
            this.textWeight1m.TabIndex = 5;
            this.textWeight1m.TextChanged += new System.EventHandler(this.textWeight1m_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вес 1 п/м (кг)";
            // 
            // textWeightSection
            // 
            this.textWeightSection.Location = new System.Drawing.Point(387, 2);
            this.textWeightSection.Name = "textWeightSection";
            this.textWeightSection.Size = new System.Drawing.Size(63, 22);
            this.textWeightSection.TabIndex = 3;
            this.textWeightSection.TextChanged += new System.EventHandler(this.textWeightSection_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вес секции (т)";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(66, 2);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(63, 22);
            this.textLength.TabIndex = 1;
            this.textLength.TextChanged += new System.EventHandler(this.textLength_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Длина (м)";
            // 
            // AddSectionForm
            // 
            this.AcceptButton = this.ApplyBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(464, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 400);
            this.Name = "AddSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить секцию";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSectionForm_FormClosing);
            this.Load += new System.EventHandler(this.AddSectionForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddSection)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSections;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWeight1m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWeightSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsAddSection;
    }
}