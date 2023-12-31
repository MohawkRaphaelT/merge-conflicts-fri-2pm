﻿using Raylib_cs;

namespace game
{
    internal class Program
    {
        // If you need variables in the Program class (outside functions), you must mark them as static
        static string title = "Game Title";

        // Parker

        // Cole
        static Thing thing;

        // Xander

        // Kyle
        static Square square;
        // Aiden

        // Raph
        static Orb orb;

        
        static void Main(string[] args)
        {
            // Create a window to draw to. The arguments define width and height
            Raylib.InitWindow(800, 600, title);
            // Set the target frames-per-second (FPS)
            Raylib.SetTargetFPS(60);

            // Setup your game. This is a function YOU define.
            Setup();

            // Loop so long as window should not close
            while (!Raylib.WindowShouldClose())
            {
                // Enable drawing to the canvas (window)
                Raylib.BeginDrawing();
                // Clear the canvas with one color
                Raylib.ClearBackground(Color.WHITE);

                // Your game code here. This is a function YOU define.
                Update();

                // Stop drawing to the canvas, begin displaying the frame
                Raylib.EndDrawing();
            }
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {
            // Parker
            BouncyBall.Setup();
            // Cole
            thing = new Thing();

            // Xander


            // Kyle
            square = new Square();
            // Aiden
            
            // Raph
            orb = new Orb();
        }

        static void Update()
        {
            // Parker
            BouncyBall.Update();
            // Cole
            thing.Draw();
            // Xander
            loremipsum.Draw();

            // Kyle
            square.Draw();
            // Aiden

            // Raph
            orb.Draw();
        }
    }
}