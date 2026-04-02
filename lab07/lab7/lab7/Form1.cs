using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        // Матрица интенсивностей
        double[,] Q = new double[3, 3];

        int currentState; // текущее состояние
        double currentTime; // текущее время
        double totalTime; // общее время

        List<(double time, int state)> history = new();

        // Время в состояниях
        double[] stateTime = new double[3];

        // Стационарное распределение
        double[] pi = new double[3];

        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Enabled = false; // q11
            numericUpDown5.Enabled = false; // q22
            numericUpDown9.Enabled = false; // q33

            chart1.Series.Clear();
            chart1.Series.Add("Ясно");
            chart1.Series.Add("Облачно");
            chart1.Series.Add("Пасмурно");

            foreach (var s in chart1.Series)
                s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            timer1.Interval = 200;
            timer1.Tick += Timer_Tick;

            // чтобы автоматически диагональные элементы менялись
            numericUpDown2.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown3.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown4.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown6.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown7.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown8.ValueChanged += (s, e) => UpdateDiagonal();

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "F2";

            chart1.Series[0].BorderWidth = 3;  // Ясно
            chart1.Series[1].BorderWidth = 3;  // Облачно
            chart1.Series[2].BorderWidth = 3;  // Пасмурно
        }


        // Переход в след состояние
        private (int nextState, double dt) NextState(int state)
        {
            int i = state;

            double qii = Q[i, i];

            double alpha = random.NextDouble();

            double dt = Math.Log(alpha) / qii;

            // выбор следующего состояния
            double r = random.NextDouble();
            double sum = 0;

            for (int j = 0; j < 3; j++)
            {
                if (j == i) continue;

                double p = Q[i, j] / (-qii);
                sum += p;

                if (r < sum)
                    return (j, dt);
            }

            return (state, dt);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // Ввод интенсивностей
            double q12 = (double)numericUpDown2.Value;
            double q13 = (double)numericUpDown3.Value;

            double q21 = (double)numericUpDown4.Value;
            double q23 = (double)numericUpDown6.Value;

            double q31 = (double)numericUpDown7.Value;
            double q32 = (double)numericUpDown8.Value;

            // Формируем Q
            Q[0, 1] = q12;
            Q[0, 2] = q13;
            Q[0, 0] = -(q12 + q13);

            Q[1, 0] = q21;
            Q[1, 2] = q23;
            Q[1, 1] = -(q21 + q23);

            Q[2, 0] = q31;
            Q[2, 1] = q32;
            Q[2, 2] = -(q31 + q32);

            totalTime = (double)T.Value;

            // Сброс
            currentTime = 0;
            currentState = random.Next(0, 3);
            history.Clear();
            Array.Clear(stateTime, 0, stateTime.Length);

            foreach (var s in chart1.Series)
                s.Points.Clear();

            timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentTime >= totalTime)
            {
                timer1.Stop();
                CalculateStatistics();
                return;
            }

            var result = NextState(currentState);

            int nextState = result.nextState;
            double dt = result.dt;

            if (currentTime + dt > totalTime)
            {
                dt = totalTime - currentTime;  // берём только остаток
            }

            stateTime[currentState] += dt;
            currentTime += dt;

            history.Add((currentTime, currentState));

            // визуализация
            string[] stateNames = { "Ясно", "Облачно", "Пасмурно" };
            int currentDay = (int)Math.Floor(currentTime) + 1;

            log_Day.Text = $"День: {currentDay}\n" +
             $"{stateNames[currentState]}\n" +
             $"Время: {currentTime:F1} дн.";


            for (int i = 0; i < 3; i++)
            {
                double freq = stateTime[i] / currentTime;
                chart1.Series[i].Points.AddXY(currentTime, freq);
            }

            currentState = nextState;
        }


        private void CalculateStatistics()
        {
            // Вычисление эмпирического распределения
            double[] emp = new double[3];
            for (int i = 0; i < 3; i++)
                emp[i] = stateTime[i] / currentTime;

            // Матрица системы 
            double[,] matrix = {
                { Q[0, 0], Q[1, 0], Q[2, 0] },
                { Q[0, 1], Q[1, 1], Q[2, 1] },
                { 1,       1,       1       }
            };
            double[] constants = { 0, 0, 1 };

            // Решаем методом Крамера
            double det = Determinant3x3(matrix);

            if (Math.Abs(det) > 1e-9) // Проверка на вырожденность
            {
                for (int i = 0; i < 3; i++)
                {
                    pi[i] = Determinant3x3(ReplaceColumn(matrix, constants, i)) / det;
                }
            }

            // Вывод
            listBox1.Items.Clear();
            listBox1.Items.Add("СТАТИСТИКА");
            listBox1.Items.Add("------------------------");

            string[] names = { "Ясно", "Облачно", "Пасмурно" };

            for (int i = 0; i < 3; i++)
            {
                double diff = Math.Abs(emp[i] - pi[i]);
                listBox1.Items.Add($"{names[i]}: эмпирическая={emp[i]:F3} теоретическая={pi[i]:F3}");
                listBox1.Items.Add($"Разность={diff:F3}");
            }
        }

        // Вспомогательная функция для определителя 3x3
        private double Determinant3x3(double[,] m)
        {
            return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                   m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                   m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        // Замена столбца для метода Крамера
        private double[,] ReplaceColumn(double[,] m, double[] col, int colIndex)
        {
            double[,] res = (double[,])m.Clone();
            for (int i = 0; i < 3; i++) res[i, colIndex] = col[i];
            return res;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine("Время;Состояние");

                foreach (var h in history)
                    sw.WriteLine($"{h.time:F4};{h.state + 1}");

                sw.WriteLine();
                sw.WriteLine("Состояние;Общее время пребывания");

                for (int i = 0; i < 3; i++)
                    sw.WriteLine($"{i + 1};{stateTime[i]}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            history.Clear();
            Array.Clear(stateTime, 0, stateTime.Length);

            foreach (var s in chart1.Series)
                s.Points.Clear();

            listBox1.Items.Clear();
        }


        private void UpdateDiagonal()
        {
            numericUpDown1.Value = -(numericUpDown2.Value + numericUpDown3.Value);

            numericUpDown5.Value = -(numericUpDown4.Value + numericUpDown6.Value);

            numericUpDown9.Value = -(numericUpDown7.Value + numericUpDown8.Value);
        }

    }
}