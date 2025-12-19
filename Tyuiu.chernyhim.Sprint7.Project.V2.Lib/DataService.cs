namespace Tyuiu.chernyhim.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        // Двумерный массив:
        // строки — магазины
        // столбцы — показатели магазина
        // [0] — количество сотрудников
        // [1] — количество товаров
        // [2] — дневная выручка
        private int[,] shopsData = new int[,]
        {
            { 12, 340, 56000 },
            { 8, 210, 32000 },
            { 15, 500, 91000 },
            { 6, 150, 27000 },
            { 20, 800, 150000 }
        };

        // Возвращает весь массив (для вывода в таблицу)
        public int[,] GetMatrix()
        {
            return shopsData;
        }

        // Минимальная дневная выручка среди магазинов
        public int GetMinRevenue()
        {
            int min = shopsData[0, 2];

            for (int i = 0; i < shopsData.GetLength(0); i++)
            {
                if (shopsData[i, 2] < min)
                {
                    min = shopsData[i, 2];
                }
            }

            return min;
        }

        // Максимальная дневная выручка
        public int GetMaxRevenue()
        {
            int max = shopsData[0, 2];

            for (int i = 0; i < shopsData.GetLength(0); i++)
            {
                if (shopsData[i, 2] > max)
                {
                    max = shopsData[i, 2];
                }
            }

            return max;
        }

        // Средняя дневная выручка по сети
        public double GetAverageRevenue()
        {
            double sum = 0;

            for (int i = 0; i < shopsData.GetLength(0); i++)
            {
                sum += shopsData[i, 2];
            }

            return sum / shopsData.GetLength(0);
        }
    }
}
