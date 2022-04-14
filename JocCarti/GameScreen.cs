using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace JocCarti
{
    public partial class GameScreen : Form
    {

        public Spatiu[,] TablaDeJoc = new Spatiu[20, 20];
        private SqlConnection conn;
        SqlCommand cmd;
        public DataTable ClasamentT = new DataTable();


        Size Zero = new Size(0,0);
        Bitmap NullBitmap = new Bitmap(1, 1);

        //public int PB1P=0, PB2P=0, PB3P=0, PB4P=0, PB5P=0, PB6P=0, PB13P=0, PB14P=0, PB15P=0, PB16P=0, PB17P=0, PB18P=0;

        public int[] PBP = new int[30];

        public Timer MyTimer = new Timer();

        public int i, n = 5, value, ok=0, nr=0, nr1=0,id=1;
        public int timp = 0, timp1 = 0, tempo = 0;
        public string value1;
        public int[] c = new int[20];
        public int[] c1 = new int[20];
        public int[] a = new int[20];
        Random rnd = new Random();
        public string[] Carti = { "2C.png", "2D.png", "AS.png", "10H.png", "10S.png", "AD.png" };
        public string[] CartiD = { "2C.png", "2D.png", "AS.png", "10H.png", "10S.png", "AD.png" };
        public string[] Carti1 = new string[20];
        public string[] Carti2 = new string[20];
       
        public void Cifre()
        {
            for (int j = 0; j < 6; j++)
            {
                c[j] = j;
                c1[j] = j;
                a[j+1] = 0;
                a[j + 6 + 1] = 0;
            }
        }

        public void Randomizare(string[] Carti, int[] c, string[] Carti1)
        {
            
            while (n > 0)
            {
                int k = rnd.Next(n + 1);
                value = c[k];
                c[k] = c[n];
                c[n] = value;
                n--;
            }
            for (i = 0; i < 6; i++)
            {
                value1 = Carti[i];
                Carti[i] = Carti[c[i]];
                Carti[c[i]] = value1;
            }
            for(int i=1;i<=6;i++)
            {
                Carti1[i] = Carti[i-1];
            }
        }

        public GameScreen()
        {
            InitializeComponent();
        }

        void GenerareJoc()
        {
            int x, y, j=0, d=0, x1=1, y1=1;
            for(y=12; y<=188; y+=176)
            {
                for(x=12; x<=567; x+=111)
                {
                    j = x / 111;
                    Spatiu spatiuNou = new Spatiu(new Point(x, y));
                    spatiuNou.PB.Image = new Bitmap("gray_back.png");
                    if (d == 0) spatiuNou.Carte.Image = new Bitmap(Carti[j]);
                    else spatiuNou.Carte.Image = new Bitmap(CartiD[j]);
                    this.Controls.Add(spatiuNou.PB);
                    this.Controls.Add(spatiuNou.Carte);
                    spatiuNou.PB.BringToFront();
                    TablaDeJoc[x1, y1] = spatiuNou;
                    TablaDeJoc[x1, y1].PB.Cursor=Cursors.Hand;
                    TablaDeJoc[x1, y1].Carte.Cursor = Cursors.Hand;
                    y1++;
                }
                d++;
                x1++;
                y1=1;
            }
        }

        void afisare()
        {
            for(int i=1;i<=6;i++)
            {
                Console.WriteLine(Carti[i-1]);
                Console.WriteLine(Carti1[i]);
            }
        }
        
        void carti()
        {
            nr++;
            if (nr == 2)
            {
                tempo = 1;
                timp1 = timp;
            }
        }

        void ascundere(int i ,int j)
        {
            if(i==1)
            {
                if((PBP[j]!=-1)&&(a[i]==0))
                {
                    TablaDeJoc[1, j].PB.Hide();
                    a[j] = 1;
                    carti();
                }
            }
            else
            {
                if((PBP[j+6]!=-1)&&(a[j+6]==0))
                {
                    TablaDeJoc[2, j].PB.Hide();
                    a[j + 6] = 1;
                    carti();
                }
            }
        }

        void tictac()
        {
            int nr2 = nr1;
            Joc();
            if (nr2 == nr1)
            {
                if (tempo == 1) if (timp1 + 15 == timp) tempo = 0;
                if ((tempo == 0) && (nr == 2))
                {
                    for (int i = 1; i <= 12; i++)
                    {
                        if (a[i]==1)
                        {
                            if (i <= 6)
                            {
                                TablaDeJoc[1, i].PB.Show();
                                a[i] = 0;
                                PBP[i]++;
                            }
                            else
                            {
                                TablaDeJoc[2, i - 6].PB.Show();
                                a[i] = 0;
                                PBP[i]++;
                            }
                        }
                    }
                    nr = 0;
                }
            }
        }

        void Joc()
        {
            if (nr == 2)
            {
                for (int i = 1; i <= 12; i++)
                {
                    if ((a[i] == 1) && (PBP[i] != -1))
                    {
                        for (int j = i+1; j <= 12; j++)
                        {
                            if ((a[j] == 1) && (PBP[j] != -1))
                            {
                                if (i <= 6)
                                {
                                    if (j <= 6)
                                    {
                                        if (Carti1[i] == Carti1[j])
                                        {
                                            Console.WriteLine(i);
                                            Console.WriteLine(j);
                                            PBP[i] = -1; PBP[j] = -1;
                                            nr1++;
                                            a[i] = 0; a[j] = 0;
                                            nr = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (Carti1[i] == Carti2[j - 6])
                                        {
                                            Console.WriteLine(Carti1[i]);
                                            PBP[i] = -1; PBP[j] = -1;
                                            nr1++;
                                            a[i] = 0; a[j] = 0;
                                            nr = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    if (j <= 6)
                                    {
                                        if (Carti2[i - 6] == Carti1[j])
                                        {
                                            PBP[i] = -1; PBP[j] = -1;
                                            nr1++;
                                            a[i] = 0; a[j] = 0;
                                            nr = 0;
                                        }
                                    }
                                    else
                                    {
                                        if (Carti2[i - 6] == Carti2[j - 6])
                                        {
                                            PBP[i] = -1; PBP[j] = -1;
                                            nr1++;
                                            a[i] = 0; a[j] = 0;
                                            nr = 0;
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                if (nr1 == 6)
                {
                    MessageBox.Show("Congratulations! You WON!");
                    conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\bin\Debug\ClasamentBazaDeDate.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO TabelaClasament (NUME, SCOR) Values(@NAME,@SCORE)",conn);
                    if(textBox1.Text=="")
                    {
                        cmd.Parameters.AddWithValue("@NAME", "Unknown");
                    }
                    else cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                    cmd.Parameters.AddWithValue("@SCORE", timp);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        void Reset()
        {
            Randomizare(Carti, c, Carti1);
            Randomizare(CartiD, c1, Carti2);
            nr = 0;
            nr1 = 0;
            timp = 0;
            for(int i=1;i<=2;i++)
            {
                for(int j=1;j<=6;j++)
                {
                    PBP[j] = 0; PBP[j + 6] = 0;
                    a[j] = 0; a[j + 6] = 0;
                    TablaDeJoc[i, j].PB.Show();
                    if(i==1) TablaDeJoc[i, j].Carte.Image = new Bitmap(Carti1[j]);
                    else TablaDeJoc[i, j].Carte.Image = new Bitmap(Carti2[j]);
                }
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            MyTimer.Tick += new EventHandler(timer1_Tick_1);
            MyTimer.Start();
            Cifre();
            Randomizare(Carti, c, Carti1);
            Randomizare(CartiD , c1, Carti2);
            GenerareJoc();
            TablaDeJoc[1, 1].PB.Click += PB1_Click;
            TablaDeJoc[1, 2].PB.Click += PB2_Click;
            TablaDeJoc[1, 3].PB.Click += PB3_Click;
            TablaDeJoc[1, 4].PB.Click += PB4_Click;
            TablaDeJoc[1, 5].PB.Click += PB5_Click;
            TablaDeJoc[1, 6].PB.Click += PB6_Click;
            TablaDeJoc[2, 1].PB.Click += PB13_Click;
            TablaDeJoc[2, 2].PB.Click += PB14_Click;
            TablaDeJoc[2, 3].PB.Click += PB15_Click;
            TablaDeJoc[2, 4].PB.Click += PB16_Click;
            TablaDeJoc[2, 5].PB.Click += PB17_Click;
            TablaDeJoc[2, 6].PB.Click += PB18_Click;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void PB1_Click(object sender, EventArgs e)
        {
            if((PBP[1] != -1) && (nr != 2))
            {
                PBP[1]++;
            
            ascundere(1, 1);}
        }

        private void PB2_Click(object sender, EventArgs e)
        {
            if ((PBP[2] != -1) && (nr != 2))
            {
                PBP[2]++;
            
            ascundere(1, 2);}
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            if ((PBP[3] != -1) && (nr != 2))
            {
                PBP[3]++;
            
            ascundere(1, 3);}
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            if ((PBP[4] != -1) && (nr != 2))
            { 
                PBP[4]++;
            
            ascundere(1, 4);}
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            if ((PBP[5] != -1) && (nr != 2))
            {
                PBP[5]++;
            
            ascundere(1, 5);}
        }

        private void PB6_Click(object sender, EventArgs e)
        {
            if ((PBP[6] != -1) && (nr != 2))
            {
                PBP[6]++;
            
            ascundere(1, 6);}
        }

        private void PB14_Click(object sender, EventArgs e)
        {
            if ((PBP[8] != -1) && (nr != 2))
            {
                PBP[8]++;
            
            ascundere(2, 2);}
        }

        private void PB13_Click(object sender, EventArgs e)
        {
            if ((PBP[7] != -1) && (nr != 2))
            {
                PBP[7]++;
            
            ascundere(2, 1);}
        }

        private void PB15_Click(object sender, EventArgs e)
        {
            if ((PBP[9] != -1) && (nr != 2))
            {
                PBP[9]++;
            
            ascundere(2, 3);}
        }

        private void PB16_Click(object sender, EventArgs e)
        {
            if ((PBP[10] != -1) && (nr != 2))
            {
                PBP[10]++;
            
            ascundere(2, 4);}
        }

        private void PB17_Click(object sender, EventArgs e)
        {
            if ((PBP[11] != -1) && (nr != 2))
            {
                PBP[11]++;
            
            ascundere(2, 5);}
        }

        private void PB18_Click(object sender, EventArgs e)
        {
            if ((PBP[12] != -1) && (nr != 2))
            {
                PBP[12]++;
            
            ascundere(2, 6);}
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tictac();
            timp++;
            Console.WriteLine(timp);
        }

        private void RainbowP(object sender, PaintEventArgs e)
        {
            /*LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.BlueViolet, 180F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);*/
        }

        private void Red_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("red_back.png");
                }
            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("yellow_back.png");
                }
            }
        }

        private void Green_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("green_back.png");
                }
            }
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("blue_back.png");
                }
            }
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("purple_back.png");
                }
            }
        }

        private void Rainbow_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    TablaDeJoc[i, j].PB.Image = new Bitmap("rainbow_back.png");
                }
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
