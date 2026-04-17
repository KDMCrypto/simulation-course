using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab10
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            chart1.Legends[0].Enabled = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "F2";

            var area = chart1.ChartAreas[0];
            area.AxisX.Title = "Время";
            area.AxisX.TitleFont = new Font("Arial", 10);
            area.AxisY.Title = "Количество заявок в очереди";
            area.AxisY.TitleFont = new Font("Arial", 10);

            chart2.Series[0].ChartType = SeriesChartType.Column;
            chart2.ChartAreas[0].AxisX.Title = "Занято приборов";
            chart2.ChartAreas[0].AxisY.Title = "Вероятность";
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.Legends[0].Enabled = false;
        }
        private void Start_Button_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series) series.Points.Clear();
            foreach (var series in chart2.Series) series.Points.Clear();

            // Параметры
            double lambda = (double)lambda_form.Value;
            double mu = (double)mu_form.Value;
            int totalRequests = (int)simulation_time_form.Value;

            int numServers = (int)devices_form.Value;           // Количество приборов обслуживания
            double maxWaitTime = (double)max_time_form.Value;     // Максимальное время ожидания в очереди

            if (lambda >= mu * numServers)
            {
                MessageBox.Show("Предупреждение: Система может быть перегружена (lambda >= mu * c). Очередь будет расти.");
            }

            // Инициализация объектов для Серверов и Заявок
            List<Server> servers = Enumerable.Range(0, numServers).Select(i => new Server()).ToList();
            Queue<Request> queue = new Queue<Request>();

            // Переменные моделирования 
            double currentTime = 0;
            double nextArrival = ExpTime(lambda);

            int processedRequests = 0; // обслуженные заявки
            int abandonedRequests = 0; // ушедшие заявки

            // Переменные для статистики
            double sumWaitTime = 0;
            double sumTimeInSystem = 0;
            double areaQueue = 0;
            double lastEventTime = 0;

            // Словарь для распределения занятых серверов
            Dictionary<int, double> serverBusyDistribution = new Dictionary<int, double>();

            listBox1.Items.Clear();
            listBox1.Items.Add($"Статистика M/M/{numServers}:");

            // Моделирование 
            while (processedRequests + abandonedRequests < totalRequests)
            {
                // Вычисляем время ближайшего события
                double nextCompletion = servers.Min(s => s.NextCompletionTime);
                double nextAbandon = queue.Count > 0 ? queue.Peek().AbandonTime : double.MaxValue;

                // Ближайшее событие из трех возможных
                double nextEventTime = Math.Min(nextArrival, Math.Min(nextCompletion, nextAbandon));

                // расчет распределения занятости серверов
                double deltaTime = nextEventTime - lastEventTime;
                int busyCount = servers.Count(s => s.IsBusy);
                if (!serverBusyDistribution.ContainsKey(busyCount)) serverBusyDistribution[busyCount] = 0;
                serverBusyDistribution[busyCount] += deltaTime;

                areaQueue += queue.Count * deltaTime;
                lastEventTime = nextEventTime;
                currentTime = nextEventTime;

                // Уход по нетерпеливости
                if (currentTime == nextAbandon)
                {
                    queue.Dequeue();
                    abandonedRequests++;
                    chart1.Series[0].Points.AddXY(currentTime, queue.Count);
                }

                // Завершение обслуживания
                else if (currentTime == nextCompletion)
                {
                    // Находим все приборы, которые закончили работу в этот момент времени
                    var finishingServers = servers.Where(s => s.IsBusy && s.NextCompletionTime == currentTime).ToList();

                    foreach (var server in finishingServers)
                    {
                        server.IsBusy = false;
                        server.NextCompletionTime = double.MaxValue;
                        processedRequests++;

                        // Если в очереди кто-то есть, сразу отправляем на этот освободившийся прибор
                        if (queue.Count > 0)
                        {
                            var req = queue.Dequeue();

                            double waitTime = currentTime - req.ArrivalTime;
                            sumWaitTime += waitTime;

                            double serviceTime = ExpTime(mu);
                            sumTimeInSystem += (waitTime + serviceTime);

                            server.IsBusy = true;
                            server.NextCompletionTime = currentTime + serviceTime;

                            chart1.Series[0].Points.AddXY(currentTime, queue.Count);
                        }
                    }
                }

                // Приход новой заявки
                else if (currentTime == nextArrival)
                {
                    Request newReq = new Request
                    {
                        ArrivalTime = currentTime,
                        AbandonTime = currentTime + maxWaitTime // задаем время, когда у заяки кончится терпение
                    };

                    var freeServer = servers.FirstOrDefault(s => !s.IsBusy); // Ищем свободный сервер

                    if (freeServer != null)
                    {
                        // Обслуживаем без очереди
                        freeServer.IsBusy = true;
                        double serviceTime = ExpTime(mu);
                        freeServer.NextCompletionTime = currentTime + serviceTime;

                        sumTimeInSystem += serviceTime;
                    }
                    else
                    {
                        // встаем в очередь
                        queue.Enqueue(newReq);
                        chart1.Series[0].Points.AddXY(currentTime, queue.Count);
                    }

                    // Планируем приход следующего
                    nextArrival = currentTime + ExpTime(lambda);
                }
            }

            // Вывод результатов
            double avgWaitTime = sumWaitTime / (processedRequests > 0 ? processedRequests : 1);
            double avgTimeInSystem = sumTimeInSystem / (processedRequests > 0 ? processedRequests : 1);
            double avgQueueLength = areaQueue / currentTime;

            listBox1.Items.Add($"Всего заявок: {totalRequests}");
            listBox1.Items.Add($"Успешно обслужено: {processedRequests}");
            listBox1.Items.Add($"Ушли по тайм-ауту: {abandonedRequests} ({(double)abandonedRequests / totalRequests:P2})");
            listBox1.Items.Add($"Среднее время в очереди (для обслуженных): {avgWaitTime:F3}");
            listBox1.Items.Add($"Среднее время в системе (для обслуженных): {avgTimeInSystem:F3}");
            listBox1.Items.Add($"Средняя длина очереди: {avgQueueLength:F3}");

            double avgBusyServers = serverBusyDistribution.Sum(kvp => kvp.Key * kvp.Value) / currentTime;
            listBox1.Items.Add($"Среднее число занятых приборов: {avgBusyServers:F2}");
            listBox1.Items.Add($"Коэффициент загрузки: {(avgBusyServers / numServers):P2}");

            // вывод на график распределения количества занятых каналов
            var sortedBusy = serverBusyDistribution.Keys.OrderBy(k => k);
            foreach (var key in sortedBusy)
            {
                double prob = serverBusyDistribution[key] / currentTime;
                chart2.Series[0].Points.AddXY(key, prob);
            }
        }

        // Генерация случайной величины с экспоненциальным распределением
        private double ExpTime(double rate)
        {
            return -Math.Log(1.0 - rnd.NextDouble()) / rate;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Класс для запросов
    public class Request
    {
        public double ArrivalTime { get; set; } // время прибытия 
        public double AbandonTime { get; set; } // время отказа
    }

    // Класс сервера
    public class Server
    {
        public bool IsBusy { get; set; } // Флаг для определения занятости 
        public double NextCompletionTime { get; set; } = double.MaxValue; // поле для хранения времени завершения обслуживания заявки
    }
}
