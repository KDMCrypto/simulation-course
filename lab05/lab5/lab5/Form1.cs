namespace lab5
{
    public partial class Form1 : Form
    {

        RandLCG random = new RandLCG(Environment.TickCount);

        string[] answer_arr = {
            "Бесспорно",
            "Предрешено",
            "Никаких сомнений",
            "Определённо да",
            "Можешь быть уверен в этом",
            "Мне кажется — «да»",
            "Вероятнее всего",
            "Хорошие перспективы",
            "Знаки говорят — «да»",
            "Да",
            "Пока не ясно, попробуй снова",
            "Спроси позже",
            "Лучше не рассказывать",
            "Сейчас нельзя предсказать",
            "Сконцентрируйся и спроси опять",
            "Даже не думай",
            "Мой ответ — нет",
            "По моим данным — нет",
            "Перспективы не очень хорошие",
            "Весьма сомнительно"
        };

        double[] probabilities = Enumerable.Repeat(0.05, 20).ToArray(); // массив вероятностей

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p = 0.5;
            double a = random.NextDouble();
            if (a < p)
            {
                label2.Text = $"Да";
            }
            else
            {
                label2.Text = $"Нет";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen blackPen = new Pen(Color.Gray, 2))
            {
                e.Graphics.DrawLine(blackPen, 0, 0, this.Width, 0);
                e.Graphics.DrawLine(blackPen, 600, 0, 600, this.Height);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double alpha = random.NextDouble();
            double A = alpha;
            int k = 0;

            while (k < probabilities.Length)
            {
                A = A - probabilities[k];

                if (A <= 0)
                {
                    label3.Text = $"{answer_arr[k]}";
                    return;
                }
                k += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
