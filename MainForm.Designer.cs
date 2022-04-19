namespace DrillToolWeight
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbLiquidDensity = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.dataGridKnbk = new System.Windows.Forms.DataGridView();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolRemoveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolMoveUpBtn = new System.Windows.Forms.ToolStripButton();
            this.toolSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolLoadBtn = new System.Windows.Forms.ToolStripButton();
            this.toolAboutBtn = new System.Windows.Forms.ToolStripButton();
            this.toolMoveDownBtn = new System.Windows.Forms.ToolStripButton();
            this.bsSections = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKnbk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSections)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddBtn,
            this.toolRemoveBtn,
            this.toolStripSeparator1,
            this.toolMoveUpBtn,
            this.toolMoveDownBtn,
            this.toolStripSeparator3,
            this.toolSaveBtn,
            this.toolLoadBtn,
            this.toolStripSeparator2,
            this.toolAboutBtn,
            this.tbLiquidDensity,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 28);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tbLiquidDensity
            // 
            this.tbLiquidDensity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbLiquidDensity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbLiquidDensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLiquidDensity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLiquidDensity.Name = "tbLiquidDensity";
            this.tbLiquidDensity.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.tbLiquidDensity.Size = new System.Drawing.Size(50, 28);
            this.tbLiquidDensity.Text = "1,05";
            this.tbLiquidDensity.TextChanged += new System.EventHandler(this.tbLiquidDensity_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(140, 25);
            this.toolStripLabel1.Text = "Плотность ПЖ, г/см3 =";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAppVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusAppVersion
            // 
            this.statusAppVersion.Name = "statusAppVersion";
            this.statusAppVersion.RightToLeftAutoMirrorImage = true;
            this.statusAppVersion.Size = new System.Drawing.Size(53, 17);
            this.statusAppVersion.Text = "v.0.1.0.0";
            // 
            // panelResult
            // 
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResult.Location = new System.Drawing.Point(0, 268);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(584, 24);
            this.panelResult.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(0, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(582, 22);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Длина бурильной колонны =    Вес бурильной колонны = ";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridKnbk
            // 
            this.dataGridKnbk.AllowUserToAddRows = false;
            this.dataGridKnbk.AllowUserToDeleteRows = false;
            this.dataGridKnbk.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridKnbk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKnbk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Section,
            this.Mark,
            this.Length,
            this.Weigth});
            this.dataGridKnbk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKnbk.Location = new System.Drawing.Point(0, 28);
            this.dataGridKnbk.Name = "dataGridKnbk";
            this.dataGridKnbk.ReadOnly = true;
            this.dataGridKnbk.RowHeadersVisible = false;
            this.dataGridKnbk.RowTemplate.Height = 24;
            this.dataGridKnbk.Size = new System.Drawing.Size(584, 240);
            this.dataGridKnbk.TabIndex = 3;
            // 
            // Section
            // 
            this.Section.HeaderText = "Секция";
            this.Section.MinimumWidth = 100;
            this.Section.Name = "Section";
            this.Section.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Маркировка";
            this.Mark.MinimumWidth = 100;
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 250;
            // 
            // Length
            // 
            this.Length.HeaderText = "Длина, м";
            this.Length.MinimumWidth = 80;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 80;
            // 
            // Weigth
            // 
            this.Weigth.HeaderText = "Вес, т";
            this.Weigth.MinimumWidth = 80;
            this.Weigth.Name = "Weigth";
            this.Weigth.ReadOnly = true;
            this.Weigth.Width = 80;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolAddBtn
            // 
            this.toolAddBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddBtn.Image = global::DrillToolWeight.Properties.Resources.Add;
            this.toolAddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolAddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddBtn.Name = "toolAddBtn";
            this.toolAddBtn.Size = new System.Drawing.Size(23, 25);
            this.toolAddBtn.Text = "Добавить";
            this.toolAddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolAddBtn.ToolTipText = "Добавить секцию";
            this.toolAddBtn.Click += new System.EventHandler(this.toolAddBtn_Click);
            // 
            // toolRemoveBtn
            // 
            this.toolRemoveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveBtn.Image = global::DrillToolWeight.Properties.Resources.Remove;
            this.toolRemoveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveBtn.Name = "toolRemoveBtn";
            this.toolRemoveBtn.Size = new System.Drawing.Size(23, 25);
            this.toolRemoveBtn.Text = "Удалить";
            this.toolRemoveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolRemoveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolRemoveBtn.ToolTipText = "Удалить секцию";
            this.toolRemoveBtn.Click += new System.EventHandler(this.toolRemoveBtn_Click);
            // 
            // toolMoveUpBtn
            // 
            this.toolMoveUpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveUpBtn.Image = global::DrillToolWeight.Properties.Resources.Top;
            this.toolMoveUpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveUpBtn.Name = "toolMoveUpBtn";
            this.toolMoveUpBtn.Size = new System.Drawing.Size(23, 25);
            this.toolMoveUpBtn.Text = "Сдвинуть строку вверх";
            this.toolMoveUpBtn.Click += new System.EventHandler(this.ToolMoveUpBtn_Click);
            // 
            // toolSaveBtn
            // 
            this.toolSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSaveBtn.Image = global::DrillToolWeight.Properties.Resources.Save;
            this.toolSaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSaveBtn.Name = "toolSaveBtn";
            this.toolSaveBtn.Size = new System.Drawing.Size(23, 25);
            this.toolSaveBtn.Text = "Сохранить КНБК";
            this.toolSaveBtn.Click += new System.EventHandler(this.toolSaveBtn_Click);
            // 
            // toolLoadBtn
            // 
            this.toolLoadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLoadBtn.Image = global::DrillToolWeight.Properties.Resources.Load;
            this.toolLoadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLoadBtn.Name = "toolLoadBtn";
            this.toolLoadBtn.Size = new System.Drawing.Size(23, 25);
            this.toolLoadBtn.Text = "Загрузить КНБК";
            this.toolLoadBtn.Click += new System.EventHandler(this.ToolLoadBtn_Click);
            // 
            // toolAboutBtn
            // 
            this.toolAboutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAboutBtn.Image = global::DrillToolWeight.Properties.Resources.Info;
            this.toolAboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAboutBtn.Name = "toolAboutBtn";
            this.toolAboutBtn.Size = new System.Drawing.Size(23, 25);
            this.toolAboutBtn.Text = "О программе";
            this.toolAboutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolAboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolAboutBtn.ToolTipText = "Информация о программе";
            this.toolAboutBtn.Click += new System.EventHandler(this.toolAboutBtn_Click);
            // 
            // toolMoveDownBtn
            // 
            this.toolMoveDownBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveDownBtn.Image = global::DrillToolWeight.Properties.Resources.Bottom;
            this.toolMoveDownBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveDownBtn.Name = "toolMoveDownBtn";
            this.toolMoveDownBtn.Size = new System.Drawing.Size(23, 25);
            this.toolMoveDownBtn.Text = "Сдвинуть строку вниз";
            this.toolMoveDownBtn.Click += new System.EventHandler(this.ToolMoveDownBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 314);
            this.Controls.Add(this.dataGridKnbk);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 340);
            this.Name = "MainForm";
            this.Text = "DrillToolWeight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKnbk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAddBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusAppVersion;
        private System.Windows.Forms.ToolStripButton toolRemoveBtn;
        private System.Windows.Forms.ToolStripButton toolAboutBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbLiquidDensity;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.DataGridView dataGridKnbk;
        private System.Windows.Forms.BindingSource bsSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weigth;
        private System.Windows.Forms.ToolStripButton toolSaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolLoadBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.ToolStripButton toolMoveUpBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolMoveDownBtn;
    }
}

