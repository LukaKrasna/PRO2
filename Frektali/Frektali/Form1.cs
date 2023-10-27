using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frektali
{
    public partial class Form1 : Form
    {
        double x;
        double y;
        double a; //pozicija in usmerjenost želve
        public Form1()
        {
            InitializeComponent();
        }
        private int slikaX(double xr) { return (int)Math.Round(xr * this.Width); }
        private int slikaY(double yr) { return (int)Math.Round(this.Height-yr * this.Height); }
        public void ObratLevo(double kot)
        {
            a = a + kot;
        }
        public void Premik(double d, Graphics g)
        {
            double xStari = x;
            double yStari = y;
            x = x + d * Math.Cos(a * Math.PI / 180);
            y = y + d * Math.Sin(a * Math.PI / 180);
            //nariši črto
            //prva točka je
            int x1 = slikaX(xStari);int y1 = slikaY(yStari);
            //druga točka
            int x2 = slikaX(x);int y2 = slikaY(y);
            g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);
        }

        //ta del je nujen samo za Koch vzorce
        private void Koch(int n, double korak, Graphics g)
        {
            if (n == 0)
            {
                Premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
            ObratLevo(-120);
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
        }

        //ta del je nujen samo za drevo
        public void Drevo(int n, double x, double y, double a, double dolžina, Graphics g)
        {
            double nagib = 30;
            double medVejami = 45;
            double količnik = 0.65;
            //nariši eno vejo
            double cx = x + Math.Cos(a * Math.PI / 180)*dolžina;
            double cy = y + Math.Sin(a * Math.PI / 180) * dolžina;
            int x1 = slikaX(x);
            int y1 = slikaY(y);
            int x2= slikaX(cx);
            int y2= slikaY(cy);
            //dodajmo naključno barvo
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), 100);
            //dodamo debelino vej
            Pen p = new Pen(c, (float)(4 * 0.3 * Math.Pow(n, 1.2)));
            g.DrawLine(p, x1, y1, x2, y2);
            if (n == 0) return;
            Drevo(n - 1, cx, cy, a - medVejami + nagib, dolžina * količnik, g);//levo drevo
            Drevo(n - 1, cx, cy, a + nagib, dolžina * (1 - količnik), g);//sredinsko drevo
            Drevo(n - 1, cx, cy, a + medVejami + nagib, dolžina * količnik, g);//deblo drevesa

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*
            //Trikotnik
            Graphics g = e.Graphics;
            x = 0.5;y = 0.1;a = 60;
            Premik(0.6, g);
            ObratLevo(120);
            Premik(0.6, g);
            ObratLevo(120);
            Premik(0.6, g);
            */

            /*
            //Spontani vzorci
            Graphics g = e.Graphics;
            x = 0.5; y = 0.5; a = 0;
            Random r = new Random();
            for (int k = 0; k < 1000; k++)
            {
                Premik(0.05, g);
                ObratLevo(r.Next(360));
            }
            */

            /*
            //Koch vzorci (snežinka)
            Graphics g = e.Graphics;
            x = 0.2; y = 0.2; a = 0;//začetni vzorci
            int n = 5;
            double korak = 0.3 / Math.Pow(3, n);
            for (int b = 0; b <= 5; b ++)
            {
                Koch(n, korak, g);
                a = a + 60;
            }
            */

            //Drevo
            Graphics g = e.Graphics;
            int n = 5;
            Drevo(n, 0.5, 0.1, 90, 0.3, g);

            //to je svoja reč, ki nariše diagonalno črto:
            //Graphics g = e.Graphics;
            //Pen pero = new Pen(Color.Blue, 3);
            //g.DrawLine(pero, 10, 10, 250, 250);
        }
    }
}
