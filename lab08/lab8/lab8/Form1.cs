using System.Windows.Forms.DataVisualization.Charting;

namespace lab8
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<int> requestsCounts = new List<int>(); // Массив для хранения числа запросов в каждом опыте
        public Form1()
        {
            InitializeComponent();
            chart1.Legends[0].Enabled = false;
        }

        // Гкнерация времени между заявками
        public double Tau_generation(double lambda)
        {
            double r = rnd.NextDouble();
            double tau = -Math.Log(r) / lambda;
            return tau;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            requestsCounts.Clear();
            listBox1.Items.Clear();
            double lambda = (double)intensity.Value; // Интенсивность потока
            int T = (int)T_mod.Value;     // Интервал времени наблюдения
            int N = (int)N_start.Value;        // Количество экспериментов для статистики


            // Моделирование потока событий
            for (int i = 0; i < N; i++)
            {
                double currentTime = 0.0;
                int count = 0;

                while (true)
                {
                    // Генерируем время до следующего запроса по экспоненциальному закону
                    double tau = Tau_generation(lambda);
                    currentTime += tau;

                    if (currentTime < T)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                requestsCounts.Add(count);
            }


            // эмпирическое среднее и дисперсия

            double emp_Mean = requestsCounts.Average();

            double emp_var = 0;
            for (int i = 0; i < N; i++)
            {
                emp_var += Math.Pow(requestsCounts[i] - emp_Mean, 2);
            }

            emp_var = emp_var / N;

            double theoreticalValue = lambda * T;

            listBox1.Items.Add($"Выборочное среднее: {emp_Mean:f2}");
            listBox1.Items.Add($"Выборочная дисперсия: {emp_var:f2}");

            listBox1.Items.Add($"------------------------------------------");

            listBox1.Items.Add($"Теоретическое среднее: {theoreticalValue:f2}");
            listBox1.Items.Add($"Теоретическая дисперсия: {theoreticalValue:f2}");

            // считаем эмпирическое распредление
            var frequencies = requestsCounts.GroupBy(x => x).OrderBy(g => g.Key).ToDictionary(g => g.Key, g => (double)g.Count() / N);


            chart1.Series.Clear();
            var series = chart1.Series.Add("Эмпирическое распределение");
            series.ChartType = SeriesChartType.Column;

            foreach (var kvp in frequencies)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}