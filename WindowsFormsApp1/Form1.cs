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
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height); //привязали изображение

            this.emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.50f,

                //   ColorFrom = Color.Gold,
                //  ColorTo = Color.FromArgb(0, Color.AliceBlue),
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width - 30,
                Y = picDisplay.Height / 2 + 100,
            });

            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width * 0 + 30,
                Y = picDisplay.Height / 2 + 100,
            });
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.FromArgb(0, 0, 0, 0));
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

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }
    }
}
