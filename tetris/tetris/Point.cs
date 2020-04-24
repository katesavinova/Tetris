
using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        /*КОНСТРУКТОР*/
        public Point(int a, int b, char var)
        {
            x = a;
            y = b;
            c = var;
        }
    }
}