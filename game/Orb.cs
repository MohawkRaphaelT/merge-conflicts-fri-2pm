using Raylib_cs;

namespace game
{
    internal class Orb
    {
        public void Draw()
        {
            Raylib.DrawCircle(200, 200, 100, Color.RED);
        }
    }
}
