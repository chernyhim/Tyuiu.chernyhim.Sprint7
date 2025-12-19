namespace Tyuiu.chernyhim.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd_CIM = new Button();
            buttonDelete_CIM = new Button();
            buttonStatistics_CIM = new Button();
            groupBox1 = new GroupBox();
            comboFilter_CIM = new ComboBox();
            groupBox2 = new GroupBox();
            textBoxSearch_CIM = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView_CIM = new DataGridView();
            columnShopId_CIM = new DataGridViewTextBoxColumn();
            columnShopName_CIM = new DataGridViewTextBoxColumn();
            columnShopAddress_CIM = new DataGridViewTextBoxColumn();
            columnShopPhone_CIM = new DataGridViewTextBoxColumn();
            columnShopRevenue_CIM = new DataGridViewTextBoxColumn();
            panelData_CIM = new Panel();
            labelMin_Title = new Label();
            groupBox4 = new GroupBox();
            labelAvg_CIM = new Label();
            labelAvgTitle_CIM = new Label();
            labelMax_CIM = new Label();
            labelMaxTitle_CIM = new Label();
            labelMin_CIM = new Label();
            buttonSave_CIM = new Button();
            groupBox5 = new GroupBox();
            buttonLoad_CIM = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CIM).BeginInit();
            panelData_CIM.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd_CIM
            // 
            buttonAdd_CIM.Location = new Point(16, 20);
            buttonAdd_CIM.Name = "buttonAdd_CIM";
            buttonAdd_CIM.Size = new Size(80, 80);
            buttonAdd_CIM.TabIndex = 3;
            buttonAdd_CIM.Text = "Add";
            buttonAdd_CIM.Click += buttonAdd_CIM_Click;
            // 
            // buttonDelete_CIM
            // 
            buttonDelete_CIM.Location = new Point(424, 20);
            buttonDelete_CIM.Name = "buttonDelete_CIM";
            buttonDelete_CIM.Size = new Size(80, 80);
            buttonDelete_CIM.TabIndex = 2;
            buttonDelete_CIM.Text = "Delete";
            buttonDelete_CIM.UseVisualStyleBackColor = true;
            buttonDelete_CIM.Click += buttonDelete_CIM_Click;
            // 
            // buttonStatistics_CIM
            // 
            buttonStatistics_CIM.Location = new Point(778, 20);
            buttonStatistics_CIM.Name = "buttonStatistics_CIM";
            buttonStatistics_CIM.Size = new Size(80, 80);
            buttonStatistics_CIM.TabIndex = 1;
            buttonStatistics_CIM.Text = "Stats";
            buttonStatistics_CIM.UseVisualStyleBackColor = true;
            buttonStatistics_CIM.Click += buttonStatistics_CIM_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonStatistics_CIM);
            groupBox1.Controls.Add(buttonDelete_CIM);
            groupBox1.Controls.Add(buttonAdd_CIM);
            groupBox1.Location = new Point(12, 935);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 106);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Функции";
            // 
            // comboFilter_CIM
            // 
            comboFilter_CIM.FormattingEnabled = true;
            comboFilter_CIM.Location = new Point(11, 26);
            comboFilter_CIM.Name = "comboFilter_CIM";
            comboFilter_CIM.Size = new Size(171, 28);
            comboFilter_CIM.TabIndex = 2;
            comboFilter_CIM.SelectedIndexChanged += comboFilter_CIM_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboFilter_CIM);
            groupBox2.Location = new Point(549, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 64);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фильтр";
            // 
            // textBoxSearch_CIM
            // 
            textBoxSearch_CIM.Location = new Point(6, 23);
            textBoxSearch_CIM.Name = "textBoxSearch_CIM";
            textBoxSearch_CIM.Size = new Size(516, 27);
            textBoxSearch_CIM.TabIndex = 0;
            textBoxSearch_CIM.TextChanged += textBoxSearch_CIM_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxSearch_CIM);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 64);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Поиск";
            // 
            // dataGridView_CIM
            // 
            dataGridView_CIM.AllowUserToAddRows = false;
            dataGridView_CIM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_CIM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CIM.Columns.AddRange(new DataGridViewColumn[] { columnShopId_CIM, columnShopName_CIM, columnShopAddress_CIM, columnShopPhone_CIM, columnShopRevenue_CIM });
            dataGridView_CIM.Dock = DockStyle.Fill;
            dataGridView_CIM.Location = new Point(0, 0);
            dataGridView_CIM.MultiSelect = false;
            dataGridView_CIM.Name = "dataGridView_CIM";
            dataGridView_CIM.RowHeadersVisible = false;
            dataGridView_CIM.RowHeadersWidth = 51;
            dataGridView_CIM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_CIM.Size = new Size(942, 744);
            dataGridView_CIM.TabIndex = 1;
            dataGridView_CIM.CellContentClick += dataGridView_CIM_CellContentClick;
            // 
            // columnShopId_CIM
            // 
            columnShopId_CIM.HeaderText = "Id магазина";
            columnShopId_CIM.MinimumWidth = 6;
            columnShopId_CIM.Name = "columnShopId_CIM";
            // 
            // columnShopName_CIM
            // 
            columnShopName_CIM.HeaderText = "Название магазина";
            columnShopName_CIM.MinimumWidth = 6;
            columnShopName_CIM.Name = "columnShopName_CIM";
            // 
            // columnShopAddress_CIM
            // 
            columnShopAddress_CIM.HeaderText = "Адрес";
            columnShopAddress_CIM.MinimumWidth = 6;
            columnShopAddress_CIM.Name = "columnShopAddress_CIM";
            // 
            // columnShopPhone_CIM
            // 
            columnShopPhone_CIM.HeaderText = "Телефон";
            columnShopPhone_CIM.MinimumWidth = 6;
            columnShopPhone_CIM.Name = "columnShopPhone_CIM";
            // 
            // columnShopRevenue_CIM
            // 
            columnShopRevenue_CIM.HeaderText = "Дневная выручка";
            columnShopRevenue_CIM.MinimumWidth = 6;
            columnShopRevenue_CIM.Name = "columnShopRevenue_CIM";
            // 
            // panelData_CIM
            // 
            panelData_CIM.BackColor = SystemColors.ControlLight;
            panelData_CIM.Controls.Add(dataGridView_CIM);
            panelData_CIM.Location = new Point(18, 82);
            panelData_CIM.Name = "panelData_CIM";
            panelData_CIM.Size = new Size(942, 744);
            panelData_CIM.TabIndex = 5;
            // 
            // labelMin_Title
            // 
            labelMin_Title.AutoSize = true;
            labelMin_Title.Location = new Point(30, 23);
            labelMin_Title.Name = "labelMin_Title";
            labelMin_Title.Size = new Size(81, 20);
            labelMin_Title.TabIndex = 2;
            labelMin_Title.Text = "Минимум:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelAvg_CIM);
            groupBox4.Controls.Add(labelAvgTitle_CIM);
            groupBox4.Controls.Add(labelMax_CIM);
            groupBox4.Controls.Add(labelMaxTitle_CIM);
            groupBox4.Controls.Add(labelMin_CIM);
            groupBox4.Controls.Add(labelMin_Title);
            groupBox4.Location = new Point(28, 846);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(932, 83);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Статистика";
            // 
            // labelAvg_CIM
            // 
            labelAvg_CIM.AutoSize = true;
            labelAvg_CIM.Location = new Point(612, 23);
            labelAvg_CIM.Name = "labelAvg_CIM";
            labelAvg_CIM.Size = new Size(0, 20);
            labelAvg_CIM.TabIndex = 7;
            // 
            // labelAvgTitle_CIM
            // 
            labelAvgTitle_CIM.AutoSize = true;
            labelAvgTitle_CIM.Location = new Point(535, 23);
            labelAvgTitle_CIM.Name = "labelAvgTitle_CIM";
            labelAvgTitle_CIM.Size = new Size(71, 20);
            labelAvgTitle_CIM.TabIndex = 6;
            labelAvgTitle_CIM.Text = "Среднее:";
            // 
            // labelMax_CIM
            // 
            labelMax_CIM.AutoSize = true;
            labelMax_CIM.Location = new Point(336, 23);
            labelMax_CIM.Name = "labelMax_CIM";
            labelMax_CIM.Size = new Size(0, 20);
            labelMax_CIM.TabIndex = 5;
            // 
            // labelMaxTitle_CIM
            // 
            labelMaxTitle_CIM.AutoSize = true;
            labelMaxTitle_CIM.Location = new Point(245, 23);
            labelMaxTitle_CIM.Name = "labelMaxTitle_CIM";
            labelMaxTitle_CIM.Size = new Size(85, 20);
            labelMaxTitle_CIM.TabIndex = 4;
            labelMaxTitle_CIM.Text = "Максимум:";
            // 
            // labelMin_CIM
            // 
            labelMin_CIM.AutoSize = true;
            labelMin_CIM.Location = new Point(117, 23);
            labelMin_CIM.Name = "labelMin_CIM";
            labelMin_CIM.Size = new Size(0, 20);
            labelMin_CIM.TabIndex = 3;
            // 
            // buttonSave_CIM
            // 
            buttonSave_CIM.Location = new Point(6, 21);
            buttonSave_CIM.Name = "buttonSave_CIM";
            buttonSave_CIM.Size = new Size(93, 29);
            buttonSave_CIM.TabIndex = 7;
            buttonSave_CIM.Text = "Сохранить";
            buttonSave_CIM.UseVisualStyleBackColor = true;
            buttonSave_CIM.Click += buttonSave_CIM_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonLoad_CIM);
            groupBox5.Controls.Add(buttonSave_CIM);
            groupBox5.Location = new Point(743, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(217, 64);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Файл";
            // 
            // buttonLoad_CIM
            // 
            buttonLoad_CIM.Location = new Point(118, 21);
            buttonLoad_CIM.Name = "buttonLoad_CIM";
            buttonLoad_CIM.Size = new Size(93, 29);
            buttonLoad_CIM.TabIndex = 8;
            buttonLoad_CIM.Text = "Загрузить";
            buttonLoad_CIM.UseVisualStyleBackColor = true;
            buttonLoad_CIM.Click += buttonLoad_CIM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1053);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panelData_CIM);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CIM).EndInit();
            panelData_CIM.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd_CIM;
        private Button buttonDelete_CIM;
        private Button buttonStatistics_CIM;
        private GroupBox groupBox1;
        private ComboBox comboFilter_CIM;
        private GroupBox groupBox2;
        private TextBox textBoxSearch_CIM;
        private GroupBox groupBox3;
        private DataGridView dataGridView_CIM;
        private Panel panelData_CIM;
        private DataGridViewTextBoxColumn columnShopId_CIM;
        private DataGridViewTextBoxColumn columnShopName_CIM;
        private DataGridViewTextBoxColumn columnShopAddress_CIM;
        private DataGridViewTextBoxColumn columnShopPhone_CIM;
        private DataGridViewTextBoxColumn columnShopRevenue_CIM;
        private Label labelMin_Title;
        private GroupBox groupBox4;
        private Label labelMin_CIM;
        private Label labelAvg_CIM;
        private Label labelAvgTitle_CIM;
        private Label labelMax_CIM;
        private Label labelMaxTitle_CIM;
        private Button buttonSave_CIM;
        private GroupBox groupBox5;
        private Button buttonLoad_CIM;
    }
}
