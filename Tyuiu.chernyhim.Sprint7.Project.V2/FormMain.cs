using System.Windows.Forms;
using Tyuiu.chernyhim.Sprint7.Project.V2.Lib;
namespace Tyuiu.chernyhim.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        private string[] pictures = new string[]
        {
            @"C:\Users\Илья\OneDrive\Desktop\pict\b9ae0e222a69cfadb35bf1dd414a117bc2e68a0d1c8c1a5ac5f121b999757b9d.jpg"
        };
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CIM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Очищаем и настраиваем DataGridView
            dataGridView_CIM.Columns.Clear();
            dataGridView_CIM.Rows.Clear();

            dataGridView_CIM.RowTemplate.Height = 60; // Высота 80 пикселей

            // Добавляем колонки
            dataGridView_CIM.Columns.Add("Merch", "Товар");
            dataGridView_CIM.Columns.Add("Price", "Цена");
            dataGridView_CIM.Columns.Add("Inf", "Описание");
            dataGridView_CIM.Columns.Add("Image", "Изображение");

            // Картинки
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Pictures";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Масштабирование
            imageColumn.Width = 100; // Ширина колонки с картинками
            dataGridView_CIM.Columns.Add(imageColumn);

            // Колонка с кнопками "Информация"
            DataGridViewButtonColumn infoButtonColumn = new DataGridViewButtonColumn();
            infoButtonColumn.Name = "InfoButton";
            infoButtonColumn.HeaderText = "Действия";
            infoButtonColumn.Text = "Информация";
            infoButtonColumn.UseColumnTextForButtonValue = true; // Все кнопки будут с текстом "Информация"
            infoButtonColumn.Width = 110;
            dataGridView_CIM.Columns.Add(infoButtonColumn);

            // Вывод данных
            for (int i = 0; i <=1 ; i++)
            {

                int rowIndex = i;
                // Добавляем картинку
                if (i < pictures.Length && File.Exists(pictures[i]))
                {
                    Image flagImage = Image.FromFile(pictures[i]);
                    dataGridView_CIM.Rows[rowIndex].Cells["Flag"].Value = flagImage;
                }
            }
            dataGridView_CIM.ReadOnly = true; //только для чтения
            dataGridView_CIM.AllowUserToAddRows = false; // Запретить добавление новых строк
            dataGridView_CIM.AllowUserToDeleteRows = false; // Запретить удаление строк
            dataGridView_CIM.AllowUserToOrderColumns = false; // Запретить перетаскивание колонок
            dataGridView_CIM.AllowUserToResizeRows = false; // Запрет изменения высоты колонки
            dataGridView_CIM.AllowUserToResizeColumns = false; // Запрет изменения ширины колонок
        }
    }
}
