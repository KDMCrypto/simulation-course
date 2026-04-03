namespace lab9
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
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            double lambda = (double)lambda_form.Value; // Интенсивность входящего потока
            double mu = (double)mu_form.Value;     // Интенсивность обслуживания
            int totalRequests = (int)N_form.Value; // Количество заявок для моделирования

            if (lambda >= mu)
            {
                MessageBox.Show("Система будет перегружена, так как lambda >= mu");
            }

            double currentTime = 0; // текущее время
            double nextArrival = 0; // слудующее прибытие
            double nextCompletion = double.MaxValue; // время ухода текущего 

            int queueCount = 0; // очередь
            int processedRequests = 0; // подсчет обработанных заявок

            // Статистика
            double sumWaitTime = 0;         // Сумма времени ожидания всех заявок
            double sumTimeInSystem = 0;     // Сумма времени нахождения в системе
            double areaQueue = 0;           // Для средней длины очереди
            double lastEventTime = 0;       // Время предыдущего события

            listBox1.Items.Clear();
            listBox1.Items.Add("Статистика:");

            // Очередь для хранения времени прихода каждой заявки
            Queue<double> arrivalTimes = new Queue<double>();

            while (processedRequests < totalRequests)
            {
                areaQueue += queueCount * (currentTime - lastEventTime);
                lastEventTime = currentTime;
                
                if (nextArrival < nextCompletion)
                {
                    // Приход заявки
                    currentTime = nextArrival;

                    if (nextCompletion == double.MaxValue) // Канал свободен
                    {
                        double serviceTime = ExpTime(mu);
                        nextCompletion = currentTime + serviceTime;
                        sumTimeInSystem += serviceTime;
                    }
                    else // Канал занят, встаем в очередь
                    {
                        queueCount++;
                        arrivalTimes.Enqueue(currentTime);
                        chart1.Series[0].Points.AddXY(currentTime, queueCount);
                    }

                    // Планируем следующий приход
                    nextArrival = currentTime + ExpTime(lambda);
                }
                else
                {
                    // Завершение обслуживания
                    currentTime = nextCompletion;
                    processedRequests++;

                    if (queueCount > 0)
                    {
                        // Берем человека из очереди
                        double arrival = arrivalTimes.Dequeue();
                        double waitTime = currentTime - arrival; // Сколько он простоял в очереди
                        sumWaitTime += waitTime;

                        double serviceTime = ExpTime(mu);
                        sumTimeInSystem += (waitTime + serviceTime); // Время в очереди + время обслуживания

                        queueCount--;
                        chart1.Series[0].Points.AddXY(currentTime, queueCount);
                        nextCompletion = currentTime + serviceTime;
                    }
                    else
                    {
                        nextCompletion = double.MaxValue; // Канал освободился
                    }
                }
            }

            areaQueue += queueCount * (currentTime - lastEventTime);
            double avgWaitTime = sumWaitTime / totalRequests; 
            double avgTimeInSystem = sumTimeInSystem / totalRequests; 
            double avgQueueLength = areaQueue / currentTime; 
            double avgSystemLength = avgQueueLength + (lambda / mu); 

            listBox1.Items.Add($"Среднее время ожидания: {avgWaitTime:F3} сек.");
            listBox1.Items.Add($"Среднее время в системе: {avgTimeInSystem:F3} сек.");
            listBox1.Items.Add($"Средняя длина очереди: {avgQueueLength:F3} чел.");
            listBox1.Items.Add($"Среднее число заявок в системе: {avgSystemLength:F3} чел.");
            listBox1.Items.Add($"Загрузка системы (ро): {lambda / mu:P2}");
        }

        // Генерация случайной величины с экспоненциальным распределением
        private double ExpTime(double rate)
        {
            return -Math.Log(1.0 - rnd.NextDouble()) / rate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
