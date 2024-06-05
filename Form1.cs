namespace IMLab12
{
    public partial class Form1 : Form
    {
        static double[,] _weatherTable = new double[4, 4]
        {
            { 0.3, 0.4, 0.2, 0.1 }, //ясно
            { 0.1, 0.2, 0.5, 0.2 }, //облачно
            { 0.1, 0.3, 0.2, 0.4 }, //пасмурно
            { 0.5, 0.1, 0.2, 0.2 }, //дождь
        };
        static int[] _weatherStatistic = new int[4] { 0, 0, 0, 0 };
        Random _rnd = new Random();
        static int _currentState = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void NextState()
        {
            double rnd = _rnd.NextDouble();
            int k = 0;
            while (rnd > 0)
            {
                rnd -= _weatherTable[_currentState, k];
                k++;
            }
            _currentState = k - 1;
            _weatherStatistic[_currentState]++;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            NextState();

            label1.Text = _currentState.ToString();
            chart1.Series[0].Points.AddXY(_currentState, _weatherStatistic[_currentState]);
        }
        void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                Nulify();
                timer1.Start();
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            Nulify();
            Statistics(Int32.Parse(NBox.Text));
        }
        void Nulify()
        {
            _weatherStatistic[0] = 0;
            _weatherStatistic[1] = 0;
            _weatherStatistic[2] = 0;
            _weatherStatistic[3] = 0;
            chart1.Series[0].Points.Clear();
        }
        void Statistics(int N)
        {
            for (int i =0; i < N; i++)
            {
                NextState();
            }
            chart1.Series[0].Points.AddXY(0, _weatherStatistic[0]);
            chart1.Series[0].Points.AddXY(1, _weatherStatistic[1]);
            chart1.Series[0].Points.AddXY(2, _weatherStatistic[2]);
            chart1.Series[0].Points.AddXY(3, _weatherStatistic[3]);
            StatisticsLabel.Text = Math.Round((double)_weatherStatistic[0]/N, 2).ToString() + " " + Math.Round((double)_weatherStatistic[1]/N, 2).ToString() + " " + Math.Round((double)_weatherStatistic[2] / N, 2).ToString() + " " + Math.Round((double)_weatherStatistic[3] / N, 2).ToString();
        }
    }
}
