using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Particle;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Particle> particles = new List<Particle>(); //список частиц
        Emitter emitter = new Emitter();

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height); //привязали изображение

            emitter.gravityPoints.Add(new Point(
            picDisplay.Width, picDisplay.Height / 2
            ));

            emitter.gravityPoints.Add(new Point(
            picDisplay.Width * 0, picDisplay.Height / 2
            ));
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }
    }
}
