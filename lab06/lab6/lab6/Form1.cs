using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab6
{
    public partial class Form1 : Form
    {
        double[] chiTable = { 3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507,
                                  16.919, 18.307, 19.675, 21.026, 22.362, 23.685, 24.996, 26.296,
                                  27.587, 28.869, 30.144, 31.410 };
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].ReadOnly = true;
            chart1.Legends[0].Enabled = false;
            dataGridView1.RowCount = 5;
            NumSample.Value = 5;

            double[] defaultProbabilities = { 0.1, 0.2, 0.4, 0.2, 0.1 };

            // Заполняем только если строки реально создались
            for (int i = 0; i < dataGridView1.RowCount && i < defaultProbabilities.Length; i++)
            {
                dataGridView1.Rows[i].Cells[1].Value = defaultProbabilities[i];
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            UpdateProbabilitySum();

            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.Series[0]["PointWidth"] = "0.8";

            chart2.Legends[0].Enabled = false;
            chart2.Series.Add("Density");
            chart2.Series["Density"].ChartType = SeriesChartType.Spline;
            chart2.Series["Density"].BorderWidth = 3;
            chart2.Series["Density"].Color = Color.Red;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // логика для лабы 6.1
        private void Start1_Click(object sender, EventArgs e)
        {

            int m = (int)NumSample.Value;
            double[] pArray = new double[m];

            DRV_simulator simulator = new DRV_simulator();

            for (int i = 0; i < m; i++)
            {
                var value = dataGridView1.Rows[i].Cells[1].Value;
                if (value == null || string.IsNullOrWhiteSpace(value.ToString())) return;

                pArray[i] = Convert.ToDouble(value.ToString().Replace('.', ','));
            }


            // Теоретические мат ожидпние и дисперсия
            double E_theor = 0;
            for (int i = 0; i < m; i++) E_theor += (i + 1) * pArray[i];

            double D_theor = 0;
            for (int i = 0; i < m; i++) D_theor += Math.Pow(i + 1, 2) * pArray[i];
            D_theor -= Math.Pow(E_theor, 2);

            // Цикл 
            int N = (int)N_experiment.Value;
            int[] frequencies = new int[m];

            for (int i = 0; i < N; i++)
            {
                int index = simulator.generate_DRV(pArray);
                frequencies[index]++;
            }

            // Эмпирические расчеты
            double E_emp = 0;
            for (int i = 0; i < m; i++) E_emp += (i + 1) * ((double)frequencies[i] / N);

            double D_emp = 0;
            for (int i = 0; i < m; i++) D_emp += Math.Pow(i + 1, 2) * ((double)frequencies[i] / N);
            D_emp -= Math.Pow(E_emp, 2);

            // Относительные погрешности
            double errorE = Math.Abs(E_emp - E_theor) / E_theor;
            double errorD = Math.Abs(D_emp - D_theor) / D_theor;

            // Хи-квадрат 
            double chiSq = 0;
            for (int i = 0; i < m; i++)
                chiSq += Math.Pow(frequencies[i], 2) / (N * pArray[i]);
            chiSq -= N;


            // Применяем критерий Хи-квадрат

            int df = m - 1; // степени свободы
            double criticalValue = chiTable[df - 1];

            if (chiSq < criticalValue)
            {
                label_Chi.Text = $"Гипотеза верна (Хи-квадрат: {chiSq:F3} < {criticalValue})";
                label_Chi.ForeColor = Color.Green;
            }
            else
            {
                label_Chi.Text = $"Гипотеза неверна (Хи-квадрат: {chiSq:F3} > {criticalValue})";
                label_Chi.ForeColor = Color.Red;
            }


            labelMean.Text = $"{E_emp:F4}";
            labelVar.Text = $"{D_emp:F4}";

            labelErrorMean.Text = $"{(errorE * 100):F2}%";
            labelErrorVar.Text = $"{(errorD * 100):F2}%";


            // Грфик
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < m; i++)
            {
                double empiricalProb = (double)frequencies[i] / N;
                chart1.Series[0].Points.AddXY(i + 1, empiricalProb);
                chart1.Series[0].Points[i].Label = $"{empiricalProb:F3}";
            }

        }


        //Логика для лабы 6.2
        private void Start2_Click(object sender, EventArgs e)
        {
            NRV_Simulator simulator_2 = new NRV_Simulator();

            double mean_2 = (double)mean2.Value;
            double var_2 = (double)var2.Value;
            int N_2 = (int)N2_experiment.Value;

            double[] data = new double[N_2];

            double sum = 0;
            for (int i = 0; i < N_2; i++)
            {
                data[i] = simulator_2.Generate(mean_2, Math.Sqrt(var_2));
                sum += data[i];
            }

            // Выборочное средниее и дисперсия
            double M_emp = sum / N_2;

            double sumSqDiff = 0;
            for (int i = 0; i < N_2; i++) sumSqDiff += Math.Pow(data[i] - M_emp, 2);
            double D_emp = sumSqDiff / N_2;

            
            int k = (int)Math.Floor(1 + 3.322 * Math.Log10(N_2)); // подсчет кол-ва диапазонов
            if (k < 5) k = 5;

            // границы интервалов
            double min = data.Min();
            double max = data.Max();

            // ширина интервала
            double h = (max - min) / k;
            
            // подсчет попаданий занчений в интервалы
            int[] counts = new int[k];
            foreach (double x in data)
            {
                int idx = (int)((x - min) / h);
                if (idx >= k) idx = k - 1;
                if (idx < 0) idx = 0;
                counts[idx]++;
            }


            // Хи-квадрат + отрисовка
            chart2.Series[0].Points.Clear();
            double chiSq = 0;

            for (int i = 0; i < k; i++)
            {
                double left = min + i * h;
                double right = left + h;
                double mid = left + h / 2;

                // Теоретическая вероятность попадания в интервал. Используем упрощенную формулу через плотность в середине интервала
                double p_theor = (1.0 / (Math.Sqrt(var_2) * Math.Sqrt(2 * Math.PI))) * Math.Exp(-Math.Pow(mid - mean_2, 2) / (2 * var_2)) * h;

                if (p_theor > 0)
                    chiSq += Math.Pow(counts[i] - N_2 * p_theor, 2) / (N_2 * p_theor);

                chart2.Series[0].Points.AddXY(Math.Round(mid, 2), (double)counts[i] / N_2);
            }


            // Относительные погрешности
            double errorE = Math.Abs(M_emp - mean_2) / (Math.Abs(mean_2) < 0.0001 ? 1 : Math.Abs(mean_2));
            double errorD = Math.Abs(D_emp - var_2) / var_2;


            // Хи-квадрат
            int df = k - 1;

            double criticalValue = chiTable[df - 1];
            if (chiSq < criticalValue)
            {
                label_Chi_2.Text = $"Гипотеза верна ({chiSq:F3} < {criticalValue})";
                label_Chi_2.ForeColor = Color.Green;
            }
            else
            {
                label_Chi_2.Text = $"Гипотеза неверна ({chiSq:F3} > {criticalValue})";
                label_Chi_2.ForeColor = Color.Red;
            }


            // отрисовка кривой плотности
            chart2.Series["Density"].Points.Clear();

            double step = (max - min) / 100;

            for (double x = min; x <= max; x += step)
            {
                double f_x = (1.0 / (Math.Sqrt(var_2) * Math.Sqrt(2 * Math.PI))) * Math.Exp(-Math.Pow(x - mean_2, 2) / (2 * var_2));

                chart2.Series["Density"].Points.AddXY(x, f_x * h);
            }

            labelMean2.Text = $"{M_emp:F4}";
            labelVar2.Text = $"{D_emp:F4}";
            labelMeanError2.Text = $"{(errorE * 100):F2}%";
            labelVarError2.Text = $"{(errorD * 100):F2}%";


            var area = chart2.ChartAreas[0];

            // настройки графика
            area.AxisX.Interval = h;
            area.AxisX.LabelStyle.Format = "F2";
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.MajorGrid.LineColor = Color.LightGray;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
        }


        // log вероятности
        private void CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                bool isValid = UpdateProbabilitySum();
                Start1.Enabled = isValid;
            }
        }

        // Метод для пересчета суммы
        private bool UpdateProbabilitySum()
        {
            double Var_sum = 1.0;
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var value = dataGridView1.Rows[i].Cells[1].Value;

                    if (value != null && double.TryParse(value.ToString().Replace('.', ','), out double p))
                    {
                        Var_sum -= p;
                    }
                }

                VarRes.Text = $"Остаток: {Var_sum:F3}";

                bool isCorrect = Math.Abs(Var_sum) < 0.0001;

                if (isCorrect)
                    VarRes.ForeColor = System.Drawing.Color.Green;
                else
                    VarRes.ForeColor = System.Drawing.Color.Red;

                return isCorrect;
            }
            catch
            {
                return false;
            }
        }


        private void numRowsCount_ValueChanged(object sender, EventArgs e)
        {
            int Rows = (int)NumSample.Value;

            dataGridView1.RowCount = Rows;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

    }

    public class DRV_simulator
    {
        Random random = new Random();

        public int generate_DRV(double[] array)
        {
            double alpha = random.NextDouble();
            double A = alpha;
            int k = 0;

            while (k < array.Length)
            {
                A = A - array[k];

                if (A <= 0)
                {
                    return k;
                }
                k += 1;
            }

        return array.Length - 1;

        }
    }


    public class NRV_Simulator
    {
        private Random random = new Random();

        public double Generate(double mean, double dis)
        {
            // Генерируем два равномерных числа от 0 до 1
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();

            // Формула Бокса-Мюллера для стандартного нормального распределения N(0, 1)
            double z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

            return mean + dis * z0;
        }
    }
};
