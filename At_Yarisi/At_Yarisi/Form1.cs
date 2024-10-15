namespace At_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int at1SolUzaklik, at2SolUzaklik, at3SolUzaklik;
        Random rastgeleUzaklik = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            at1SolUzaklik = pictureBox1.Left;
            at2SolUzaklik = pictureBox2.Left;
            at3SolUzaklik = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            listBox1.Items.Clear();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int at1Genislik = pictureBox1.Width;
            int at2Genislik = pictureBox2.Width;
            int at3Genislik = pictureBox3.Width;

            int bitisUzaklik = label5.Left;


            //      RES�MLER� YATAY D�ZLEMDE HAREKET ETT�RME    
            pictureBox1.Left += rastgeleUzaklik.Next(10, 15);
            pictureBox2.Left += rastgeleUzaklik.Next(10, 15);
            pictureBox3.Left += rastgeleUzaklik.Next(10, 15);



            //      B�T�� UZAKLI�INA YAKIN OLAN B�R�NC� AT OLUR 
            if (at1Genislik + pictureBox1.Left >= bitisUzaklik)
            {
                timer1.Stop();

                listBox1.Items.Add("1 Numaral� at, yar��� kazand�!!");

            }
            else if (at2Genislik + pictureBox2.Left >= bitisUzaklik)
            {
                timer1.Stop();
                listBox1.Items.Add("2 Numaral� at, yar��� kazand�!!");
            }
            else if (at3Genislik + pictureBox3.Left >= bitisUzaklik)
            {
                timer1.Stop();
                listBox1.Items.Add("3 Numaral� at, yar��� kazand�!!");
            }
            else
            {
                if (timer1.Interval % 50 == 0)
                {
                    if (at1Genislik + pictureBox1.Left >= at2Genislik + pictureBox2.Left && at1Genislik + pictureBox1.Left >= at3Genislik + pictureBox3.Left)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("1 Numaral� at, yar��� �nde!");
                    }
                        
                    else if (at2Genislik + pictureBox2.Left >= at3Genislik + pictureBox3.Left)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("2 Numaral� at, yar��� �nde!");
                    }
                       
                    else
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add("3 Numaral� at, yar��� �nde!");
                    }
                        
                }
            }

        }
    }
}