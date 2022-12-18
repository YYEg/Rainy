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
        private Radar radar;

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height); //привязали изображение

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.PowderBlue,
                ColorTo = Color.FromArgb(0, Color.SteelBlue),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

            emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f,
            };

            

            emitter.impactPoints.Add(new AntiGravityPoint
            {
                X = picDisplay.Width - 380,
                Y = picDisplay.Height / 2,
            });

            radar = new Radar
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            emitter.impactPoints.Add(radar);
            picDisplay.MouseWheel += picDisplay_MouseWheel;

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

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                radar.ChangeSize(-2);
            }
            else if (e.Delta < 0)
            {
                radar.ChangeSize(2);
            }
        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }

            radar.X = e.X;
            radar.Y = e.Y;
        }

        private void tbMakeSunny_Scroll(object sender, EventArgs e)
        {
            lblSunny.Text = "It's rainy T_T";
            foreach (var p in emitter.impactPoints)
            {
                if (p is AntiGravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                {
                    (p as AntiGravityPoint).Power = tbMakeSunny.Value;
                }
            }
            if(tbMakeSunny.Value > 80)
            {
                lblSunny.Text = "It's sunny *o*";
            }
            else
            {
                lblSunny.Text = "It's rainy T_T";
            }
        }

        private void trackBarParticlesPerTick_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = trackBarParticlesPerTick.Value;
            lblMoreRainDrops.Text = $"It's about : {trackBarParticlesPerTick.Value} raindrops per tick";
        }
    }
}