using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double[,] P;

        private List<int> history = new List<int>();
        private int currentState = 1;
        private int currentDay = 0;
        private int totalDays;

        int[] counts = new int[4];

        private double[] empGlobal = new double[4];
        private double[] piGlobal = new double[3];
        private double[,] empiricalP = new double[3, 3];

        public Form1()
        {
            InitializeComponent();

            chart1.Series.Clear();

            chart1.Series.Add("Ясно");
            chart1.Series.Add("Облачно");
            chart1.Series.Add("Пасмурно");

            chart1.Series["Ясно"].BorderWidth = 3;
            chart1.Series["Облачно"].BorderWidth = 3;
            chart1.Series["Пасмурно"].BorderWidth = 3;

            foreach (var s in chart1.Series)
            {
                s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

            timer1.Interval = 300; // скорость анимации, мс
            Start.Click += Start_Click;

            P = new double[3, 3] {
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Click(object? sender, EventArgs e)
        {
            Array.Clear(counts, 0, counts.Length);

            foreach (var s in chart1.Series)
                s.Points.Clear();
            // Матрица вероятностей перехода
            double p11 = (double)numericUpDown1.Value;
            double p12 = (double)numericUpDown2.Value;
            double p13 = (double)numericUpDown3.Value;

            double p21 = (double)numericUpDown4.Value;
            double p22 = (double)numericUpDown5.Value;
            double p23 = (double)numericUpDown6.Value;

            double p31 = (double)numericUpDown7.Value;
            double p32 = (double)numericUpDown8.Value;
            double p33 = (double)numericUpDown9.Value;

            totalDays = (int)Days.Value;

            P = new double[3, 3] {
            { p11, p12, p13 },
            { p21, p22, p23 },
            { p31, p32, p33 }
            };

            // проверка суммы в строчках
            for (int i = 0; i < 3; i++)
            {
                double rowSum = 0;
                for (int j = 0; j < 3; j++)
                    rowSum += P[i, j];

                if (Math.Abs(rowSum - 1.0) > 0.0001)
                {
                    MessageBox.Show($"Сумма вероятностей в строке {i + 1} должна быть равна 1");
                    return;
                }
            }

            // Сброс состояния перед запуском
            history.Clear();
            currentDay = 0;
            currentState = random.Next(1, 4); ;

            // Запуск таймера
            timer1.Start();

            // Блокируем кнопку
            Start.Enabled = false;
            save_button.Enabled = false;
        }

        private int NextState(int current)
        {
            double r = random.NextDouble();
            double sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += P[current - 1, j];
                if (r < sum) return j + 1;
            }
            return 3;
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            if (currentDay >= totalDays)
            {
                timer1.Stop();
                Statistics();
                Start.Enabled = true;
                save_button.Enabled = true;
                return;
            }

            currentDay++;
            history.Add(currentState);

            counts[currentState]++;

            // считаем текущие частоты
            double f1 = (double)counts[1] / currentDay;
            double f2 = (double)counts[2] / currentDay;
            double f3 = (double)counts[3] / currentDay;

            // добавляем точки на график
            chart1.Series[0].Points.AddXY(currentDay, f1);
            chart1.Series[1].Points.AddXY(currentDay, f2);
            chart1.Series[2].Points.AddXY(currentDay, f3);

            // Вывод в лог
            string[] names = { "Ясно", "Облачно", "Пасмурно" };
            log_Day.Text = $"День {currentDay,3}: {names[currentState - 1]}\n";

            currentState = NextState(currentState);
        }

        private void Statistics()
        {
            // Эмпирические частоты
            int[] countsLocal = new int[4];
            foreach (var s in history) countsLocal[s]++;

            for (int i = 1; i <= 3; i++)
                empGlobal[i] = (double)countsLocal[i] / history.Count;

            // Теоретическое стационарное распределение
            double[] pi = { 1.0 / 3, 1.0 / 3, 1.0 / 3 };
            double[] next = new double[3];

            for (int iter = 0; iter < 10000; iter++)
            {
                for (int j = 0; j < 3; j++)
                {
                    next[j] = 0;
                    for (int i = 0; i < 3; i++)
                        next[j] += pi[i] * P[i, j];
                }
                Array.Copy(next, pi, 3);
            }

            Array.Copy(pi, piGlobal, 3);

            // Эмпирическая матрица переходов
            int[,] transitions = new int[3, 3];

            for (int i = 0; i < history.Count - 1; i++)
            {
                int from = history[i] - 1;
                int to = history[i + 1] - 1;
                transitions[from, to]++;
            }

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                    sum += transitions[i, j];

                for (int j = 0; j < 3; j++)
                    empiricalP[i, j] = sum > 0 ? (double)transitions[i, j] / sum : 0;
            }

            // Вывод
            string[] names = { "Ясно", "Облачно", "Пасмурно" };

            listBox1.Items.Clear();
            listBox1.Items.Add($"СТАТИСТИКА ({history.Count} дней)");
            listBox1.Items.Add(new string('-', 55));
            listBox1.Items.Add($"{"Состояние",-12} {"Эмпир.",-10} {"Теор.",-10} {"Разн.",-10}");

            double avgError = 0;

            for (int i = 1; i <= 3; i++)
            {
                double diff = Math.Abs(empGlobal[i] - piGlobal[i - 1]);
                avgError += diff;

                listBox1.Items.Add(
                    $"{names[i - 1],-12} {empGlobal[i],-10:f3} {piGlobal[i - 1],-10:f3} {diff,-10:f3}"
                );
            }

            avgError /= 3;
            listBox1.Items.Add(new string('-', 55));
            listBox1.Items.Add($"Средняя ошибка: {avgError:f4}");

            // Матрица переходов
            listBox1.Items.Add("\nМатрица переходов (эмпирическая):");

            for (int i = 0; i < 3; i++)
            {
                string row = "";
                for (int j = 0; j < 3; j++)
                    row += $"{empiricalP[i, j]:f3}  ";
                listBox1.Items.Add(row);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            sfd.FileName = "weather.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string[] names = { "Ясно", "Облачно", "Пасмурно" };

                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // История
                    sw.WriteLine("День;Состояние;Название");

                    for (int i = 0; i < history.Count; i++)
                        sw.WriteLine($"{i + 1};{history[i]};{names[history[i] - 1]}");

                    // Распределения
                    sw.WriteLine();
                    sw.WriteLine("Распределение:");
                    sw.WriteLine("Состояние;Эмпирическое;Теоретическое;Разница");

                    for (int i = 1; i <= 3; i++)
                    {
                        double diff = Math.Abs(empGlobal[i] - piGlobal[i - 1]);

                        sw.WriteLine($"{names[i - 1]};{empGlobal[i]:f4};{piGlobal[i - 1]:f4};{diff:f4}");
                    }

                    // Матрица переходов
                    sw.WriteLine();
                    sw.WriteLine("Матрица переходов (эмпирическая):");

                    for (int i = 0; i < 3; i++)
                    {
                        sw.WriteLine($"{empiricalP[i, 0]:f4};{empiricalP[i, 1]:f4};{empiricalP[i, 2]:f4}");
                    }
                }

                MessageBox.Show("Данные сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            history.Clear();
            currentDay = 0;
            currentState = 1;

            Array.Clear(counts, 0, counts.Length);

            foreach (var s in chart1.Series)
                s.Points.Clear();

            log_Day.Text = "";
            listBox1.Items.Clear();

            Start.Enabled = true;
            save_button.Enabled = false;
        }
    }
    
}
