namespace Tyuiu.chernyhim.Sprint7.Project.V2.Lib
{
    public class DataService
    {

        /// Расчёт минимальной, максимальной и средней выручки сети магазинов

        public (int min, int max, double avg) CalculateStatistics(int[] revenues)
        {
            if (revenues == null || revenues.Length == 0)
                return (0, 0, 0);

            int min = revenues[0];
            int max = revenues[0];
            double sum = 0;

            foreach (int revenue in revenues)
            {
                if (revenue < min) min = revenue;
                if (revenue > max) max = revenue;
                sum += revenue;
            }

            double avg = sum / revenues.Length;

            return (min, max, avg);
        }
        
        /// Расчёт общей выручки сети магазинов
        
        public int CalculateTotalRevenue(int[] revenues)
        {
            if (revenues == null || revenues.Length == 0)
                return 0;

            int sum = 0;

            foreach (int revenue in revenues)
            {
                sum += revenue;
            }

            return sum;
        }
    }
}
