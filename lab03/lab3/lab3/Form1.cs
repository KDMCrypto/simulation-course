using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;

namespace lab3
{
    public partial class Form1 : Form
    {
        int[,] fields;

        int cellSize, rowsCount, colsCount;
        int[,] neighbourhood = { { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, -1 }, { 0, 1 }, { 1, -1 }, { 1, 0 }, { 1, 1 } };
        int EMPTY = 0, TREE = 1, FIRE = 2, WATER = 3;
        double[] NZ;
        double tempFactor;
        int p = 5, f = 2;



        Random random = new Random();

        private Brush[] colors = { Brushes.Brown, Brushes.Green, Brushes.Orange, Brushes.Blue }; // цвета для клеток
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            comboBox1.SelectedIndex = 0;

            UpdateGrid();
        }

        public int[,] Iteration(int[,] X)
        {
            int rows = X.GetLength(0);
            int cols = X.GetLength(1);
            int[,] X1 = new int[rows, cols];

            // Константы вероятностей 
            double p_d = p / 100.0; // p
            double f_d = f / 100.0;     // f
            double Diagonal_prob = 0.6;

            for (int iy = 1; iy < rows - 1; iy++)
            {
                for (int ix = 1; ix < cols - 1; ix++)
                {
                    if (X[iy, ix] == WATER) X1[iy, ix] = WATER;

                    else if (X[iy, ix] == EMPTY)
                    {
                        if (random.NextDouble() <= p_d)
                            X1[iy, ix] = TREE;
                    }

                    else if (X[iy, ix] == TREE)
                    {
                        X1[iy, ix] = TREE; // По умолчанию остается деревом
                        bool ignited = false;

                        for (int i = 0; i < 8; i++)
                        {
                            int dy = neighbourhood[i, 0];
                            int dx = neighbourhood[i, 1];

                            // Если сосед горит — загораемся сами
                            if (X[iy + dy, ix + dx] == FIRE && random.NextDouble() <= NZ[i] * tempFactor)
                            {

                                X1[iy, ix] = FIRE;
                                ignited = true;
                                break;
                            }
                        }

                        // выполнится, если дерево не загорелось от соседей
                        if (!ignited)
                        {
                            if (random.NextDouble() <= f_d)
                            {
                                X1[iy, ix] = FIRE;
                            }
                        }
                    }
                    // Горящее дерево превращается в пустое место
                    else if (X[iy, ix] == FIRE)
                    {
                        X1[iy, ix] = EMPTY;
                    }
                }
            }
            return X1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (fields == null) return;

            Graphics g = e.Graphics;

            for (int i = 0; i < fields.GetLength(0); i++) // Строки
            {
                for (int j = 0; j < fields.GetLength(1); j++) // Столбцы
                {
                    g.FillRectangle(colors[fields[i, j]], j * cellSize, i * cellSize, cellSize, cellSize);
                    g.DrawRectangle(Pens.Black, j * cellSize, i * cellSize, cellSize, cellSize);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }

            else
            {
                timer1.Enabled = true;
            }

        }

        private void UpdateGrid()
        {
            rowsCount = (int)rows.Value;
            colsCount = (int)columns.Value;

            if (rowsCount <= 0 || colsCount <= 0) return;

            fields = new int[rowsCount, colsCount];
            double forestFraction = 0.5; // заполнение лесом

            // создание начальной карты
            for (int iy = 1; iy < rowsCount - 1; iy++)
            {
                for (int ix = 1; ix < colsCount - 1; ix++)
                {
                    
                    if (random.NextDouble() < forestFraction)
                    {
                        fields[iy, ix] = TREE; // Устанавливаем дерево
                    }
                    else
                    {
                        fields[iy, ix] = EMPTY; // Пусто
                    }


                }
            }

            // Добавляем озера
            int numLakes = Math.Max(1, (rowsCount * colsCount) / 600);

            for (int i = 0; i < numLakes; i++)
            {
                // Выбираем случайный центр озера
                int cx = random.Next(3, colsCount - 3);
                int cy = random.Next(3, rowsCount - 3);

                // Случайный радиус озера
                int radius = random.Next(2, 6);

                // Проходим по квадрату вокруг центра озера
                for (int dy = -radius; dy <= radius; dy++)
                {
                    for (int dx = -radius; dx <= radius; dx++)
                    {
                        // Проверяем, попадает ли клетка в круг (x^2 + y^2 <= r^2)
                        if (dx * dx + dy * dy <= radius * radius && random.NextDouble() < 0.85)
                        {
                            int ny = cy + dy;
                            int nx = cx + dx;

                            // Защита от выхода за границы массива
                            if (ny > 0 && ny < rowsCount - 1 && nx > 0 && nx < colsCount - 1)
                            {
                                fields[ny, nx] = WATER;
                            }
                        }
                    }
                }
            }


            // Вычисляем размер клетки, чтобы всё поле влезло в PictureBox
            int sizeW = pictureBox1.Width / colsCount;
            int sizeH = pictureBox1.Height / rowsCount;
            cellSize = Math.Min(sizeW, sizeH); // Берем минимальное, чтобы клетки были квадратными

            if (cellSize < 1) cellSize = 1;

            pictureBox1.Invalidate();
        }

        //Учет ветра
        public void Wind(object sender, EventArgs e)
        {
            NZ = new double[8];

            for (int i = 0; i < 8; i++)
            {

                string direction = comboBox1.SelectedItem.ToString();

                int NY = neighbourhood[i, 0];
                int NX = neighbourhood[i, 1];

                NZ[i] = 1;

                if (direction == "Север" && NY > 0) NZ[i] = 0.1; // Ветер с севера затрудняет уход огня вниз
                if (direction == "Юг" && NY < 0) NZ[i] = 0.1;   // Ветер с юга затрудняет уход огня вверх
                if (direction == "Восток" && NX < 0) NZ[i] = 0.1; // Ветер с востока мешает идти влево
                if (direction == "Запад" && NX > 0) NZ[i] = 0.1;  // Ветер с запада мешает идти вправо
            }
        }

        public void temperature(object sender, EventArgs e)
        {
            double temperature_air = (double)temper.Value;
            tempFactor = (temperature_air + 50) / 100.0;

        }

        // поджигание кликом мыши
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int ix = e.X / cellSize;
            int iy = e.Y / cellSize;

            if (ix >= 0 && ix < colsCount && iy >= 0 && iy < rowsCount && fields[iy, ix] == TREE)
            {
                fields[iy, ix] = FIRE; // Поджигаем дерево кликом
                pictureBox1.Invalidate();
            }
        }

        private void rows_ValueChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void columns_ValueChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fields = Iteration(fields);
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
