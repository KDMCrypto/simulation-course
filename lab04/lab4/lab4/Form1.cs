using Microsoft.VisualBasic;

namespace lab4
{
    public partial class Form1 : Form
    {
        int Sample;

        Random random = new Random();
        RandLCG SimpleRandom = new RandLCG();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Sample = (int)SampleSize.Value;

            double[] SimpleArrRand = new double[Sample];
            double[] ArrRand = new double[Sample];

            for (int i = 0; i < Sample; i++)
            {
                SimpleArrRand[i] = SimpleRandom.NextDouble();
                ArrRand[i] = random.NextDouble();
            }

            double Simple_mean = 1.0 / Sample * SimpleArrRand.Sum(); // выборочное среднее моего метода 
            double mean = 1.0 / Sample * ArrRand.Sum(); // выборочное среднее встроенного метода


            double SimpleVar = 0; // вывборочная дисперсия моего метода
            double Var = 0; // выборочная дисперсия встроенного метода

            for (int i = 0; i < Sample; i++)
            {
                SimpleVar += Math.Pow((SimpleArrRand[i] - Simple_mean), 2);
                Var += Math.Pow((ArrRand[i] - mean), 2);
            }

            SimpleVar = 1.0 / Sample * SimpleVar;

            Var = 1.0 / Sample * Var;

            listBox1.Items.Add($"Выборочное среднее базового датчика: {Simple_mean:F4}");
            listBox1.Items.Add($"Выборочное среднее встроенного датчика: {mean:F4}");

            listBox1.Items.Add($"Выборочная дисперсия базового датчика: {SimpleVar:F4}");
            listBox1.Items.Add($"Выборочная дисперсия встроенного датчика: {Var:F4}");

            listBox1.Items.Add($" ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }

    class RandLCG
    {
        private Int128 M = (Int128)Math.Pow(2, 63);
        private Int128 Beta = (Int128)Math.Pow(2, 32) + 3;
        private Int128 X;

        public RandLCG(int? Seed = null)
        {
            X = Seed ?? Beta;
        }

        public Int128 NextInt()
        {
            X = (Beta * X) % M;
            return X;
        }
        public double NextDouble()
        {
            return (double)NextInt() / (double)M;
        }
    }
}
