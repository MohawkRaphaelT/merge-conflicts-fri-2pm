using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace game;

internal class loremipsum
{
    public loremipsum()
    {
        Raylib.DrawText("Lorem Ipsum", 250, 127, 27, Color.BEIGE);
    }
}
