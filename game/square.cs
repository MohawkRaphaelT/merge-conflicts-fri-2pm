using Raylib_cs;

namespace game
{
    internal class Square
    {
        public void Draw()
        {
            Raylib.DrawRectangle(1, 1, 50, 50, Color.BEIGE);
        }
    }
}
