namespace lab9
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {

            double lambda = (double)lambda_form.Value;
            double mu = (double)mu_form.Value;
            int totalRequests = (int)N_form.Value;

            double currentTime = 0;
            double nextArrival = 0;
            double nextCompletion = double.MaxValue;

            int processedRequests = 0; // Всего пришедших заявок
            int successfulRequests = 0; // Обслуженные заявки
            int rejectedRequests = 0; // для отказов

            listBox1.Items.Clear();
            listBox1.Items.Add("Статистика:");

            while (processedRequests < totalRequests)
            {
                if (nextArrival < nextCompletion)
                {
                    // Приход заявки
                    currentTime = nextArrival;
                    processedRequests++;

                    if (nextCompletion == double.MaxValue) // Если сервер свободен
                    {
                        double serviceTime = ExpTime(mu);
                        nextCompletion = currentTime + serviceTime;
                        successfulRequests++;
                    }
                    else // если сервер занят
                    {
                        rejectedRequests++; // Заявка просто теряется
                    }

                    nextArrival = currentTime + ExpTime(lambda);
                }
                else
                {
                    currentTime = nextCompletion;
                    nextCompletion = double.MaxValue; // Освобождаем сервер
                }
            }

            double pReject = (double)rejectedRequests / totalRequests;
            double q = 1 - pReject; // Относительная пропускная способность

            listBox1.Items.Add($"Всего заявок: {totalRequests}");
            listBox1.Items.Add($"Обслужено: {successfulRequests}");
            listBox1.Items.Add($"Отказано: {rejectedRequests}");
            listBox1.Items.Add($"Вероятность отказа: {pReject:P2}");
            listBox1.Items.Add($"Пропускная способность: {q:P2}");
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
