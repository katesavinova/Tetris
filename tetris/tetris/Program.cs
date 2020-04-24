using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(35, 30);//изменение размера окна для игры
            Console.SetBufferSize(35, 30);//Убрать полоски прокрутки

            int x1 = 2, y1 = 3, x2 = 2, y2 = 9;
            char c1 = '*', c2='+';
            Drow(x1,y1,c1);
            Drow(x2, y2, c2);

            Console.ReadLine();
            static void Drow(int x, int y, char c)//функция,выводящая один символ
            {
                Console.SetCursorPosition(x, y);
                Console.Write(c);
            }
        }
    }
}
