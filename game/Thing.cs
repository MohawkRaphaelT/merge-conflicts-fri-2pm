using Raylib_cs;

namespace game
{
    internal class Thing
    {
        public void Draw()
        {
            Raylib.DrawRectangle(100, 100, 100, 100, Color.PINK);
        }
    }
}
