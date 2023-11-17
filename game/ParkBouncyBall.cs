using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace game
{
        public class Ball
        {
            // Variables
            public static Vector2 position;
            public static Vector2 velocity;
            public static float radius;
            public static Ball ball;
            public Ball()
            {
                radius = 10;
                position.X = Raylib.GetScreenWidth() / 2;
                position.Y = Raylib.GetScreenHeight() / 2;
                velocity.X = 300;
                velocity.Y = -300;
            }
            // Draws a ball
            public static void Render()
            {
                Raylib.DrawCircleV(position, radius, Color.BLACK);
            }
            // Initialize the ball
            public static void Setup()
            {
                ball = new Ball();
            }
            // Moves the ball
            public static void Move()
            {
                position = position + velocity * Raylib.GetFrameTime();
            }
            public static void Collision()
            {
                // Variables set to the wall
                float leftEdge = 5;
                float rightEdge = Raylib.GetScreenWidth() - 5;
                float topEdge = 5;
                float bottomEdge = Raylib.GetScreenHeight() - 5;
                // Bool variuables for ball collision
                bool hitEdgeLeft = position.X <= leftEdge + radius;
                bool hitEdgeRight = position.X >= rightEdge - radius;
                bool hitEdgeTop = position.Y <= topEdge + radius;
                bool hitEdgeBottom = position.Y >= bottomEdge - radius;
                // Checks for collision
                if (hitEdgeLeft || hitEdgeRight)
                {
                    velocity.X = -velocity.X;
                }
                if (hitEdgeTop || hitEdgeBottom)
                {
                    velocity.Y = -velocity.Y;
                }
            }
            // Main loop method
            public static void Update()
            {
                Move();
                Collision();
                Render();
            }
        }

}
