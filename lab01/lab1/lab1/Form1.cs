using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class Form1 : Form
    {
        decimal C = 0.15m, p = 1.29m, g = 9.81m, dt; // C - коэффициент лобового сопротивления, p - плотность воздуха 
        decimal x, y, m, S, t, v0, cosa, sina, vx, k, vy, max_y;
        int count = 0;

        Color[] Colors = {Color.Red, Color.Blue,
            Color.Green, Color.Orange,
            Color.Purple, Color.Brown,
            Color.Pink, Color.Cyan };

        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 20;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
            {
                t = 0; x = 0;

                dt = Step.Value;
                S = Size.Value; // площадь поперечного сечения тела
                m = Weight.Value;
                y = Height.Value;
                v0 = Speed.Value;

                double a = (double)Angle.Value * Math.PI / 180;

                sina = (decimal)Math.Sin(a);
                cosa = (decimal)Math.Cos(a);

                k = C * S * p / (2 * m);

                vx = v0 * cosa;
                vy = v0 * sina;

                max_y = y;

                Series new_series = new Series();
                new_series.ChartType = SeriesChartType.Line;
                new_series.BorderWidth = 4;
                new_series.Name = $"График {count + 1}";
                chart1.Series.Add(new_series);

                chart1.Series[count].Color = Colors[count];
                chart1.Series[count].Points.AddXY(x, y);

                timer1.Enabled = true;
            }

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            chart1.Series.Clear();
            listBox1.Items.Clear();
            count = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;

            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));

            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;

            x = x + vx * dt;
            y = y + vy * dt;

            if (max_y < y) max_y = y;

            chart1.Series[count].Points.AddXY(x, y);

            if (y <= 0)
            {
                timer1.Enabled = false;
                listBox1.Items.Add($"График: {count+1}");
                listBox1.Items.Add($"Шаг: {dt:F3}");
                listBox1.Items.Add($"Дальность полета: {x:F3}");
                listBox1.Items.Add($"Максимальная высота: {max_y:F3}");
                listBox1.Items.Add($"Максимальная скорость в конечной точке: {v:F3}\n\n");
                listBox1.Items.Add("");
                count += 1;
            }
        }

    }
}
