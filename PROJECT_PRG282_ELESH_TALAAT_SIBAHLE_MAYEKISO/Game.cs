using System;
using System.Drawing;
using System.Windows.Input;

namespace PROJECT_PRG282_ELESH_TALAAT_SIBAHLE_MAYEKISO
{
    class Game
    {
        private Aircraft playerAircraft;

        public Size Resolution { get; set; }

        public void Load()
        {
            // Load new sprite class
            playerAircraft = new Aircraft();
            // Load sprite image
            playerAircraft.aircraft = Properties.Resources.aircraft;
            // Set sprite height & width in pixels
            playerAircraft.Width = playerAircraft.aircraft.Width;
            playerAircraft.Height = playerAircraft.aircraft.Height;
            // Set sprite coodinates
            playerAircraft.X = 135;
            playerAircraft.Y = 71;
            // Set sprite Velocity
            playerAircraft.Velocity = 300;
        }

        public void Unload()
        {
            // Unload graphics
            // Turn off game music
        }

        public void Update(TimeSpan gameTime)
        {
            // Gametime elapsed
            double gameTimeElapsed = gameTime.TotalMilliseconds / 1000;
            // Calculate sprite movement based on Sprite Velocity and GameTimeElapsed
            int moveDistance = (int)(playerAircraft.Velocity * gameTimeElapsed);

            // Move player sprite, when Arrow Keys are pressed on Keyboard
            if ((Keyboard.GetKeyStates(Key.Right) & KeyStates.Down) > 0)
            {
                playerAircraft.X += moveDistance;
            }
            else if ((Keyboard.GetKeyStates(Key.Left) & KeyStates.Down) > 0)
            {
                playerAircraft.X -= moveDistance;
            }
            else if ((Keyboard.GetKeyStates(Key.Up) & KeyStates.Down) > 0)
            {
                playerAircraft.Y -= moveDistance;
            }
            else if ((Keyboard.GetKeyStates(Key.Down) & KeyStates.Down) > 0)
            {
                playerAircraft.Y += moveDistance;
            }
        }

        public void Draw(Graphics gfx)
        {
            // Draw Background Color
            gfx.FillRectangle(new SolidBrush(Color.CornflowerBlue), new Rectangle(0, 0, Resolution.Width, Resolution.Height));

            // Draw Player Sprite
            playerAircraft.Draw(gfx);
        }
    }
}
