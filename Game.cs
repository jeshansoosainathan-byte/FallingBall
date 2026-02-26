// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Vector2 position = new Vector2(200, 50);
        Vector2 gravity = new Vector2(0, 8);
        Vector2 velocity;
        float radius = 25;

        float forceKept = 0.50f;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Ball Bounce");
            Window.SetSize(400, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);


            //Move Ball With Gravity
            
            velocity += gravity;
            position += velocity * Time.DeltaTime;

            //Check if we're bellow screen height
            if (position.Y + radius > Window.Height)
            {
                //Move ball to touch edge
                position.Y = Window.Height - radius;
                //Invert velocity to bounce up, scale velocity down a bit
                velocity.Y = -velocity.Y * forceKept;


            }


            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Red;
            Draw.Circle(position, radius);

        }
    }

}
