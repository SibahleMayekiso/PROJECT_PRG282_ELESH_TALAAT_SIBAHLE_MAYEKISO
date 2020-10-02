using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_PRG282_ELESH_TALAAT_SIBAHLE_MAYEKISO
{
    public partial class Form1 : Form
    {
        Timer graphicsTimer;
        GameLoop gameLoop;
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
            // Initialize Paint Event
            Paint += Form1_Paint;
            // Initialize graphicsTimer
            graphicsTimer = new Timer();
            graphicsTimer.Interval = 1000 / 120;
            graphicsTimer.Tick += GraphicsTimer_Tick;

            //Attacks
            float co = camp1.Left;
            float cod = camp1.Top;
            Aircraft ac = new Aircraft();
            ac.X = 135;
            float x = ac.X;
            ac.Y = 71;
            float y = ac.Y;
            ac.Y = 71;
            MessageBox.Show(counter.ToString());
            if (x == co || y == cod)
            {
                counter++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Rectangle resolution = Screen.PrimaryScreen.Bounds;

            // Initialize Game
            Game myGame = new Game();
            myGame.Resolution = new Size(resolution.Width, resolution.Height);

            // Initialize & Start GameLoop
            gameLoop = new GameLoop();
            gameLoop.Load(myGame);
            gameLoop.Start();

            // Start Graphics Timer
            graphicsTimer.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw game graphics on Form1
            gameLoop.Draw(e.Graphics);
        }
        private void GraphicsTimer_Tick(object sender, EventArgs e)
        {
            // Refresh Form1 graphics
            Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(counter.ToString());

            GameLoop gl = new GameLoop();
            gl.Stop();
        }
    }
}
