using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;
using System.Timers;


namespace Galaga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(this.Width - 16, this.Height - 39);
            g = Graphics.FromImage(bm);
            g.Clear(Color.Black);
            this.BackgroundImage = bm;
            nave();
            nivel();
            timerEnemys.Start();
            contador = 0;
            timerTiempo.Start();
            
        }
        Graphics g;
        Bitmap bm;
        Point px, py;
        Pen lapiz;
        bool shoot = false;
        Point punto;
        Thread hilo1, hilo2;
        Action accion;
        PictureBox[] enemys = new PictureBox[5];
        int contador;
        PictureBox pic1 = new PictureBox();
        informacion info = new informacion();
        int contadorPuntos = 0;



        private void nave()
        {
            
            pic1.BackColor = Color.Transparent;
            pic1.Name = "pictureBox1";
            pic1.Image = Image.FromFile("C:\\Users\\benja\\Desktop\\nave2.png");
            Point p = new Point();
            int y = SystemInformation.PrimaryMonitorSize.Height;
            p.X = this.Width / 2;
            p.Y = y - 150;
            pic1.Location = p;
            pic1.SizeMode = PictureBoxSizeMode.Zoom;
            pic1.Size = new Size(50,50);
            this.Controls.Add(pic1);
        }

        private void disparo(Point p)
        {
            PictureBox pic = new PictureBox();
            pic.BackColor = Color.Transparent;
            pic.Image = Image.FromFile("C:\\Users\\benja\\Desktop\\disparo1.png");
            pic.Location = p;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Size = new Size(14, 22);

            while (p.Y >= 0)
            {
                int y = SystemInformation.PrimaryMonitorSize.Height;

                if (p.Y <= 10){ pic.Dispose(); break; }
                else
                {
                    p.X = p.X;
                    p.Y = p.Y - 8;
                            
                    pic.Location = p;
                    this.Controls.Add(pic);
                    pic.Refresh();

                    if (p.X + 14 >= enemys[1].Location.X && p.X + 14 <= enemys[1].Location.X + enemys[1].Width && p.Y >= enemys[1].Location.Y && p.Y < enemys[1].Location.Y + enemys[1].Height && p.X >= enemys[1].Location.X && p.X <= enemys[1].Location.X + enemys[1].Width
                    && p.Y >= enemys[1].Location.Y && p.Y < enemys[1].Location.Y + enemys[1].Height && p.X + 14 >= enemys[1].Location.X && p.X + 14 <= enemys[1].Location.X + enemys[1].Width && p.Y + 22 >= enemys[1].Location.Y
                    && p.Y + 22 < enemys[1].Location.Y + enemys[1].Height && p.X >= enemys[1].Location.X && p.X <= enemys[1].Location.X + enemys[1].Width && p.Y + 22 >= enemys[1].Location.Y && p.Y < enemys[1].Location.Y + enemys[1].Height)
                    {
                        //MessageBox.Show("haha");
                        pic.Dispose();
                        enemys[1].Dispose();
                        contadorPuntos += 5;
                        info.Puntos = contadorPuntos;
                        break;

                        //pictureBox2.Dispose();
                    }
                    else if (p.X + 14 >= enemys[2].Location.X && p.X + 14 <= enemys[2].Location.X + enemys[2].Width && p.Y >= enemys[2].Location.Y && p.Y < enemys[2].Location.Y + enemys[1].Height && p.X >= enemys[2].Location.X && p.X <= enemys[2].Location.X + enemys[2].Width
                    && p.Y >= enemys[2].Location.Y && p.Y < enemys[2].Location.Y + enemys[2].Height && p.X + 14 >= enemys[2].Location.X && p.X + 14 <= enemys[2].Location.X + enemys[2].Width && p.Y + 22 >= enemys[2].Location.Y
                    && p.Y + 22 < enemys[2].Location.Y + enemys[2].Height && p.X >= enemys[2].Location.X && p.X <= enemys[2].Location.X + enemys[2].Width && p.Y + 22 >= enemys[2].Location.Y && p.Y < enemys[2].Location.Y + enemys[2].Height)
                    {
                        pic.Dispose();
                        enemys[2].Dispose();
                        contadorPuntos += 5;
                        info.Puntos = contadorPuntos;
                        break;


                    }
                    else if (p.X + 14 >= enemys[3].Location.X && p.X + 14 <= enemys[3].Location.X + enemys[3].Width && p.Y >= enemys[3].Location.Y && p.Y < enemys[3].Location.Y + enemys[1].Height && p.X >= enemys[3].Location.X && p.X <= enemys[3].Location.X + enemys[3].Width
                    && p.Y >= enemys[3].Location.Y && p.Y < enemys[3].Location.Y + enemys[3].Height && p.X + 14 >= enemys[3].Location.X && p.X + 14 <= enemys[3].Location.X + enemys[3].Width && p.Y + 22 >= enemys[3].Location.Y
                    && p.Y + 22 < enemys[3].Location.Y + enemys[3].Height && p.X >= enemys[3].Location.X && p.X <= enemys[3].Location.X + enemys[3].Width && p.Y + 22 >= enemys[3].Location.Y && p.Y < enemys[3].Location.Y + enemys[3].Height)
                    {
                        pic.Dispose();
                        enemys[3].Dispose();
                        contadorPuntos += 5;
                        info.Puntos = contadorPuntos;
                        break;

                    }
                    else if (p.X + 14 >= enemys[4].Location.X && p.X + 14 <= enemys[4].Location.X + enemys[4].Width && p.Y >= enemys[4].Location.Y && p.Y < enemys[4].Location.Y + enemys[1].Height && p.X >= enemys[4].Location.X && p.X <= enemys[4].Location.X + enemys[4].Width
                    && p.Y >= enemys[4].Location.Y && p.Y < enemys[4].Location.Y + enemys[4].Height && p.X + 14 >= enemys[4].Location.X && p.X + 14 <= enemys[4].Location.X + enemys[4].Width && p.Y + 22 >= enemys[4].Location.Y
                    && p.Y + 22 < enemys[4].Location.Y + enemys[4].Height && p.X >= enemys[4].Location.X && p.X <= enemys[4].Location.X + enemys[4].Width && p.Y + 22 >= enemys[4].Location.Y && p.Y < enemys[4].Location.Y + enemys[4].Height)
                    {
                        pic.Dispose();
                        enemys[4].Dispose();
                        contadorPuntos += 5;
                        break;

                    }
                    else if (p.X + 14 >= enemys[0].Location.X && p.X + 14 <= enemys[0].Location.X + enemys[0].Width && p.Y >= enemys[0].Location.Y && p.Y < enemys[0].Location.Y + enemys[1].Height && p.X >= enemys[0].Location.X && p.X <= enemys[0].Location.X + enemys[0].Width
                    && p.Y >= enemys[0].Location.Y && p.Y < enemys[0].Location.Y + enemys[0].Height && p.X + 14 >= enemys[0].Location.X && p.X + 14 <= enemys[0].Location.X + enemys[0].Width && p.Y + 22 >= enemys[0].Location.Y
                    && p.Y + 22 < enemys[0].Location.Y + enemys[0].Height && p.X >= enemys[0].Location.X && p.X <= enemys[0].Location.X + enemys[0].Width && p.Y + 22 >= enemys[0].Location.Y && p.Y < enemys[0].Location.Y + enemys[0].Height)
                    {
                        pic.Dispose();
                        enemys[0].Dispose();
                        contadorPuntos += 5;
                        info.Puntos = contadorPuntos;
                        break;

                    }


                }
            }
            info.lblPunto.Text = contadorPuntos.ToString();
                
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                 disparo(punto);
            }
        }
        public void move(string letra)
        {

            if (letra == "D")
            {
                int x = pic1.Location.X + 8;
                int y = pic1.Location.Y;
                if (x < 800)
                {
                    Point point = new Point(x, y);
                    pic1.Location = point;
                    punto.X = point.X + 26;
                    punto.Y = point.Y;
                }
            }
            else if (letra == "A")
            {
                int x = pic1.Location.X - 5;
                int y = pic1.Location.Y;
                if (x > 0)
                {
                    Point point = new Point(x, y);
                    pic1.Location = point;
                    punto.X = point.X + 6;
                    punto.Y = point.Y;
                }
            }
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D)
            {
                 move("D");
                
            }
            else if (e.KeyCode == Keys.A)
            {
                move("A");
                
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void enemy(Point p, int numero)
        {
            Random random = new Random();
            int enemigo = random.Next(1, 3);
            PictureBox pic = new PictureBox();
            pic.BackColor = Color.Transparent;
            pic.Image = Image.FromFile($"C:\\Users\\benja\\Desktop\\enemy{enemigo}.png");
            pic.Location = p;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Size = new Size(45, 45);
            pic.Name = $"numero{numero}";
            this.Controls.Add(pic);
            enemys[numero - 1] = pic;
        }

        private void nivel()
        {
            int i = 0;
            int numero = 1;
            int y = SystemInformation.PrimaryMonitorSize.Height;

            while (i < 250)
            {
                Point p = new Point();
                p.X = this.Width - 200 - i;
                p.Y = 150;
                enemy(p, numero);
                i += 50;
                numero++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerEnemys_Tick(object sender, EventArgs e)
        {
            Point p = new Point();
            if (enemys[0].Location.Y > this.Height && enemys[1].Location.Y > this.Height && enemys[2].Location.Y > this.Height&& enemys[3].Location.Y > this.Height&& enemys[4].Location.Y > this.Height) 
            {
                enemys[0].Dispose();
                enemys[1].Dispose();
                enemys[2].Dispose();
                enemys[3].Dispose();
                enemys[4].Dispose();
            }
            else 
            {
            
                if (enemys[0].Location.X < this.Width - 120)
                {
                    p.X = enemys[0].Location.X + 3;
                    p.Y = enemys[0].Location.Y + 6;
                    enemys[0].Location = p;
                }
                else
                {
                    p.X = enemys[0].Location.X;
                    p.Y = enemys[0].Location.Y + 6;
                    enemys[0].Location = p;
                }
                if (enemys[4].Location.X > 65)
                {
                    p.X = enemys[4].Location.X - 3;
                    p.Y = enemys[4].Location.Y + 6;
                    enemys[4].Location = p;
                }
                else
                {
                    p.X = enemys[4].Location.X;
                    p.Y = enemys[4].Location.Y + 6;
                    enemys[4].Location = p;
                }
                p.X = enemys[1].Location.X;
                p.Y = enemys[1].Location.Y + 6;
                enemys[1].Location = p;
                p.X = enemys[2].Location.X;
                p.Y = enemys[2].Location.Y + 6;
                enemys[2].Location = p; p.X = enemys[4].Location.X;
                p.X = enemys[3].Location.X;
                p.Y = enemys[3].Location.Y + 6;
                enemys[3].Location = p;
            }

            if (enemys[0].IsDisposed && enemys[1].IsDisposed && enemys[2].IsDisposed && enemys[3].IsDisposed && enemys[4].IsDisposed)
            {
                nivel();
            }
        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            
            contador++;
            if (contador == 60)
            {
                timerEnemys.Enabled = false;
                timerTiempo.Enabled = false;
                DialogResult result = MessageBox.Show("Fin del nivel \n ¿Desea continuar?", "Atencion", buttons: MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    enemys[0].Dispose();
                    enemys[1].Dispose();
                    enemys[2].Dispose();
                    enemys[3].Dispose();
                    enemys[4].Dispose();

                    timerEnemys.Enabled = true;
                    contador = 0;
                    timerTiempo.Enabled=true;
                }
                else { this.Close(); }
            }
            Random r = new Random();
            int pixel = r.Next(this.Width,this.Height);
            Point p1 = new Point();
            p1.X = pixel;
            p1.Y = pixel;
            Point p2 = new Point();
            p2.X = pixel;
            p2.X = pixel;
            Pen l = new Pen(Color.White, 3);
            g.DrawLine(l,p1,p2);
        }
    }
}
