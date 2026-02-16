using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab2
{
    public partial class Form1 : Form
    {
        int p = 8900, c = 385, lambda = 385; // медь  // int p = 7800, c = 460, lambda = 46; сталь              
        double time, L, h, tau, A, C, B;
        double TL, TN, T0, F;
        public Form1()
        {
            InitializeComponent();

            // настройка графика
            chart1.ChartAreas[0].AxisY.Crossing = 0;   // ось Y проходит через X=0
            chart1.ChartAreas[0].AxisX.LineWidth = 2;
            chart1.ChartAreas[0].AxisX.LineColor = Color.Black;

            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "T";

            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            time = (double)max_t.Value; // время моделирования
            tau = (double)Step_t.Value; // шаг по времени 

            L = (double)thickness.Value; // толщина пластины
            h = (double)Step_space.Value; // шаг по пространству

            TL = (double)t_left.Value; // температура слева от двери 
            TN = (double)t_right.Value; // температура справа от двери 
            T0 = (double)T_door.Value; // температура двери исходная


            int steps = (int)(L / h) + 1; // шаги по сетке 
            int st_time = (int)(time / tau) + 1; // число временных меток

            double[] T = new double[steps];
            double[] alpha = new double[steps];
            double[] beta = new double[steps];

            A = C = lambda / (h * h);
            B = 2 * A + p * c / tau;

            for (int i = 0; i < steps; i++)
            {
                T[i] = T0;
            }

            T[0] = TL;
            T[^1] = TN;

            for (int n = 1; n < st_time; n++)
            {
                alpha[0] = 0;
                beta[0] = TL;

                for (int i = 1; i < steps; i++)
                {
                    alpha[i] = A / (B - C * alpha[i - 1]);

                    F = -p * c * T[i] / tau;

                    beta[i] = (C * beta[i - 1] - F) / (B - C * alpha[i - 1]);
                }

                for (int i = steps - 2; i > 0; i--)
                {
                    T[i] = alpha[i] * T[i + 1] + beta[i];

                }
                // проверка
                /*
                string timeString = $"t = {n * tau:F2} с: ";
                for (int i = 0; i < steps; i++)
                {
                    timeString += $"{T[i]:F2} ";
                }
                listBox1.Items.Add(timeString);*/
            }
            sw.Stop();

            chart1.Series[0].Points.Clear();
            for (int i = 0; i < steps; i++)
            {
                chart1.Series[0].Points.AddXY(i * h, T[i]);
            }

            // настройка графика
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = L;


            listBox1.Items.Add($"Шаг по времени: {tau} | Шаг по пространству: {h}");
            listBox1.Items.Add($"Температура тела в центральной точке: {T[(int)(steps / 2)]:F2}");
            listBox1.Items.Add($"Время работы программы: {sw.ElapsedMilliseconds / 1000.0} с");
            listBox1.Items.Add($" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
