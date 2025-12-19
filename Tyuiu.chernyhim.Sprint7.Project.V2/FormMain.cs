using System.Windows.Forms;
using Tyuiu.chernyhim.Sprint7.Project.V2.Lib;
using System.IO;

namespace Tyuiu.chernyhim.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        private readonly string filePath_CIM = "shops.csv";
        private TextBox textBoxId_CIM;
        private TextBox textBoxName_CIM;
        private TextBox textBoxAddress_CIM;
        private TextBox textBoxPhone_CIM;
        private TextBox textBoxRevenue_CIM;
        private DataService ds = new DataService();


        public FormMain()
        {
            InitializeComponent();

            // In your FormMain constructor, after InitializeComponent(), add:
            textBoxId_CIM = new TextBox();
            textBoxName_CIM = new TextBox();
            textBoxAddress_CIM = new TextBox();
            textBoxPhone_CIM = new TextBox();
            textBoxRevenue_CIM = new TextBox();
        }

        private void SaveToCsv_CIM()
        {
            using (StreamWriter writer = new StreamWriter(filePath_CIM))
            {
                // Сохраняем заголовки
                var headers = dataGridView_CIM.Columns
                    .Cast<DataGridViewColumn>()
                    .Select(c => c.HeaderText);

                writer.WriteLine(string.Join(";", headers));

                // Сохраняем строки
                foreach (DataGridViewRow row in dataGridView_CIM.Rows)
                {
                    if (row.IsNewRow) continue;

                    var cells = row.Cells
                        .Cast<DataGridViewCell>()
                        .Select(c => c.Value?.ToString() ?? "");

                    writer.WriteLine(string.Join(";", cells));
                }
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            comboFilter_CIM.Items.Add("Все");
            comboFilter_CIM.Items.Add("Выручка < 50 000");
            comboFilter_CIM.Items.Add("50 000 – 100 000");
            comboFilter_CIM.Items.Add("> 100 000");

            comboFilter_CIM.SelectedIndex = 0;

            LoadFromCsv_CIM();
        }

        private void buttonAdd_CIM_Click(object sender, EventArgs e)
        {

            dataGridView_CIM.Rows.Add(
            textBoxId_CIM.Text,
            textBoxName_CIM.Text,
            textBoxAddress_CIM.Text,
            textBoxPhone_CIM.Text);
        }

        private void textBoxSearch_CIM_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch_CIM.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView_CIM.Rows)
            {
                row.Visible =
                row.Cells["columnShopName_CIM"].Value != null &&
                row.Cells["columnShopName_CIM"].Value.ToString().ToLower().Contains(search);
            }

        }

        private void buttonDelete_CIM_Click(object sender, EventArgs e)
        {
            if (dataGridView_CIM.SelectedRows.Count > 0)
            {
                dataGridView_CIM.Rows.Remove(dataGridView_CIM.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show(
                    "Выберите строку для удаления",
                    "Удаление",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void buttonStatistics_CIM_Click_1(object sender, EventArgs e)
        {
            if (dataGridView_CIM.Rows.Count == 0)
                return;

            int[] revenues = dataGridView_CIM.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => Convert.ToInt32(r.Cells["columnShopRevenue_CIM"].Value))
                .ToArray();

            var result = ds.CalculateStatistics(revenues);

            labelMin_CIM.Text = result.min.ToString();
            labelMax_CIM.Text = result.max.ToString();
            labelAvg_CIM.Text = result.avg.ToString("F2");
        }

        private void comboFilter_CIM_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_CIM.Rows)
            {
                // Служебные строки скрываем
                if (row.IsNewRow)
                {
                    row.Visible = false;
                    continue;
                }

                var cellVal = row.Cells["columnShopRevenue_CIM"].Value;

                if (cellVal == null || !int.TryParse(cellVal.ToString(), out int revenue))
                {
                    row.Visible = false;
                    continue;
                }

                switch (comboFilter_CIM.SelectedIndex)
                {
                    case 0:
                        row.Visible = true;
                        break;

                    case 1:
                        row.Visible = revenue < 50000;
                        break;

                    case 2:
                        row.Visible = revenue >= 50000 && revenue <= 100000;
                        break;

                    case 3:
                        row.Visible = revenue > 100000;
                        break;
                }
            }
        }

        private void buttonSave_CIM_Click(object sender, EventArgs e)
        {
            SaveToCsv_CIM();
            string fullPath = Path.GetFullPath(filePath_CIM);

            MessageBox.Show(
                $"Данные успешно сохранены.\n\nПуть к файлу:\n{fullPath}",
                "Сохранение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void LoadFromCsv_CIM()
        {
            if (!File.Exists(filePath_CIM))
                return;

            dataGridView_CIM.Rows.Clear();

            string[] lines = File.ReadAllLines(filePath_CIM);

            // Пропускаем первую строку (заголовки)
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(';');
                dataGridView_CIM.Rows.Add(values);
            }
        }

        private void buttonLoad_CIM_Click(object sender, EventArgs e)
        {
            LoadFromCsv_CIM();
        }

        private void buttonTotalRevenue_CIM_Click(object sender, EventArgs e)
        {
            if (dataGridView_CIM.Rows.Count == 0)
            {
                labelTotal_CIM.Text = "0";
                return;
            }

            int[] revenues = dataGridView_CIM.Rows
                .Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && r.Cells["columnShopRevenue_CIM"].Value != null)
                .Select(r => Convert.ToInt32(r.Cells["columnShopRevenue_CIM"].Value))
                .ToArray();

            int total = ds.CalculateTotalRevenue(revenues);

            labelTotal_CIM.Text = total.ToString();
        }
    }
}
