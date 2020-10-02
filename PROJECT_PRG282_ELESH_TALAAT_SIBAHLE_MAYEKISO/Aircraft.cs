using System.Drawing;

namespace PROJECT_PRG282_ELESH_TALAAT_SIBAHLE_MAYEKISO
{
    class Aircraft
    {
        public Bitmap aircraft { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int Velocity { get; set; }

        public Aircraft()
        {
        }

        public void Draw(Graphics gfx)
        {
            // Draw sprite image on screen
            gfx.DrawImage(aircraft, new RectangleF(X, Y, Width, Height));
        }
    }
}